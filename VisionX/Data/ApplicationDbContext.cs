using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using VisionX.Models;

namespace VisionX.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }


        public DbSet<Patient>? Patients { get; set; }

        public DbSet<Service>? Services { get; set; }
        public DbSet<Appointment>? Appointments { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Invoice>? Invoices { get; set; }
        public DbSet<Employee>? Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Patient>().Property(m => m.PatientID).IsRequired();
            builder.Entity<Service>().Property(m => m.Id).IsRequired();
            builder.Entity<Appointment>().Property(m => m.ID).IsRequired();
            builder.Entity<Product>().Property(m => m.ID).IsRequired();
            builder.Entity<Invoice>().Property(m => m.ID).IsRequired();
            builder.Entity<Employee>().Property(m => m.ID).IsRequired();

            builder.Entity<Patient>().ToTable("Patient");
            builder.Entity<Service>().ToTable("Service");
            builder.Entity<Appointment>().ToTable("Appointment");
            builder.Entity<Product>().ToTable("Product");
            builder.Entity<Invoice>().ToTable("Invoice");
            builder.Entity<Employee>().ToTable("Employee");


            builder.Seed();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Disable logging for this specific DbContext
            optionsBuilder.UseLoggerFactory(LoggerFactory.Create(builder =>
                builder.AddFilter((category, level) =>
                    category == DbLoggerCategory.Database.Command.Name
                    && level == Microsoft.Extensions.Logging.LogLevel.Information)));
        }

    }
}