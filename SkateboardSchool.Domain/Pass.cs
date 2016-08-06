using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardSchool.Domain
{
    public class Pass
    {
        public Trick Trick { get; set; }
        public Instructor Instructor { get; set; }
        public DateTime Date { get; set; }
        public string Place { get; set; }
    }
}
