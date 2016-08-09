using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkateboardSchool.Domain;
using SkateboardSchool.Domain.Enums;

namespace SkateboardSchool.DAL.Repository
{
    public class PassesRepository
    {
        public IEnumerable<Pass> GetPasses()
        {
            return new List<Pass>
            {
                new Pass
                {
                    Trick = new Trick
                    {
                        Name = "Ollie",
                        SkillLevel = SkillLevel.Rookie1
                    },
                    Date = DateTime.Now,
                    Instructor = new Instructor
                    {
                        PersonalData = new PersonalData
                        {
                            FirstName = "Piotr",
                            LastName = "Kobos",
                            BirthDate = DateTime.Now
                        }
                    },
                    Place = "Kraków Forum Pool"
                },
                new Pass
                {
                    Trick = new Trick
                    {
                        Name = "Nollie",
                        SkillLevel = SkillLevel.Rookie1
                    },
                    Date = DateTime.Now,
                    Instructor = new Instructor
                    {
                        PersonalData = new PersonalData
                        {
                            FirstName = "Piotr",
                            LastName = "Kobos",
                            BirthDate = DateTime.Now
                        }
                    },
                    Place = "Kraków Forum Pool"
                },
                new Pass
                {
                    Trick = new Trick
                    {
                        Name = "Kickflip",
                        SkillLevel = SkillLevel.Rookie2
                    },
                    Date = DateTime.Now,
                    Instructor = new Instructor
                    {
                        PersonalData = new PersonalData
                        {
                            FirstName = "Piotr",
                            LastName = "Kobos",
                            BirthDate = DateTime.Now
                        }
                    },
                    Place = "Kraków Forum Pool"
                },
            };
        }
    }
}
