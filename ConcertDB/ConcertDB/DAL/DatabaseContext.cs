using System;
using ConcertDB.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConcertDB.DAL
{
    public class DatabaseContext : DbContext
    {
        #region constructor
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        #endregion

        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>().HasIndex(c => c.Id).IsUnique();

        }
    }
}