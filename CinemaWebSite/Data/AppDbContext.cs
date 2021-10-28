using CinemaWebSite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebSite.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(x => new {
                x.ActorID,
                x.MovieID
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(x => x.Actor_Movies).HasForeignKey(x => x.MovieID);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(x => x.Actor_Movies).HasForeignKey(x => x.ActorID);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors {get; set;}
        public DbSet<Movie> Movies {get; set;}
        public DbSet<Actor_Movie> Actor_Movies {get; set;}
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }

    }
}
