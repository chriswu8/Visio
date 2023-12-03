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

        public async Task DeleteExam(int serviceId)
        {
            var serviceToDelete = await _context.Services.FindAsync(serviceId);

            if (serviceToDelete != null)
            {
                // Check for related appointments
                var hasAppointments = _context.Appointments.Any(a => a.ServiceID == serviceId);

                if (hasAppointments)
                {
                    // Handle the case where there are related appointments
                    // For example, you can throw an exception or return a specific result.
                    // You can customize this part based on your application's requirements.
                    throw new InvalidOperationException("Cannot delete the service because it has related appointments.");
                }

                // If there are no related appointments, proceed with deletion
                _context.Services.Remove(serviceToDelete);
                await _context.SaveChangesAsync();
            }
            // Optionally, you can handle a case where the service is not found.
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

        public void EditService(int serviceIdToEdit, Service updatedService)
        {

            var serviceToUpdate = _context.Services.Find(serviceIdToEdit);
            
            if (serviceToUpdate != null)
            {
                Console.WriteLine(updatedService.Id);

                // Update the properties of the existing service with the new values
                serviceToUpdate.Code = updatedService.Code;
                serviceToUpdate.Fee = updatedService.Fee;
                serviceToUpdate.Description = updatedService.Description;

                _context.SaveChanges();
            }
            // Optionally, you can handle a case where the service is not found.
        }

    }
}