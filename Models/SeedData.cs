using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesGame.Data;

namespace VideoGameDatabase.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesGameContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesGameContext>>()))
            {
                if (context == null || context.Game == null)
                {
                    throw new ArgumentNullException("Null RazorPagesGameContext");
                }

                // Look for any movies.
                if (context.Game.Any())
                {
                    return;   // DB has been seeded
                }

                context.Game.AddRange(
                    new Game
                    {
                        Title = "The Legend of Zelda: Ocarina of Time",
                        ReleaseDate = DateTime.Parse("1998-11-21"),
                        Genre = "Action role-playing game",
                        Price = 7.99M
                    },

                    new Game
                    {
                        Title = "Grand Theft Auto V",
                        ReleaseDate = DateTime.Parse("2013-9-17"),
                        Genre = "Open world",
                        Price = 8.99M
                    },

                    new Game
                    {
                        Title = "Destiny 2",
                        ReleaseDate = DateTime.Parse("2017-9-6"),
                        Genre = "Massively multiplayer online game",
                        Price = 9.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}