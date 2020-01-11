using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomNotes
{
    public class ApplicationDbContext : DbContext
    {
        private string savePath;

        public ApplicationDbContext()
        {
            savePath = "Z:/devdb.db3";
            Database.EnsureCreated();
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<CashDiff> DailyCash { get; set; }
        public DbSet<CustomTable> CustomTable { get; set; }
        public DbSet<CustomTag> CustomTag { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={savePath}");
        }
    }
}
