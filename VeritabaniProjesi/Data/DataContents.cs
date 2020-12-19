using System;
using System.Collections.Generic;
using System.Linq;
using Oracle.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using VeritabaniProjesi.Models;

namespace VeritabaniProjesi.Data
{
    public class DataContents : DbContext
    {
        public DbSet<Post> Posts { get; set;}
        public DbSet<Title> Titles { get; set;}

        public DataContents(DbContextOptions<DataContents> options): base(options) {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle(ODBConnector.connectionString);
        }

    }
}
