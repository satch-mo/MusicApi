
    /*
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicApi.Models;

namespace MusicApi.Controllers
{
    [Route("api/[controller]")]         // URL -- songs is actually the controller
    [ApiController]
    public class SongsController : ControllerBase
    {
        private static List<Song> songs = new List<Song>()
        {
            new Song(){Id = 0, Title = "May 16th", Genre = "Punk" },
            new Song(){Id = 1, Title = "Fall Back Down", Genre = "Punk" },
        };

        [HttpGet]       // get attribute 
        public IEnumerable<Song> Get()
        {
            return songs;
        }

        [HttpPost]
        public void Post([FromBody]Song song)
        { 
            songs.Add(song);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Song song) 
        {
            songs[id] = song;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            songs.RemoveAt(id);
        }
    }
}
*/

// this controller was serving http requests while server was running.
// in order to get info to persist, we need to code c# that will generate us a DB instead
// using entity framework