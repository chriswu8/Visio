using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VisionX.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        // Clock In and Clock Out
        public TimeSpan? ClockIn { get; set; }
        public TimeSpan? ClockOut { get; set; }
    }
}