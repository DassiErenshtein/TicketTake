using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using Core.Entities;
namespace Repository
{
    public partial class TickeTakeContext : DbContext
    {
        public TickeTakeContext()
        {
        }

        public TickeTakeContext(DbContextOptions<TickeTakeContext> options)
            : base(options)
        {
        }

        public virtual DbSet< Event> Events { get; set; }

        public virtual DbSet< EventOwner> EventOwners { get; set; }
        public virtual DbSet< EventShow> EventShows { get; set; }
        public virtual DbSet< Hall> Halls { get; set; }
        public virtual DbSet< PlaceInHall> PlaceInHalls { get; set; }
        public virtual DbSet< Ticket> Tickets { get; set; }
        public virtual DbSet<TicketLevel> TicketLevels { get; set; }
        public virtual DbSet<TypePlace> TypePlaces { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    => optionsBuilder.UseSqlServer("Server=.;Database=ticketake;Trusted_Connection=True;TrustServerCertificate=True");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.EventShow)
                .WithMany(es => es.Tickets)
                .HasForeignKey(t => t.EventShowId)
                .OnDelete(DeleteBehavior.Restrict); // או .NoAction

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.PlaceInHall)
                .WithMany(p => p.Tickets)
                .HasForeignKey(t => t.PlaceInHallId)
                .OnDelete(DeleteBehavior.Restrict); // או .NoAction
        }

    }
}

