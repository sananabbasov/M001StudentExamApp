using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Question : Base
    {
        public string QuestionText { get; set; }
        public string VariantA { get; set; } // Sehf usul
        public string VariantB { get; set; } // Sehf usul
        public string VariantC { get; set; } // Sehf usul
        public string VariantD { get; set; } // Sehf usul
        public string CorrectVariant { get; set; }
        public int Level { get; set; }
    }
}
