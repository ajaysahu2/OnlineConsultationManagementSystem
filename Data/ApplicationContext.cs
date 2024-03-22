using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineConsultationManagementSystem.Data.Configuration;
using OnlineConsultationManagementSystem.Models.Domain;
using OnlineConsultationManagementSystem.Models;

namespace OnlineConsultationManagementSystem.Data
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());

            modelBuilder.Entity<Session>().HasData(new Session
            {
                SessionId = 1,
                Session_Date_Time = new DateTime(1993, 12, 1),
                VideoLink = "https://chat.openai.com/c/5d129c40-0119-40e6-8a7a-6ad30f40fc9b"
            });

            modelBuilder.Entity<Doctor>().HasData(new Doctor
            {
                DoctorId = 1,
                Name = "Ram",
                ContactInfo = 9696655411,
                Specialization = "Physician"
            });

            modelBuilder.Entity<Patient>().HasData(new Patient
            {
                PatientId = 1,
                Name = "Ajay",
                Gender = "Male",
                ContactInfo = 6365633655,
                DateOfBirth = new DateOnly(1993, 12, 1),
                Address = "Hyderabad"

            }, new Patient
            {
                PatientId = 2,
                Name = "Anjay",
                Gender = "Male",
                ContactInfo = 6365633655,
                DateOfBirth = new DateOnly(1990, 12, 1),
                Address = "Kolkata"
            }); 
        }
        public DbSet<Patient> Patient { get; set; } = default!;
        public DbSet<Doctor> Doctors { get; set; } = default!;
        public DbSet<Session> Sessions { get; set; } = default!;
        public DbSet<Consultation> Consultations { get; set; } = default!;
        public DbSet<Appointment> Appointments { get; set; } = default!;
    }
}
