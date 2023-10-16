namespace VisionX.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public int Fee { get; set; }
        public string? Description { get; set; }

        // Other properties like Month, Day, Year, Time, and navigation properties
        /*public int AppointmentID { get; set; }
        public Appointment Appointment { get; set; }*/
    }
}
