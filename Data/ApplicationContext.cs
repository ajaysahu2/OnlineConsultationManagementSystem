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
        public ApplicationContext(DbContextOptions options): base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.Entity<Patient>().HasData(new Patient
            {
                Id = 1,
                Name = "Ajay",
                Gender = "Male",
                MobileNumber = 6365633655,
                Address = "Hyderabad"

            }, new Patient
            {
                Id = 2,
                Name = "Anjay",
                Gender = "Male",
                MobileNumber = 6365633655,
                Address = "Kolkata"
            });
        }
        public DbSet<OnlineConsultationManagementSystem.Models.Patient> Patient { get; set; } = default!;
    }
}
