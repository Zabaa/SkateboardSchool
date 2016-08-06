﻿using SkateboardSchool.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardSchool.Domain
{
    public class Trick
    {
        public string Name { get; set; }
        public SkillLevel SkillLevel { get; set; }
        public string Description { get; set; }
    }
}
