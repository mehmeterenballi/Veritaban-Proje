using System;
using System.Collections.Generic;
using System.Linq;
using Oracle.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using VeritabaniProjesi.Models;

namespace VeritabaniProjesi.Data
{
    public class MyPostsContext : DbContext
    {
        public DbSet<MyPosts> Posts { get; set;}

        public MyPostsContext(DbContextOptions<MyPostsContext> options): base(options) {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle(ODBConnector.connectionString);
        }

    }
}
