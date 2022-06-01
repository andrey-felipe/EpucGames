using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EpucGames.Data;
using EpucGames.Models;

namespace EpucGames.Controllers
{
    public class CompraFornecedoresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CompraFornecedoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CompraFornecedores
        public async Task<IActionResult> Index()
        {
            return View(await _context.CompraFornecedor.ToListAsync());
        }

        // GET: CompraFornecedores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compraFornecedor = await _context.CompraFornecedor
                .FirstOrDefaultAsync(m => m.IDCompraFornecedor == id);
            if (compraFornecedor == null)
            {
                return NotFound();
            }

            return View(compraFornecedor);
        }

        // GET: CompraFornecedores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompraFornecedores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDCompraFornecedor,QuantidadeCompraFornecedor,ValorCompraFornecedor")] CompraFornecedor compraFornecedor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(compraFornecedor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(compraFornecedor);
        }

        // GET: CompraFornecedores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compraFornecedor = await _context.CompraFornecedor.FindAsync(id);
            if (compraFornecedor == null)
            {
                return NotFound();
            }
            return View(compraFornecedor);
        }

        // POST: CompraFornecedores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDCompraFornecedor,QuantidadeCompraFornecedor,ValorCompraFornecedor")] CompraFornecedor compraFornecedor)
        {
            if (id != compraFornecedor.IDCompraFornecedor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(compraFornecedor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompraFornecedorExists(compraFornecedor.IDCompraFornecedor))
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
            return View(compraFornecedor);
        }

        // GET: CompraFornecedores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compraFornecedor = await _context.CompraFornecedor
                .FirstOrDefaultAsync(m => m.IDCompraFornecedor == id);
            if (compraFornecedor == null)
            {
                return NotFound();
            }

            return View(compraFornecedor);
        }

        // POST: CompraFornecedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var compraFornecedor = await _context.CompraFornecedor.FindAsync(id);
            _context.CompraFornecedor.Remove(compraFornecedor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompraFornecedorExists(int id)
        {
            return _context.CompraFornecedor.Any(e => e.IDCompraFornecedor == id);
        }
    }
}
