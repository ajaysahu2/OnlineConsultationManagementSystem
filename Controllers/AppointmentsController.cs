using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using OnlineConsultationManagementSystem.Data;
using OnlineConsultationManagementSystem.Models;

namespace OnlineConsultationManagementSystem.Controllers
{
    public class AppointmentsController : Controller
    {
        private readonly ApplicationContext _context;

        public AppointmentsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Appointments
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.Appointments.Include(a => a.Consultation).Include(a => a.Doctor).Include(a => a.Patient).Include(a => a.Session);
            return View(await applicationContext.ToListAsync());
        }

        // GET: Appointments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointments
                .Include(a => a.Consultation)
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .Include(a => a.Session)
                .FirstOrDefaultAsync(m => m.AppointmentId == id);
            if (appointment == null)
            {
                return NotFound();
            }

            return View(appointment);
        }

        // GET: Appointments/Create
        public IActionResult Create()
        {

            //ViewData["ConsultationId"] = new SelectList(_context.Consultations, "ConsultationId", "ConsultationId");
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "DoctorId", "Name");
            ViewData["PatientId"] = new SelectList(_context.Patient, "PatientId", "Name");
            ViewData["SessionId"] = new SelectList(_context.Sessions, "SessionId", "Session_Date_Time");

            return View();
        }

        // POST: Appointments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AppointmentId,PatientId,DoctorId,SessionId")] Appointment appointment)
        {
            if (appointment != null)
            {
                if (appointment?.PatientId != null && ModelState.ContainsKey("Patient"))
                {
                    appointment.Patient = _context.Patient.First(p => p.PatientId == appointment.PatientId);
                    ClearModelState("Patient");
                }

                if (appointment?.SessionId != null && ModelState.ContainsKey("Session"))
                {
                    appointment.Session = _context.Sessions.First(p => p.SessionId == appointment.SessionId);
                    ClearModelState("Session");
                }

                if (appointment?.DoctorId != null && ModelState.ContainsKey("Doctor"))
                {
                    appointment.Doctor = _context.Doctors.First(p => p.DoctorId == appointment.DoctorId);
                    ClearModelState("Doctor");
                }

                //create consultation
                var consultation = new Consultation();
                _context.Consultations.Add(consultation);
                _context.SaveChanges();

                appointment.ConsultationId = consultation.ConsultationId;
                appointment.Consultation = consultation;
                ClearModelState("Consultation");

            }

            if (ModelState.IsValid)
            {
                _context.Add(appointment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            //ViewData["ConsultationId"] = new SelectList(_context.Consultations, "ConsultationId", "ConsultationId", appointment.ConsultationId);
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "DoctorId", "Name", appointment.DoctorId);
            ViewData["PatientId"] = new SelectList(_context.Patient, "PatientId", "Name", appointment.PatientId);
            ViewData["SessionId"] = new SelectList(_context.Sessions, "SessionId", "Session_Date_Time", appointment.SessionId);
            return View(appointment);
        }

        private void ClearModelState(string propertyName)
        {
            ModelState[propertyName].Errors.Clear();
            ModelState[propertyName].ValidationState = ModelValidationState.Valid;
        }

        // GET: Appointments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment == null)
            {
                return NotFound();
            }
            ViewData["ConsultationId"] = new SelectList(_context.Consultations, "ConsultationId", "Notes", appointment.ConsultationId);
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "DoctorId", "Name", appointment.DoctorId);
            ViewData["PatientId"] = new SelectList(_context.Patient, "PatientId", "Name", appointment.PatientId);
            ViewData["SessionId"] = new SelectList(_context.Sessions, "SessionId", "Session_Date_Time", appointment.SessionId);
            return View(appointment);
        }

        // POST: Appointments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AppointmentId,PatientId,DoctorId,SessionId,ConsultationId")] Appointment appointment)
        {
            if (id != appointment.AppointmentId)
            {
                return NotFound();
            }

            if (appointment != null)
            {
                if (appointment?.PatientId != null && ModelState.ContainsKey("Patient"))
                {
                    appointment.Patient = _context.Patient.First(p => p.PatientId == appointment.PatientId);
                    ClearModelState("Patient");
                }

                if (appointment?.SessionId != null && ModelState.ContainsKey("Session"))
                {
                    appointment.Session = _context.Sessions.First(p => p.SessionId == appointment.SessionId);
                    ClearModelState("Session");
                }

                if (appointment?.DoctorId != null && ModelState.ContainsKey("Doctor"))
                {
                    appointment.Doctor = _context.Doctors.First(p => p.DoctorId == appointment.DoctorId);
                    ClearModelState("Doctor");
                }

                if (appointment?.ConsultationId != null && ModelState.ContainsKey("Consultation"))
                {
                    appointment.Consultation = _context.Consultations.First(p => p.ConsultationId == appointment.ConsultationId);
                    ClearModelState("Consultation");
                }

            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appointment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppointmentExists(appointment.AppointmentId))
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
            ViewData["ConsultationId"] = new SelectList(_context.Consultations, "ConsultationId", "Notes", appointment.ConsultationId);
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "DoctorId", "Name", appointment.DoctorId);
            ViewData["PatientId"] = new SelectList(_context.Patient, "PatientId", "Name", appointment.PatientId);
            ViewData["SessionId"] = new SelectList(_context.Sessions, "SessionId", "Session_Date_Time", appointment.SessionId);
            return View(appointment);
        }

        // GET: Appointments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointments
                .Include(a => a.Consultation)
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .Include(a => a.Session)
                .FirstOrDefaultAsync(m => m.AppointmentId == id);
            if (appointment == null)
            {
                return NotFound();
            }

            return View(appointment);
        }

        // POST: Appointments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment != null)
            {
                _context.Appointments.Remove(appointment);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppointmentExists(int id)
        {
            return _context.Appointments.Any(e => e.AppointmentId == id);
        }
    }
}
