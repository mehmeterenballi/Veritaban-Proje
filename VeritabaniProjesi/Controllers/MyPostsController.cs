using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VeritabaniProjesi.Data;
using VeritabaniProjesi.Models;

namespace VeritabaniProjesi.Controllers
{
    public class MyPostsController : Controller
    {
        private readonly MyPostsContext _context;

        public MyPostsController(MyPostsContext context)
        {
            _context = context;
        }


        // GET: MyPosts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Posts.ToListAsync());
        }

        // GET: MyPosts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myPosts = await _context.Posts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (myPosts == null)
            {
                return NotFound();
            }

            return View(myPosts);
        }

        // GET: MyPosts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MyPosts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,Content,Rating")] MyPosts myPosts)
        {
            if (ModelState.IsValid)
            {
                _context.Add(myPosts);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(myPosts);
        }

        // GET: MyPosts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myPosts = await _context.Posts.FindAsync(id);
            if (myPosts == null)
            {
                return NotFound();
            }
            return View(myPosts);
        }

        // POST: MyPosts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserName,Content,Rating")] MyPosts myPosts)
        {
            if (id != myPosts.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(myPosts);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MyPostsExists(myPosts.Id))
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
            return View(myPosts);
        }

        // GET: MyPosts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myPosts = await _context.Posts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (myPosts == null)
            {
                return NotFound();
            }

            return View(myPosts);
        }

        // POST: MyPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var myPosts = await _context.Posts.FindAsync(id);
            _context.Posts.Remove(myPosts);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MyPostsExists(int id)
        {
            return _context.Posts.Any(e => e.Id == id);
        }
    }
}
