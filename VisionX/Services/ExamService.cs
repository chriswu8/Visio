using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VisionX.Data;
using VisionX.Models;

namespace VisionX.Services
{
    public class ExamService
    {
        private readonly ApplicationDbContext _context;

        public ExamService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Exam> GetAllExams()
        {
            return _context.Exams.ToList();
        }

        public void AddExam(Exam exam)
        {
            _context.Exams.Add(exam);
            _context.SaveChanges();
        }

        public void DeleteExam(int examId)
    {
        var examToDelete = _context.Exams.Find(examId);

        if (examToDelete != null)
        {
            _context.Exams.Remove(examToDelete);
            _context.SaveChanges();
        }
        // Optionally, you can handle a case where the exam is not found.
    }

    }
}