using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CodexEx1.Models;

namespace CodexEx1.Controllers
{
    public class WooSahPOCOModelController : Controller
    {
        private readonly WooSahContext _context;

        public WooSahPOCOModelController(WooSahContext context)
        {
            _context = context;
        }

        // GET: WooSahPOCOModels
        public async Task<IActionResult> IndexW()
        {
            return View(await _context.WooSahPOCOModel.ToListAsync());
        }

        // GET: WooSahPOCOModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wooSahPOCOModel = await _context.WooSahPOCOModel
                .SingleOrDefaultAsync(m => m.ID == id);
            if (wooSahPOCOModel == null)
            {
                return NotFound();
            }

            return View(wooSahPOCOModel);
        }

        // GET: WooSahPOCOModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WooSahPOCOModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Model,Material,Finish,Color,Etching")] WooSahPOCOModel wooSahPOCOModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wooSahPOCOModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexW));
            }
            return View(wooSahPOCOModel);
        }

        // GET: WooSahPOCOModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wooSahPOCOModel = await _context.WooSahPOCOModel.SingleOrDefaultAsync(m => m.ID == id);
            if (wooSahPOCOModel == null)
            {
                return NotFound();
            }
            return View(wooSahPOCOModel);
        }

        // POST: WooSahPOCOModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Model,Material,Finish,Color,Etching")] WooSahPOCOModel wooSahPOCOModel)
        {
            if (id != wooSahPOCOModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wooSahPOCOModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WooSahPOCOModelExists(wooSahPOCOModel.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexW));
            }
            return View(wooSahPOCOModel);
        }

        // GET: WooSahPOCOModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wooSahPOCOModel = await _context.WooSahPOCOModel
                .SingleOrDefaultAsync(m => m.ID == id);
            if (wooSahPOCOModel == null)
            {
                return NotFound();
            }

            return View(wooSahPOCOModel);
        }

        // POST: WooSahPOCOModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wooSahPOCOModel = await _context.WooSahPOCOModel.SingleOrDefaultAsync(m => m.ID == id);
            _context.WooSahPOCOModel.Remove(wooSahPOCOModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexW));
        }

        private bool WooSahPOCOModelExists(int id)
        {
            return _context.WooSahPOCOModel.Any(e => e.ID == id);
        }
    }
}
