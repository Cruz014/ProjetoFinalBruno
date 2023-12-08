﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoFinalBruno.Models;

namespace ProjetoFinalBruno.Controllers
{
    public class ProcedimentoController : Controller
    {
        private readonly Contexto _context;

        public ProcedimentoController(Contexto context)
        {
            _context = context;
        }

        // GET: Procedimento
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Procedimento.Include(p => p.Estado);
            return View(await contexto.ToListAsync());
        }

        // GET: Procedimento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Procedimento == null)
            {
                return NotFound();
            }

            var procedimento = await _context.Procedimento
                .Include(p => p.Estado)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (procedimento == null)
            {
                return NotFound();
            }

            return View(procedimento);
        }

        // GET: Procedimento/Create
        public IActionResult Create()
        {
            ViewData["EstadoId"] = new SelectList(_context.Estado, "Id", "Id");
            return View();
        }

        // POST: Procedimento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProcedimentoNome,ProcedimentoObservacao,EstadoId")] Procedimento procedimento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(procedimento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EstadoId"] = new SelectList(_context.Estado, "Id", "Id", procedimento.EstadoId);
            return View(procedimento);
        }

        // GET: Procedimento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Procedimento == null)
            {
                return NotFound();
            }

            var procedimento = await _context.Procedimento.FindAsync(id);
            if (procedimento == null)
            {
                return NotFound();
            }
            ViewData["EstadoId"] = new SelectList(_context.Estado, "Id", "Id", procedimento.EstadoId);
            return View(procedimento);
        }

        // POST: Procedimento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProcedimentoNome,ProcedimentoObservacao,EstadoId")] Procedimento procedimento)
        {
            if (id != procedimento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(procedimento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProcedimentoExists(procedimento.Id))
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
            ViewData["EstadoId"] = new SelectList(_context.Estado, "Id", "Id", procedimento.EstadoId);
            return View(procedimento);
        }

        // GET: Procedimento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Procedimento == null)
            {
                return NotFound();
            }

            var procedimento = await _context.Procedimento
                .Include(p => p.Estado)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (procedimento == null)
            {
                return NotFound();
            }

            return View(procedimento);
        }

        // POST: Procedimento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Procedimento == null)
            {
                return Problem("Entity set 'Contexto.Procedimento'  is null.");
            }
            var procedimento = await _context.Procedimento.FindAsync(id);
            if (procedimento != null)
            {
                _context.Procedimento.Remove(procedimento);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProcedimentoExists(int id)
        {
          return (_context.Procedimento?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
