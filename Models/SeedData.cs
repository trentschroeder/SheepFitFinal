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
                         DOB = DateTime.Parse("2017-1-20"),
                         Gender = "M",
                         Booster = DateTime.Parse("2017-12-11"),
                         Wormer = DateTime.Parse("2017-6-11"),
                         Tetanus = DateTime.Parse("2017-12-11"),
                         Pneumonia = DateTime.Parse("2017-12-11"),
                         Rabies = DateTime.Parse("2017-12-11"),
                         Comment = "not wormed"


                     },

                    new Animal
                    {
                        sheepID = "2",
                        DOB = DateTime.Parse("2017-1-01"),
                        Gender = "F",
                        Booster = DateTime.Parse("2017-12-11"),
                        Wormer = DateTime.Parse("2017-12-11"),
                        Tetanus = DateTime.Parse("2017-12-11"),
                        Pneumonia = DateTime.Parse("2017-12-11"),
                        Rabies = DateTime.Parse("2017-12-11"),
                        Comment = "underweight"
                    },

                    new Animal
                    {
                        sheepID = "3",
                        DOB = DateTime.Parse("2015-10-19"),
                        Gender = "M",
                        Booster = DateTime.Parse("2017-12-11"),
                        Wormer = DateTime.Parse("2017-12-11"),
                        Tetanus = DateTime.Parse("2017-12-11"),
                        Pneumonia = DateTime.Parse("2017-12-11"),
                        Rabies = DateTime.Parse("2016-12-02"),
                        Comment = "good"
                    },
                    new Animal
                    {
                        sheepID = "4",
                        DOB = DateTime.Parse("2017-1-21"),
                        Gender = "F",
                        Booster = DateTime.Parse("2017-12-11"),
                        Wormer = DateTime.Parse("2017-12-11"),
                        Tetanus = DateTime.Parse("2017-12-11"),
                        Pneumonia = DateTime.Parse("2017-12-11"),
                        Rabies = DateTime.Parse("2017-12-11"),
                        Comment = "  "
                    },
                    new Animal
                    {
                        sheepID = "5",
                        DOB = DateTime.Parse("2017-4-02"),
                        Gender = "F",
                        Booster = DateTime.Parse("2017-12-11"),
                        Wormer = DateTime.Parse("2017-12-11"),
                        Tetanus = DateTime.Parse("2017-12-11"),
                        Pneumonia = DateTime.Parse("2017-12-11"),
                        Rabies = DateTime.Parse("2017-12-11"),
                        Comment = "cough"
                    },
                    new Animal
                    {
                        sheepID = "6",
                        DOB = DateTime.Parse("2016-2-21"),
                        Gender = "M",
                        Booster = DateTime.Parse("2017-12-11"),
                        Wormer = DateTime.Parse("2017-12-11"),
                        Tetanus = DateTime.Parse("2017-12-11"),
                        Pneumonia = DateTime.Parse("2017-12-11"),
                        Rabies = DateTime.Parse("2017-12-11"),
                        Comment = "  "
                    },
                    new Animal
                    {
                        sheepID = "7",
                        DOB = DateTime.Parse("2016-1-21"),
                        Gender = "F",
                        Booster = DateTime.Parse("2017-12-11"),
                        Wormer = DateTime.Parse("2017-12-11"),
                        Tetanus = DateTime.Parse("2017-12-11"),
                        Pneumonia = DateTime.Parse("2017-12-11"),
                        Rabies = DateTime.Parse("2017-12-11"),
                        Comment = "treat leg wound"
                    },
                    new Animal
                    {
                        sheepID = "8",
                        DOB = DateTime.Parse("2017-1-15"),
                        Gender = "F",
                        Booster = DateTime.Parse("2017-12-11"),
                        Wormer = DateTime.Parse("2017-12-11"),
                        Tetanus = DateTime.Parse("2017-12-11"),
                        Pneumonia = DateTime.Parse("2017-12-11"),
                        Rabies = DateTime.Parse("2017-12-11"),
                        Comment = "  "
                    },
                    new Animal
                    {
                        sheepID = "9",
                        DOB = DateTime.Parse("2015-1-27"),
                        Gender = "F",
                        Booster = DateTime.Parse("2017-12-11"),
                        Wormer = DateTime.Parse("2017-6-11"),
                        Tetanus = DateTime.Parse("2017-12-11"),
                        Pneumonia = DateTime.Parse("2017-12-11"),
                        Rabies = DateTime.Parse("2017-12-11"),
                        Comment = "overweight, no wormer "
                    },
                    new Animal
                    {
                        sheepID = "10",
                        DOB = DateTime.Parse("2017-1-21"),
                        Gender = "M",
                        Booster = DateTime.Parse("2017-12-11"),
                        Wormer = DateTime.Parse("2017-12-11"),
                        Tetanus = DateTime.Parse("2017-12-11"),
                        Pneumonia = DateTime.Parse("2017-12-11"),
                        Rabies = DateTime.Parse("2017-12-11"),
                        Comment = "great"
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
