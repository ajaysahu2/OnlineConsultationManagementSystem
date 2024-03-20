﻿    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;
    using OnlineConsultationManagementSystem.Data;
    using OnlineConsultationManagementSystem.Models;

    namespace OnlineConsultationManagementSystem.Controllers
    {
        public class DoctorsController : Controller
        {
            private readonly ApplicationContext _context;

            public DoctorsController(ApplicationContext context)
            {
                _context = context;
            }

            // GET: Doctors
            public async Task<IActionResult> Index()
            {
                return View(await _context.Doctors.ToListAsync());
            }

            // GET: Doctors/Details/5
            public async Task<IActionResult> Details(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var doctor = await _context.Doctors
                    .FirstOrDefaultAsync(m => m.DoctorId == id);
                if (doctor == null)
                {
                    return NotFound();
                }

                return View(doctor);
            }

            // GET: Doctors/Create
            public IActionResult Create()
            {
                return View();
            }

            // POST: Doctors/Create
            // To protect from overposting attacks, enable the specific properties you want to bind to.
            // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create([Bind("DoctorId,Name,Specialization,ContactInfo")] Doctor doctor)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(doctor);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(doctor);
            }

            // GET: Doctors/Edit/5
            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var doctor = await _context.Doctors.FindAsync(id);
                if (doctor == null)
                {
                    return NotFound();
                }
                return View(doctor);
            }

            // POST: Doctors/Edit/5
            // To protect from overposting attacks, enable the specific properties you want to bind to.
            // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, [Bind("DoctorId,Name,Specialization,ContactInfo")] Doctor doctor)
            {
                if (id != doctor.DoctorId)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(doctor);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!DoctorExists(doctor.DoctorId))
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
                return View(doctor);
            }

            // GET: Doctors/Delete/5
            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var doctor = await _context.Doctors
                    .FirstOrDefaultAsync(m => m.DoctorId == id);
                if (doctor == null)
                {
                    return NotFound();
                }

                return View(doctor);
            }

            // POST: Doctors/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                var doctor = await _context.Doctors.FindAsync(id);
                if (doctor != null)
                {
                    _context.Doctors.Remove(doctor);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

        // GET: Doctors/Search
        [Authorize]
        public IActionResult Search()
        {
            return View();
        }

        // POST: Doctors/Search
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Search(string searchString)
        {
            // Retrieve doctors based on search criteria
            var doctors = from d in _context.Doctors
                          select d;

            if (!String.IsNullOrEmpty(searchString))
            {
                // Filter doctors based on search string
                doctors = doctors.Where(d => d.Name.Contains(searchString) ||
                                             d.Specialization.Contains(searchString) ||
                                             d.ContactInfo.ToString().Contains(searchString));
            }

            // Return the view with filtered doctors
            return View("Search", await doctors.ToListAsync());
        }



        private bool DoctorExists(int id)
            {
                return _context.Doctors.Any(e => e.DoctorId == id);
            }
        }
    }
