using System.ComponentModel.DataAnnotations;

namespace VisionX.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string? Manufacturer { get; set; }
        public string? Type { get; set; }
        public string? ModelNumber {get; set;}
        public int? Fee { get; set; }
        
    }
}
