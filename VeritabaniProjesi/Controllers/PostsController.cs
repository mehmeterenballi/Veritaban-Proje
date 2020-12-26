using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using VeritabaniProjesi.Data;
using VeritabaniProjesi.Models;

namespace VeritabaniProjesi.Controllers
{
    public class PostsController : Controller
    {
        private readonly DataContext _contents;

        public PostsController(DataContext contents)
        {
            _contents = contents;
        }

        // GET: Posts
        public async Task<IActionResult> Index([FromQuery(Name = "title")]string? title)
        {
            if (title == null)
                return NotFound();

            TempData["Title"] = title;


            var pages = from p in _contents.Posts select p;

            if (!string.IsNullOrEmpty(title))
                pages = pages.Where(s => s.PostTitle == title);


            return View(await pages.ToListAsync());
        }

        // GET: Posts/Details/5
        public async Task<IActionResult> Details(string? title, int? id)
        {
            if (id == null || title == null)
                return NotFound();
            

            var post = await _contents.Posts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // GET: Posts/Create
        public IActionResult Create([FromQuery(Name = "title")]string? title)
        {
            if (title == null)
                return NotFound();

            return View();
        }

        // POST: Posts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PostTitle,Sender,Content,Rating,Date")] Post post)
        {
            if (post.PostTitle == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                SetPostValuesToDefault(ref post);

                _contents.Add(post);
                await _contents.SaveChangesAsync();


                return RedirectToAction(nameof(Index), new { title = post.PostTitle});
            }

            return View(post);
        }

        // GET: Posts/Edit/5
        public async Task<IActionResult> Edit(string? title, int? id)
        {
            if (id == null  || title == null)
            {
                return NotFound();
            }

            var post = await _contents.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Posts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PostTitle,Sender,Content,Rating,Date")] Post post)
        {
            if (id != post.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    SetPostValuesToDefault(ref post);

                    _contents.Update(post);
                    await _contents.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostExists(post.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new {title = TempData["Title"]});
            }
            return View(post);
        }

        // GET: Posts/Delete/5
        public async Task<IActionResult> Delete(string title, int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _contents.Posts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var post = await _contents.Posts.FindAsync(id);
            _contents.Posts.Remove(post);
            await _contents.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new {title = TempData["Title"]});
        }

        private bool PostExists(int id)
        {
            return _contents.Posts.Any(e => e.Id == id);
        }

        private void SetPostValuesToDefault(ref Post post)
        {
            //post.Sender = ;
            //post.PostTitle = ;

            post.Date = DateTime.Now;
            post.Rating = 0;
        }
    }
}
