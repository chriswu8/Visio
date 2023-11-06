using Microsoft.EntityFrameworkCore;
using VisionX.Models;

namespace VisionX.Data
{
    public static class SeedData
    {
        // this is an extension method to the ModelBuilder class
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasData(
                GetPatients()
            );

        }
        public static List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>() {
            new Patient() {
                PatientID = 1,
                LastName = "Chen",
                FirstName = "Edmond",
                MiddleName = "Li",
                Address = "123 Main st",
                Province = "BC",
                City = "Vancouver",
                PostalCode = "VA2 34B",
                ProvincialHealthNumber = "12345",
                Phone = "233132",
                Email = "test@mail.com",
                Occupation = "test",
            }
        };

            return patients;
        }
    }
}