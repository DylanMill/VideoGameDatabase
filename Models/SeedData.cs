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
                // if (!context.Game.Any())
                // {
                //     return;   // DB has been seeded
                // }

                // Remove existing entries
                context.Game.RemoveRange(context.Game);
                context.SaveChanges(); // Save the changes before adding new entries

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
                        },

                        // Additional games
                        new Game
                        {
                            Title = "The Witcher 3: Wild Hunt",
                            ReleaseDate = DateTime.Parse("2015-5-19"),
                            Genre = "Action role-playing game",
                            Price = 29.99M
                        },

                        new Game
                        {
                            Title = "Dark Souls III",
                            ReleaseDate = DateTime.Parse("2016-3-24"),
                            Genre = "Action role-playing game",
                            Price = 39.99M
                        },

                        new Game
                        {
                            Title = "Super Mario Odyssey",
                            ReleaseDate = DateTime.Parse("2017-10-27"),
                            Genre = "Platform",
                            Price = 59.99M
                        },

                        new Game
                        {
                            Title = "Overwatch",
                            ReleaseDate = DateTime.Parse("2016-5-24"),
                            Genre = "First-person shooter",
                            Price = 19.99M
                        },

                        new Game
                        {
                            Title = "Hades",
                            ReleaseDate = DateTime.Parse("2020-9-17"),
                            Genre = "Roguelike dungeon crawler",
                            Price = 24.99M
                        },

                        new Game
                        {
                            Title = "The Last of Us Part II",
                            ReleaseDate = DateTime.Parse("2020-6-19"),
                            Genre = "Action-adventure",
                            Price = 59.99M
                        },

                        new Game
                        {
                            Title = "God of War",
                            ReleaseDate = DateTime.Parse("2018-4-20"),
                            Genre = "Action-adventure",
                            Price = 49.99M
                        },

                        new Game
                        {
                            Title = "Minecraft",
                            ReleaseDate = DateTime.Parse("2011-11-18"),
                            Genre = "Sandbox, survival",
                            Price = 26.95M
                        },

                        new Game
                        {
                            Title = "Final Fantasy VII Remake",
                            ReleaseDate = DateTime.Parse("2020-4-10"),
                            Genre = "Role-playing game",
                            Price = 59.99M
                        },

                        new Game
                        {
                            Title = "Cyberpunk 2077",
                            ReleaseDate = DateTime.Parse("2020-12-10"),
                            Genre = "Action role-playing",
                            Price = 59.99M
                        },

                        new Game
                        {
                            Title = "Apex Legends",
                            ReleaseDate = DateTime.Parse("2019-2-4"),
                            Genre = "Battle royale",
                            Price = 0.00M // Free-to-play
                        },

                        new Game
                        {
                            Title = "League of Legends",
                            ReleaseDate = DateTime.Parse("2009-10-27"),
                            Genre = "Multiplayer online battle arena",
                            Price = 0.00M // Free-to-play
                        },

                        new Game
                        {
                            Title = "Stardew Valley",
                            ReleaseDate = DateTime.Parse("2016-2-26"),
                            Genre = "Simulation role-playing",
                            Price = 14.99M
                        },

                        new Game
                        {
                            Title = "Doom Eternal",
                            ReleaseDate = DateTime.Parse("2020-3-20"),
                            Genre = "First-person shooter",
                            Price = 59.99M
                        },

                        new Game
                        {
                            Title = "Persona 5 Royal",
                            ReleaseDate = DateTime.Parse("2020-3-31"),
                            Genre = "Role-playing",
                            Price = 59.99M
                        }
                    );
                context.SaveChanges();
            }
        }
    }
}