using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisionX.Models;

namespace VisionX.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }


        public DbSet<Patient>? Patients { get; set; }

        public DbSet<Exam>? Exams { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Patient>().Property(m => m.PatientID).IsRequired();
            builder.Entity<Exam>().Property(m => m.Id).IsRequired();

            builder.Entity<Patient>().ToTable("Patient");
            builder.Entity<Exam>().ToTable("Exam");
            
            builder.Seed();
        }

    }
}