using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisionX.Data;
using VisionX.Models;

namespace VisionX.Services
{
    public class PatientService
    {
        private readonly ApplicationDbContext _context;

        public PatientService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Patient> GetAllPatients()
        {
            return _context.Patients.ToList();
        }

        public async Task AddPatientAsync(Patient patient)
        {
            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePatientAsync(Patient patient)
        {
            _context.Entry(patient).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeletePatientAsync(int patientId)
        {
            var patient = await _context.Patients.FindAsync(patientId);
            if (patient != null)
            {
                _context.Patients.Remove(patient);
                await _context.SaveChangesAsync();
            }
        }
    }
}