using SkateboardSchool.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardSchool.Domain
{
    public class StudentProfile
    {
        public PersonalData PersonalData { get; set; }
        public SkillLevel SkillLevel { get; set; }
        public BoardStand BoardStand { get; set; }

        public IEnumerable<Pass> Passes { get; set; }
        public IEnumerable<Class> Classes { get; set; }
    }
}
    