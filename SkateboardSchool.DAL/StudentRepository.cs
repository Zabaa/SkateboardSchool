using SkateboardSchool.Domain;
using SkateboardSchool.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardSchool.DAL
{
    public class StudentRepository
    {
        public IEnumerable<StudentProfile> GetStudentProfiles()
        {
            return new List<StudentProfile>
            {
                new StudentProfile
                {
                    PersonalData = new PersonalData
                    {
                        FirstName = "Piotr",
                        LastName = "Kobos",
                        NickName = "Sina",
                        BirthDate = new DateTime(1990, 08, 26)
                    },
                    BoardStand = BoardStand.Goofy,
                    SkillLevel = SkillLevel.Rookie2
                },
                new StudentProfile
                {
                    PersonalData = new PersonalData
                    {
                        FirstName = "Łukasz",
                        LastName = "Zaborski",
                        NickName = "Żaba",
                        BirthDate = new DateTime(1990, 09, 02)
                    },
                    BoardStand = BoardStand.Regular,
                    SkillLevel = SkillLevel.Rookie2
                },
                new StudentProfile
                {
                    PersonalData = new PersonalData
                    {
                        FirstName = "Ilona",
                        LastName = "Kośmider",
                        NickName = "Killer",
                        BirthDate = new DateTime(1990, 02, 27)
                    },
                    BoardStand = BoardStand.Regular,
                    SkillLevel = SkillLevel.Rookie2
                }
            };
        }
    }
}
