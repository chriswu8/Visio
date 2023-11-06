using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}