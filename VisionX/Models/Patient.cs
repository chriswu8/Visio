namespace VisionX.Models
{
    public class Patient
    {
        public int PatientId { get; set; } // Primary Key
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Address { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public DateTime BirthDate { get; set; }
        public string ProvincialHealthNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Occupation { get; set; }

        public int ExamId { get; set; } // Foreign Key to Exam table
        public Exam Exam { get; set; } // Navigation property for the related Exam
    }
}
