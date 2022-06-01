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
    public class VendaClientesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VendaClientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: VendaClientes
        public async Task<IActionResult> Index()
        {
            return View(await _context.VendaCliente.ToListAsync());
        }

        // GET: VendaClientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendaCliente = await _context.VendaCliente
                .FirstOrDefaultAsync(m => m.IdVenda == id);
            if (vendaCliente == null)
            {
                return NotFound();
            }

            return View(vendaCliente);
        }

        // GET: VendaClientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VendaClientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVenda,DataVenda,ValorVenda")] VendaCliente vendaCliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendaCliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vendaCliente);
        }

        // GET: VendaClientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendaCliente = await _context.VendaCliente.FindAsync(id);
            if (vendaCliente == null)
            {
                return NotFound();
            }
            return View(vendaCliente);
        }

        // POST: VendaClientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdVenda,DataVenda,ValorVenda")] VendaCliente vendaCliente)
        {
            if (id != vendaCliente.IdVenda)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendaCliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendaClienteExists(vendaCliente.IdVenda))
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
            return View(vendaCliente);
        }

        // GET: VendaClientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendaCliente = await _context.VendaCliente
                .FirstOrDefaultAsync(m => m.IdVenda == id);
            if (vendaCliente == null)
            {
                return NotFound();
            }

            return View(vendaCliente);
        }

        // POST: VendaClientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vendaCliente = await _context.VendaCliente.FindAsync(id);
            _context.VendaCliente.Remove(vendaCliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendaClienteExists(int id)
        {
            return _context.VendaCliente.Any(e => e.IdVenda == id);
        }
    }
}
