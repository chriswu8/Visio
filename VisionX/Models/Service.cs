using System.ComponentModel.DataAnnotations;

namespace VisionX.Models
{
    public class Service
    {
        [Key]
        public int Id
        {
            get; set;
        }
        public string? Code
        {
            get; set;
        }
        public int Fee
        {
            get; set;
        }
        public string? Description
        {
            get; set;
        }
    }
}
