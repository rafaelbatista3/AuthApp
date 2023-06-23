using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AuthApp.Controllers
{
    public class OrcamentosController : Controller
    {
        private readonly AppDbContext _context;

        public OrcamentosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Orcamentos
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Orçamentos.Include(o => o.Clientes);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Orcamentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Orçamentos == null)
            {
                return NotFound();
            }

            var orcamento = await _context.Orçamentos
                .Include(o => o.Clientes)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orcamento == null)
            {
                return NotFound();
            }

            return View(orcamento);
        }

        // GET: Orcamentos/Create
        public IActionResult Create()
        {
            ViewData["ClientesId"] = new SelectList(_context.Clientes, "Id", "Nome");
            return View();
        }

        // POST: Orcamentos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClientesId,ServicosId")] Orcamento orcamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orcamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientesId"] = new SelectList(_context.Clientes, "Id", "Nome", orcamento.ClientesId);
            return View(orcamento);
        }

        // GET: Orcamentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Orçamentos == null)
            {
                return NotFound();
            }

            var orcamento = await _context.Orçamentos.FindAsync(id);
            if (orcamento == null)
            {
                return NotFound();
            }
            ViewData["ClientesId"] = new SelectList(_context.Clientes, "Id", "Nome", orcamento.ClientesId);
            return View(orcamento);
        }

        // POST: Orcamentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClientesId,ServicosId")] Orcamento orcamento)
        {
            if (id != orcamento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orcamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrcamentoExists(orcamento.Id))
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
            ViewData["ClientesId"] = new SelectList(_context.Clientes, "Id", "Nome", orcamento.ClientesId);
            return View(orcamento);
        }

        // GET: Orcamentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Orçamentos == null)
            {
                return NotFound();
            }

            var orcamento = await _context.Orçamentos
                .Include(o => o.Clientes)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orcamento == null)
            {
                return NotFound();
            }

            return View(orcamento);
        }

        // POST: Orcamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Orçamentos == null)
            {
                return Problem("Entity set 'AppDbContext.Orçamentos'  is null.");
            }
            var orcamento = await _context.Orçamentos.FindAsync(id);
            if (orcamento != null)
            {
                _context.Orçamentos.Remove(orcamento);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrcamentoExists(int id)
        {
            return _context.Orçamentos.Any(e => e.Id == id);
        }
    }
}
