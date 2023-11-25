using Microsoft.EntityFrameworkCore;
using VisionX.Models;

namespace VisionX.Data
{
    public static class SeedData
    {
        // this is an extension method to the ModelBuilder class
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasData(GetPatients());

            modelBuilder.Entity<Service>().HasData(GetServices());
            modelBuilder.Entity<Appointment>().HasData(GetAppointments());
            modelBuilder.Entity<Exam>().HasData(GetExams());

        }

        public static List<Exam> GetExams()
        {
            List<Exam> exams = new List<Exam>()
            {
                new Exam() {
                ExamId = 1,
                ExamMonth = "1",
                ExamDay = "1",
                ExamYear = "2011",
                ExamTime = "11",
                Complaint = "",
                EyeDrops = "",
                HistoryOfCancer = false,
                HistoryOfCataracts = false,
                HistoryOfDiabetes = false,
                HistoryOfHeartProblems = false,
                HistoryOfHIV = false,
                HistoryOfKidneyDisease = false,
                HistoryOfMacularDegeneration = false,
                HistoryOfRetinalDetachment = false,
                HistoryOfStroke = false,
                HistoryOfThyroid = false,
                HistoryOfTuberculosis = false,
                HistoryOfNeuromuscularDisease = false,
                UncorrectedSphere = "0.00",
                UncorrectedCyliner = "na",
                UncorrectedAxis = "na",
                CorrectedSphere = "na",
                CorrectedCyliner = "na",
                CorrectedAxis = "na",

                Sex = "Male",
                LifeStage = "Young adulthood",
                BloodPressure = "Normal",
                GlaucomaFamilyHistory = "None",
                HasGlaucoma = false
                },

                new Exam() {
                ExamId = 2,
                ExamMonth = "2",
                ExamDay = "2",
                ExamYear = "2022",
                ExamTime = "10:00AM",
                Complaint = "",
                EyeDrops = "",
                HistoryOfCancer = false,
                HistoryOfCataracts = false,
                HistoryOfDiabetes = false,
                HistoryOfHeartProblems = false,
                HistoryOfHIV = false,
                HistoryOfKidneyDisease = false,
                HistoryOfMacularDegeneration = false,
                HistoryOfRetinalDetachment = false,
                HistoryOfStroke = false,
                HistoryOfThyroid = false,
                HistoryOfTuberculosis = false,
                HistoryOfNeuromuscularDisease = false,
                UncorrectedSphere = "0.00",
                UncorrectedCyliner = "na",
                UncorrectedAxis = "na",
                CorrectedSphere = "na",
                CorrectedCyliner = "na",
                CorrectedAxis = "na",

                Sex = "Male",
                LifeStage = "Young adulthood",
                BloodPressure = "Normal",
                GlaucomaFamilyHistory = "None",
                HasGlaucoma = false
                },

                new Exam() {
                ExamId = 3,
                ExamMonth = "3",
                ExamYear = "2013",
                ExamTime = "13:00",
                Complaint = "",
                EyeDrops = "",
                HistoryOfCancer = false,
                HistoryOfCataracts = false,
                HistoryOfDiabetes = false,
                HistoryOfHeartProblems = false,
                HistoryOfHIV = false,
                HistoryOfKidneyDisease = false,
                HistoryOfMacularDegeneration = false,
                HistoryOfRetinalDetachment = false,
                HistoryOfStroke = false,
                HistoryOfThyroid = false,
                HistoryOfTuberculosis = false,
                HistoryOfNeuromuscularDisease = false,
                UncorrectedSphere = "0.00",
                UncorrectedCyliner = "na",
                UncorrectedAxis = "na",
                CorrectedSphere = "na",
                CorrectedCyliner = "na",
                CorrectedAxis = "na",

                Sex = "Male",
                LifeStage = "Young adulthood",
                BloodPressure = "Normal",
                GlaucomaFamilyHistory = "None",
                HasGlaucoma = false
                },
            };
            return exams;
        }


        public static List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>() {
            new Patient() {
                PatientID = 1,
                LastName = "Chen",
                FirstName = "Edmond",
                MiddleName = "Li",
                Address = "123 Main st",
                Province = "BC",
                City = "Vancouver",
                PostalCode = "VA2 34B",
                ProvincialHealthNumber = "12345",
                Phone = "233132",
                Email = "test@mail.com",
                Occupation = "test",
                IsSelected = false,
                IsEditing = false,
                ExamId = 1
            },
            new Patient() {
                PatientID = 2,
                LastName = "Wu",
                FirstName = "Chris",
                MiddleName = "Yue",
                Address = "123 Test St",
                Province = "BC",
                City = "Richmond",
                PostalCode = "VA2 34B",
                ProvincialHealthNumber = "12345",
                Phone = "233132",
                Email = "test@mail.com",
                Occupation = "test",
                IsSelected = false,
                IsEditing = false,
                ExamId = 2
            },
            new Patient() {
                PatientID = 3,
                LastName = "Ocampo",
                FirstName = "Kris",
                MiddleName = "Li",
                Address = "123 Minor st",
                Province = "BC",
                City = "Vancouver",
                PostalCode = "VA2 34B",
                ProvincialHealthNumber = "12345",
                Phone = "233132",
                Email = "test@mail.com",
                Occupation = "test",
                IsSelected = false,
                IsEditing = false,
                ExamId = 3
            }
        };

            return patients;
        }

        public static List<Service> GetServices()
        {
            List<Service> services = new List<Service>() {
            new Service() {
                Id = 1,
                Fee = 100,
                Code = "REE1",
                Description = "Regular Eye Exam"
            },
            new Service() {
                Id = 2,
                Fee = 200,
                Code = "GEE1",
                Description = "Glaucoma Eye Exam"
            },
            new Service() {
                Id = 3,
                Fee = 300,
                Code = "YEE1",
                Description = "Regular Eye Exam 3"
            }
        };
            return services;
        }

        public static List<Appointment> GetAppointments()
        {
            List<Appointment> appointments = new List<Appointment>() {
            new Appointment() {
                ID = 1,
                PatientID = 1,
                ServiceID = 1,
                Month = "1",
                Day = "21",
                Year = "2023",
                Time = "9:00"
            }
        };
            return appointments;
        }
    }
}