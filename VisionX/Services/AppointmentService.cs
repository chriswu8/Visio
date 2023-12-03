using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisionX.Data;
using VisionX.Models;


namespace VisionX.Services
{
    public class AppointmentService
    {
        private readonly ApplicationDbContext _context;

        public AppointmentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Appointment> GetAppointmentsWithDetails()
        {
            // Use Include to include related entities (Patient and Exam)
            return _context.Appointments
                .Include(appointment => appointment.Patient)
                .Include(appointment => appointment.Service)
                .ToList();
        }

        public async Task AddAppointmentAsync(Appointment appointment)
        {
            // Ensure the Exam and Patient entities are attached to the context
            // if (appointment.ExamId > 0)
            // {
            //     var existingExam = await _context.Exams.FindAsync(appointment.ExamId);
            //     if (existingExam != null)
            //     {
            //         appointment.Exam = existingExam;
            //         _context.Entry(existingExam).State = EntityState.Unchanged;
            //     }
            // }

            // if (appointment.PatientId > 0)
            // {
            //     var existingPatient = await _context.Patients.FindAsync(appointment.PatientId);
            //     if (existingPatient != null)
            //     {
            //         appointment.Patient = existingPatient;
            //         _context.Entry(existingPatient).State = EntityState.Unchanged;
            //     }
            // }

            // Add the appointment to the DbSet
            Console.WriteLine(appointment);
            _context.Appointments.Add(appointment);

            // Save changes to the database
            await _context.SaveChangesAsync();
        }

        public List<Appointment> SearchAppointmentByDate(string year, string month, string day)
        {
            // Parse the strings into integers
            // if (int.TryParse(year, out int parsedYear) &&
            //     int.TryParse(month, out int parsedMonth) &&
            //     int.TryParse(day, out int parsedDay))
            // {
            //     // Create a DateTime object based on the parsed values
            //     var targetDate = new DateTime(parsedYear, parsedMonth, parsedDay);

            return _context.Appointments
                .Where(appt => appt.Year == year && appt.Month == month && appt.Day == day)
                .ToList();
            // }
            // else
            // {
            //     // Handle the case where parsing fails
            //     throw new ArgumentException("Invalid date parameters");
            // }
        }

        public async Task DeleteAppointmentAsync(int appointmentId)
        {
            var appointmentToDelete = await _context.Appointments.FindAsync(appointmentId);

            if (appointmentToDelete != null)
            {
                _context.Appointments.Remove(appointmentToDelete);
                await _context.SaveChangesAsync();
            }
            else
            {
                // Handle the case where the appointment with the given ID doesn't exist
                throw new InvalidOperationException("Appointment not found");
            }
        }

    }
}