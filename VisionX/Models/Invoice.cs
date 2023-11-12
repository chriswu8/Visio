namespace VisionX.Models
{
    public class Invoice
    {
        public int ID { get; set; }
        public int patientID { get; set; }
        public int serviceID { get; set; }
        public int fee { get; set; }
        public float totalPaid { get; set; }
    }
}
