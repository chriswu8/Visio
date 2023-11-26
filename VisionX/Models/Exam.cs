namespace VisionX.Models
{
    public class Exam
    {
        public int ExamId { get; set; }
        public string? ExamMonth { get; set; }
        public string? ExamDay { get; set; }
        public string? ExamYear { get; set; }
        public string? ExamTime { get; set; }
        public string? Complaint { get; set; }
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
        public string? GlaucomaFamilyHistory { get; set; }
        public string? HasGlaucoma { get; set; }




        // Other properties like Month, Day, Year, Time, and navigation properties
        /*public int AppointmentID { get; set; }
        public Appointment Appointment { get; set; }*/
    }
}
