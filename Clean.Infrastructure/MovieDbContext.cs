using Clean.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Infrastructure
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //One(Rental) to many(Member) 
            modelBuilder.Entity<Member>()
                .HasOne<Rental>(r => r.Rental)
                .WithMany(m => m.Members)
                .HasForeignKey(s => s.RentalId);
            
            //Many to many 
            modelBuilder.Entity<MovieRental>()
                .HasKey(g => new { g.MovieId, g.RentalId });

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<MovieRental> MovieRentals { get; set; }
    }
}
