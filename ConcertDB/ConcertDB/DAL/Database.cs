using System;
using ConcertDB.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConcertDB.DAL
{
    public class Database : DbContext
    {
        #region constructor
        public Database(DbContextOptions<Database> options) : base(options)
        {

        }
        #endregion

        public DbSet<Ticket> Tickets { get; set; }
    }
}