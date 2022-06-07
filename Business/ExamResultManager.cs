using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ExamResultManager
    {
        AppDbContext _context = new();


        public ExamResult Create(ExamResult exam)
        {
            _context.ExamResults.Add(exam);
            _context.SaveChanges();
            return exam;
        }

        public void Yenile(ExamResult exam)
        {
            _context.ExamResults.Update(exam);
            _context.SaveChanges();
        }

        public ExamResult GetById(int id)
        {
            return _context.ExamResults.FirstOrDefault(x => x.Id == id);
        }

    }
}
