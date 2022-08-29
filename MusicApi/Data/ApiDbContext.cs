using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using MusicApi.Models;

namespace MusicApi.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext>options) : base(options) 
        {

        }
        public DbSet<Song> Songs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    Id = 1,
                    Title = "May 16th",
                    Genre = "Punk",
                    Duration = "2:12"
                },
                new Song
                {
                    Id = 2,
                    Title = "Fall Back Down",
                    Genre = "Punk",
                    Duration = "3:12"
                },
                new Song
                {
                    Id = 3,
                    Title = "Sophomore Slump or Comeback of the Year",
                    Genre = "Punk",
                    Duration = "3:15"
                },
                new Song
                {
                    Id = 4,
                    Title = "Red Hot Moon",
                    Genre = "Punk",
                    Duration = "1:56"
                },
                new Song
                {
                    Id = 5,
                    Title = "Sabbath Bloody Sabbath",
                    Genre = "Metal",
                    Duration = "2:17"
                },
                new Song
                {
                    Id = 6,
                    Title = "Alabama Bound",
                    Genre = "Blues",
                    Duration = "2:46"
                },
                new Song
                {
                    Id = 7,
                    Title = "Ain't No Joke Bein' Broke",
                    Genre = "Rocksteady",
                    Duration = "4:10"
                }) ;
        }
    }
}
