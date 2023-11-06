using System.ComponentModel.DataAnnotations;

namespace VisionX.Models
{
    public class Appointment
    {
        [Key]
        public int ID { get; set; }
        public string? Month { get; set; }
        public string? Day { get; set; }
        public string? Year { get; set; }
        public string? Time { get; set; }
        public string? Exam { get; set; }
        public string? Fee { get; set; }
        public int PatientID { get; set; }
        public int InvoiceID { get; set; }

        // Navigation properties
        public Patient Patient { get; set; } // Represents the related patient
        public Invoice Invoice { get; set; } // Represents the related invoice
    }
}

