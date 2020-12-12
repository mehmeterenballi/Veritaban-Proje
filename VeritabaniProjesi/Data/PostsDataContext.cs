using System;
using System.Collections.Generic;
using System.Linq;
using Oracle.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using VeritabaniProjesi.Models;

namespace VeritabaniProjesi.Data
{
    public class PostsDataContext : DbContext
    {
        public DbSet<Post> Posts { get; set;}

        public PostsDataContext(DbContextOptions<PostsDataContext> options): base(options) {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle(ODBConnector.connectionString);
        }

    }
}
