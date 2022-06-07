using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ExamResult : Base
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public double Result { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsFinished { get; set; }
    }
}
