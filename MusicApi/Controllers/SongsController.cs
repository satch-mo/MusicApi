﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicApi.Data;
using MusicApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {

        private ApiDbContext _dbContext;
        public SongsController(ApiDbContext dbContext)
            {
                _dbContext = dbContext;
            }    


        // GET: api/<SongsController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //return _dbContext.Songs; -- pre-statuscode implementation
            return Ok(await _dbContext.Songs.ToListAsync());
            // status code impl examples:
            //return BadRequest();
            //return NotFound();
            //return StatusCode(200);
            //return StatusCode(StatusCodes.Status400BadRequest);
        }

        // GET api/<SongsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var song = await _dbContext.Songs.FindAsync(id);
            if (song == null)
            {
                return NotFound("No record found against this Id");
            }
             return Ok(song);
            
        }
        // POST api/<SongsController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Song song)
        {
            await _dbContext.Songs.AddAsync(song);
            await _dbContext.SaveChangesAsync();         // used anytime you want to update database
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<SongsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Song songObj)
        {
            var song = await _dbContext.Songs.FindAsync(id);
            if (song == null)
            {
                return NotFound("No record found against this Id");
            }
            else
            {
                song.Title = songObj.Title;
                song.Genre = songObj.Genre;
                song.Duration = songObj.Duration;
                await _dbContext.SaveChangesAsync();
                return Ok("Record updated successfully");
            }
        }

        // DELETE api/<SongsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var song =  await _dbContext.Songs.FindAsync(id);
            if (song == null)
            {
                return NotFound("No record found against this Id");
            }
            else
            {
                _dbContext.Songs.Remove(song);
                await _dbContext.SaveChangesAsync();
                return Ok("Record Deleted");
            }
        }
    }
}
