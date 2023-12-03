using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisionX.Data;
using VisionX.Models;

namespace VisionX.Services
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _context;

        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.FirstOrDefault(employee => employee.ID == id);
        }

        public async Task AddEmployeeAsync(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
        }

        public void UpdateEmployeeClockInOut(int employeeId, TimeSpan? newClockIn, TimeSpan? newClockOut)
        {
            Employee existingEmployee = _context.Employees.FirstOrDefault(employee => employee.ID == employeeId);

            if (existingEmployee != null)
            {
                // Update ClockIn, ClockOut, and TotalHoursWorked properties
                existingEmployee.ClockIn = newClockIn;
                existingEmployee.ClockOut = newClockOut;
                // existingEmployee.TotalHoursWorked = totalHoursWorked;

                // Save changes to the database
                _context.SaveChanges();
            }
        }

        public void DeleteEmployee(int id)
        {
            Employee employeeToDelete = _context.Employees.FirstOrDefault(employee => employee.ID == id);
            if (employeeToDelete != null)
            {
                _context.Employees.Remove(employeeToDelete);
                _context.SaveChanges();
            }
        }
    }
}