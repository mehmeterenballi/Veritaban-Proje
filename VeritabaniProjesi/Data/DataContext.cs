using System;
using System.Collections.Generic;
using System.Linq;
using Oracle.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using VeritabaniProjesi.Models;

namespace VeritabaniProjesi.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Post> Posts { get; set;}
        public DbSet<Title> Titles { get; set;}
        public DbSet<Announcement> Announcements { get; set; }

        public DataContext(DbContextOptions<DataContext> options): base(options) {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle(ODBConnector.connectionString);
        }

    }
}
