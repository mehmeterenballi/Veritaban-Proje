using System;
using System.Collections.Generic;
using System.Linq;
using Oracle.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using VeritabaniProjesi.Models;

namespace VeritabaniProjesi.Data
{
    public class FormAndUserContext : DbContext
    {
        public DbSet<MyPosts> Posts { get; set;}

        public FormAndUserContext(DbContextOptions<FormAndUserContext> options): base(options) {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle(@"User Id=SYSTEM; Password=1234qwer;" +
                                     @"Data Source = localhost:1521/XEPDB1;");
        }

    }
}
