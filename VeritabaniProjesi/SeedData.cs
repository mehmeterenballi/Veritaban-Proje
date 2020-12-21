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
            using (var context = new DataContext(
                serviceProvider.GetRequiredService<DbContextOptions<DataContext>>()))
            {
                Post firstMessage = new Post
                {
                    PostTitle = "Test", Sender = "Admin", Content = "Welcome To Dev Q&A", Rating = 5,
                    Date = DateTime.Now
                };

                if (!context.Posts.Any())
                    context.Posts.Add(firstMessage);

                if (!context.Titles.Any())
                    context.Titles.Add(
                        new Title{PostTitle = firstMessage.PostTitle, Date = firstMessage.Date, Question = firstMessage, QuestionId = firstMessage.Id}
                        );
                

                context.SaveChanges();
            }


        }
    }
}
