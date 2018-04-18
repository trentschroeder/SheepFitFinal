using System;
using Microsoft.EntityFrameworkCore;

namespace SheepFit6.Models
{
    public class SheepContext : DbContext
    {
        public SheepContext(DbContextOptions<SheepContext> options)
            : base(options)
        {
        }

        public DbSet<SheepFit6.Models.Animal> Animal { get; set; }
    }
}