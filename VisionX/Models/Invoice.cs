using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisionX.Models
{
    public class Invoice
    {
        [Key]
        public int ID { get; set; }
        public int? PatientID {get; set;}
        public string? Month { get; set; }
        public string? Day { get; set; }
        public string? Year { get; set; }
        public int? Fee {get; set;}
        public int? ServiceID { get; set; }
        public int? ProductID {get; set;}
        public bool IsPaid {get; set;}

        [ForeignKey("ServiceID")]
        public Service? Service {get; set;}

        [ForeignKey("ProductID")]
        public Product? Product {get; set;}
        [ForeignKey("PatientID")]
        public Patient? Patient {get; set;}
    }
}
