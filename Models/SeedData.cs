using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace SheepFit6.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SheepContext(
                serviceProvider.GetRequiredService<DbContextOptions<SheepContext>>()))
            {
                // Look for any movies.
                if (context.Animal.Any())
                {
                    return;   // DB has been seeded
                }

                context.Animal.AddRange(
                     new Animal
                     {
                         sheepID = "1",
                         DOB = DateTime.Parse("2010-1-11"),
                         Gender = "M"
                     },

                    new Animal
                     {
                         sheepID = "2",
                         DOB = DateTime.Parse("2011-5-01"),
                         Gender = "F"
                     },
                    
                    new Animal
                     {
                         sheepID = "3",
                         DOB = DateTime.Parse("2015-10-19"),
                         Gender = "M"
                     },
                    new Animal
                    {
                        sheepID = "4",
                        DOB = DateTime.Parse("2017-1-21"),
                        Gender = "F"
                    }
                   
                );
                context.SaveChanges();
            }
        }
    }
}
