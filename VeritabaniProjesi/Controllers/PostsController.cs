using System;
using System.Collections.Generic;
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
        public async Task<IActionResult> Index(string? title)
        {
            if (title == null)
                return NotFound();

            var pages = from p in _contents.Posts select p;

            if (!string.IsNullOrEmpty(title))
                pages = pages.Where(s => s.PostTitle == title);


            return View(await pages.ToListAsync());
        }

        // GET: Posts/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: Posts/Create
        public IActionResult Create(string title)
        {
            return View();
        }

        // POST: Posts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string title , [Bind("Id,PostTitle,Sender,Content,Rating,Date")] Post post)
        {
            if (ModelState.IsValid)
            {
                SetPostValuesToDefault(ref post);
                post.PostTitle = title;

                _contents.Add(post);
                await _contents.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new {title = title});
            }

            return View(post);
        }

        // GET: Posts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
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
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }

        // GET: Posts/Delete/5
        public async Task<IActionResult> Delete(int? id)
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
            return RedirectToAction(nameof(Index));
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
