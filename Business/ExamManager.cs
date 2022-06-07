using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ExamManager
    {
        AppDbContext _context = new();



        public Question GetQuestion(int skip)
        {

            var question = _context.Questions.Skip(skip).Take(1).FirstOrDefault();

            return question;
        }

        public Exam GetGroupQuestion(int skip, int groupId)
        {
            var groupQuestion = _context.Exams
                .Include(x=>x.Question)
                .Include(x=>x.Group)
                .Where(x=>x.GroupId == groupId)
                .Skip(skip)
                .Take(1)
                .FirstOrDefault();

            return groupQuestion;
        }

    }
}
