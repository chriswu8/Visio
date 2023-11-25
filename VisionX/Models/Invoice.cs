using System.ComponentModel.DataAnnotations;

namespace VisionX.Models
{
    public class Invoice
    {
        [Key]
        public int ID { get; set; }
        public int ServiceID { get; set; }
        public int ProductID {get; set;}
        public string? Month { get; set; }
        public string? Day { get; set; }
        public string? Year { get; set; }
    }
}
