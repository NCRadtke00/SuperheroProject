using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Superhero.Models;
using Microsoft.EntityFrameworkCore.Metadata;
namespace Superhero.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Superheros> Superheroes { get; set; }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //    builder.Entity<Superheros>().
        //        .HasData(
        //        {
        //    });
        //}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Superheros>()
                .HasData(
                    new Superheros()
                    {
                        Id = 1,
                        Name = "Superman",
                        Alterego = "Clark Kent, Karl-El",
                        PrimaryAbility = "Indomitable Will",
                        SecondaryAbility = "Kryptonian Physiology, flight, strength, speed, heat vision, frost breath, healing",
                        Catchphrase = "Up, Up, and Away!"
                    },
                    new Superheros()
                    {
                        Id = 2,
                        Name = "Batman",
                        Alterego = "Bruce Wayne",
                        PrimaryAbility = "Billionaire Genius",
                        SecondaryAbility = "Mastery of body and mind",
                        Catchphrase = "Pow"
                    },
                    new Superheros()
                    {
                        Id = 3,
                        Name = "Aquaman",
                        Alterego = "Arthur Curry, King Orin",
                        PrimaryAbility = "Atlantean Adaptation, Strength, Super-water speed, underwater breathing",
                        SecondaryAbility = "​Enhanced Durability",
                        Catchphrase = "By the beard of Poseidon!"
                    });
        
        }
    }
}