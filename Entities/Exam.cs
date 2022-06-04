using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Exam : Base
    {
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
