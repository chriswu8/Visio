using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VisionX.Data;
using VisionX.Models;

namespace VisionX.Services
{
    public class ServicesService
    {
        private readonly ApplicationDbContext _context;

        public ServicesService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Service> GetAllServices()
        {
            return _context.Services.ToList();
        }

        public void AddExam(Service service)
        {
            _context.Services.Add(service);
            _context.SaveChanges();
        }

        public void DeleteExam(int serviceId)
        {
            var serviceToDelete = _context.Services.Find(serviceId);

            if (serviceToDelete != null)
            {
                _context.Services.Remove(serviceToDelete);
                _context.SaveChanges();
            }
            // Optionally, you can handle a case where the exam is not found.
        }

        public void UpdateFee(int serviceId, int newFee)
        {
            var serviceToUpdate = _context.Services.Find(serviceId);

            if (serviceToUpdate != null)
            {
                serviceToUpdate.Fee = newFee;
                _context.SaveChanges();
            }
            // Optionally, you can handle a case where the service is not found.
        }


    }
}