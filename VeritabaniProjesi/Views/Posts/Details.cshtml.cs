using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VeritabaniProjesi.Data;
using VeritabaniProjesi.Models;

namespace VeritabaniProjesi.Views.Posts
{
    public class DetailsModel : PageModel
    {
        private readonly VeritabaniProjesi.Data.PostsDataContext _context;

        public DetailsModel(VeritabaniProjesi.Data.PostsDataContext context)
        {
            _context = context;
        }

        public Post Post { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Post = await _context.Posts.FirstOrDefaultAsync(m => m.Id == id);

            if (Post == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
