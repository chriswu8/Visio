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
    }
}