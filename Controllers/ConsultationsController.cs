using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineConsultationManagementSystem.Data;
using OnlineConsultationManagementSystem.Models;

namespace OnlineConsultationManagementSystem.Controllers
{
    public class ConsultationsController : Controller
    {
        private readonly ApplicationContext _context;

        public ConsultationsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Consultations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Consultations.ToListAsync());
        }

        // GET: Consultations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultations = await _context.Consultations
                .FirstOrDefaultAsync(m => m.ConsultationId == id);
            if (consultations == null)
            {
                return NotFound();
            }

            return View(consultations);
        }

        // GET: Consultations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Consultations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ConsultationId,Prescription,Notes")] Consultations consultations)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consultations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(consultations);
        }

        // GET: Consultations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultations = await _context.Consultations.FindAsync(id);
            if (consultations == null)
            {
                return NotFound();
            }
            return View(consultations);
        }

        // POST: Consultations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ConsultationId,Prescription,Notes")] Consultations consultations)
        {
            if (id != consultations.ConsultationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consultations);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsultationsExists(consultations.ConsultationId))
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
            return View(consultations);
        }

        // GET: Consultations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultations = await _context.Consultations
                .FirstOrDefaultAsync(m => m.ConsultationId == id);
            if (consultations == null)
            {
                return NotFound();
            }

            return View(consultations);
        }

        // POST: Consultations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var consultations = await _context.Consultations.FindAsync(id);
            if (consultations != null)
            {
                _context.Consultations.Remove(consultations);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsultationsExists(int id)
        {
            return _context.Consultations.Any(e => e.ConsultationId == id);
        }
    }
}
