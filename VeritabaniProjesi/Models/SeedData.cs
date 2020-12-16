using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VeritabaniProjesi.Data;

namespace VeritabaniProjesi.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PostsDataContext(
                serviceProvider.GetRequiredService<DbContextOptions<PostsDataContext>>()))
            {
                if (!context.Posts.Any())
                    context.Posts.Add(
                        new Post{PostTitle = "Test", Sender = "Admin", Content = "Welcome To Dev Q&A", Rating = 5, Date = DateTime.Now}
                        );

                context.SaveChanges();
            }


        }
    }
}
