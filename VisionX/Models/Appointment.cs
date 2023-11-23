using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        // Foreign key references
        public int? PatientID { get; set; }
        public int? ServiceID { get; set; }

        // Navigation properties
        [ForeignKey("PatientID")]
        public Patient? Patient { get; set; } // Represents the related patient

        [ForeignKey("ServiceID")]
        public Service? Service { get; set; } // Represents the related exam
    }
}

