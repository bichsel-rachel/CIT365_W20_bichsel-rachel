using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using My_Scripture_Journal.Data;
using System;
using System.Linq;

namespace My_Scripture_Journal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new My_Scripture_JournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<My_Scripture_JournalContext>>()))
            {
                // Look for any scriptures.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "Jacob",
                        Chapter = 6,
                        Verse = 12,
                        Note = "What every parent wants their child to remember.",
                        DateAdded = DateTime.Parse("2-18-2020")
                    },

                    new Scripture
                    {
                        Book = "1 Nephi",
                        Chapter = 17,
                        Verse = 13,
                        Note = "Favorite Scripture",
                        DateAdded = DateTime.Parse("1-05-2020")
                    },

                    new Scripture
                    {
                        Book = "1 Nephi",
                        Chapter = 3,
                        Verse = 7,
                        Note = "Go and do! Don't be lazy!",
                        DateAdded = DateTime.Parse("12-12-2019")
                    },

                    new Scripture
                    {
                        Book = "Matthew",
                        Chapter = 17,
                        Verse = 7,
                        Note = "Don't be afraid. Stand up and have courage.",
                        DateAdded = DateTime.Parse("4-20-20")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}