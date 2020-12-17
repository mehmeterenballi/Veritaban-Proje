using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VeritabaniProjesi.Data;
using VeritabaniProjesi.Models;

namespace VeritabaniProjesi.Pages.Posts
{
    public class IndexModel : PageModel
    {
        private readonly VeritabaniProjesi.Data.PostsDataContext _context;

        public IndexModel(VeritabaniProjesi.Data.PostsDataContext context)
        {
            _context = context;
        }

        public IList<Post> Posts { get; set; }
        [BindProperty(SupportsGet = true)] public string SearchString { get; set; }
        public SelectList Titles { get; set;}
        [BindProperty(SupportsGet =  true)] public string MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            var posts = from p in _context.Posts select p;

            if (!string.IsNullOrEmpty(SearchString))
            {
                posts = posts.Where(s => s.PostTitle.Contains(SearchString));
            }

            Posts = await posts.ToListAsync();
        }
    }
}
