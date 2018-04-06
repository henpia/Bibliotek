using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Bibliotek.Models
{
    public class BibliotekContext : DbContext
    {
        public DbSet<Bog> Boeger { get; set; }
        public DbSet<Genre> Genrer { get; set; }
        public DbSet<Forfatter> Forfattere { get; set; }

        public BibliotekContext() : base("DefaultConnection")
        {
        }
    }
}