using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MZ_PROGRESO1.Data;
using MZ_PROGRESO1.Models;

namespace MZ_PROGRESO1.Controllers
{
    public class ZUMARRAGAsController : Controller
    {
        private readonly MZ_PROGRESO1Context _context;

        public ZUMARRAGAsController(MZ_PROGRESO1Context context)
        {
            _context = context;
        }

        // GET: ZUMARRAGAs
        public async Task<IActionResult> Index()
        {
              return _context.ZUMARRAGA != null ? 
                          View(await _context.ZUMARRAGA.ToListAsync()) :
                          Problem("Entity set 'MZ_PROGRESO1Context.ZUMARRAGA'  is null.");
        }

        // GET: ZUMARRAGAs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ZUMARRAGA == null)
            {
                return NotFound();
            }

            var zUMARRAGA = await _context.ZUMARRAGA
                .FirstOrDefaultAsync(m => m.mzCodigo == id);
            if (zUMARRAGA == null)
            {
                return NotFound();
            }

            return View(zUMARRAGA);
        }

        // GET: ZUMARRAGAs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ZUMARRAGAs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("mzCodigo,mzCalificacionFinal,mzNombre,mzApellido,mzCorreo,mzCodigoPostal,mzEstudianteNuevo,mzFechaNacimiento,mzPromedioConducta")] ZUMARRAGA zUMARRAGA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zUMARRAGA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zUMARRAGA);
        }

        // GET: ZUMARRAGAs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ZUMARRAGA == null)
            {
                return NotFound();
            }

            var zUMARRAGA = await _context.ZUMARRAGA.FindAsync(id);
            if (zUMARRAGA == null)
            {
                return NotFound();
            }
            return View(zUMARRAGA);
        }

        // POST: ZUMARRAGAs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("mzCodigo,mzCalificacionFinal,mzNombre,mzApellido,mzCorreo,mzCodigoPostal,mzEstudianteNuevo,mzFechaNacimiento,mzPromedioConducta")] ZUMARRAGA zUMARRAGA)
        {
            if (id != zUMARRAGA.mzCodigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zUMARRAGA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZUMARRAGAExists(zUMARRAGA.mzCodigo))
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
            return View(zUMARRAGA);
        }

        // GET: ZUMARRAGAs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ZUMARRAGA == null)
            {
                return NotFound();
            }

            var zUMARRAGA = await _context.ZUMARRAGA
                .FirstOrDefaultAsync(m => m.mzCodigo == id);
            if (zUMARRAGA == null)
            {
                return NotFound();
            }

            return View(zUMARRAGA);
        }

        // POST: ZUMARRAGAs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ZUMARRAGA == null)
            {
                return Problem("Entity set 'MZ_PROGRESO1Context.ZUMARRAGA'  is null.");
            }
            var zUMARRAGA = await _context.ZUMARRAGA.FindAsync(id);
            if (zUMARRAGA != null)
            {
                _context.ZUMARRAGA.Remove(zUMARRAGA);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZUMARRAGAExists(int id)
        {
          return (_context.ZUMARRAGA?.Any(e => e.mzCodigo == id)).GetValueOrDefault();
        }
    }
}
