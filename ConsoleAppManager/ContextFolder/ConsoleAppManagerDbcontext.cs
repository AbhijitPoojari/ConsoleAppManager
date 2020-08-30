using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using ConsoleAppManager.Model;

namespace ConsoleAppManager.ContextFolder
{
    class ConsoleAppManagerDbcontext : DbContext
    {
        private static bool _created = false;
        public ConsoleAppManagerDbcontext()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.UseSqlite(@"Data Source=D:\AppManagerData.db");
        }

        public DbSet<DocumentsUsed> DocumentsUseds { get; set; }
        public DbSet<TimeLog> TimeLogs{ get; set; }

    }
}
