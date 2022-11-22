using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CooperativaTres.Context;
using CooperativaTres.Models;

namespace CooperativaTres.Controllers
{
    public class AsientoController : Controller
    {
        private readonly CineDatabaseContext _context;

        public AsientoController(CineDatabaseContext context)
        {
            _context = context;
        }

        // GET: Asientoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Asientos.ToListAsync());
        }

        // GET: Asientoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asiento = await _context.Asientos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (asiento == null)
            {
                return NotFound();
            }

            return View(asiento);
        }

        // GET: Asientoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Asientoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fila,NumeroDeAsiento")] Asiento asiento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(asiento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(asiento);
        }

        // GET: Asientoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asiento = await _context.Asientos.FindAsync(id);
            if (asiento == null)
            {
                return NotFound();
            }
            return View(asiento);
        }

        // POST: Asientoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fila,NumeroDeAsiento")] Asiento asiento)
        {
            if (id != asiento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(asiento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AsientoExists(asiento.Id))
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
            return View(asiento);
        }

        // GET: Asientoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asiento = await _context.Asientos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (asiento == null)
            {
                return NotFound();
            }

            return View(asiento);
        }

        // POST: Asientoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var asiento = await _context.Asientos.FindAsync(id);
            _context.Asientos.Remove(asiento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AsientoExists(int id)
        {
            return _context.Asientos.Any(e => e.Id == id);
        }
    }
}
