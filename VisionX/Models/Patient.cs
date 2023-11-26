using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisionX.Models
{
    public class Patient
    {

        // research about attaching images to a patient
        [Key]
        public int PatientID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string? Address { get; set; }
        public string? Province { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? BirthDate { get; set; } // changed from DateTime to string
        public string? ProvincialHealthNumber { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Occupation { get; set; }

        public bool IsSelected { get; set; }
        public bool IsEditing { get; set; }

        // public int ExamId { get; set; } // Foreign Key to Exam table
        // public int InvoiceId { get; set; }

        // [ForeignKey("ExamId")]
        // public Exam Exam { get; set; } // Navigation property for the related Exam

        public string? ExamMonth { get; set; }
        public string? ExamDay { get; set; }
        public string? ExamYear { get; set; }
        public string? ExamTime { get; set; }
        public string? Complaint { get; set; }
        public string? Symptoms { get; set; }
        public string? EyeDrops { get; set; }
        public bool? HistoryOfCancer { get; set; }
        public bool? HistoryOfCataracts { get; set; }
        public bool? HistoryOfDiabetes { get; set; }
        public bool? HistoryOfHeartProblems { get; set; }
        public bool? HistoryOfHIV { get; set; }
        public bool? HistoryOfKidneyDisease { get; set; }
        public bool? HistoryOfMacularDegeneration { get; set; }
        public bool? HistoryOfRetinalDetachment { get; set; }
        public bool? HistoryOfStroke { get; set; }
        public bool? HistoryOfThyroid { get; set; }
        public bool? HistoryOfTuberculosis { get; set; }
        public bool? HistoryOfNeuromuscularDisease { get; set; }
        public string? UncorrectedSphere { get; set; }
        public string? UncorrectedCyliner { get; set; }
        public string? UncorrectedAxis { get; set; }
        public string? CorrectedSphere { get; set; }
        public string? CorrectedCyliner { get; set; }
        public string? CorrectedAxis { get; set; }

        // =====================================
        // Glaucoma Eye Exam Button Predictors
        // =====================================
        
        public string? Sex { get; set; }
        public string? LifeStage { get; set; }
        public string? BloodPressure { get; set; }
        public string? GlaucomaHistory { get; set; }
        public string? HasGlaucoma { get; set; }
        
    }
}
