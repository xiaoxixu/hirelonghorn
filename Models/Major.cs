﻿using hirelonghorn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hirelonghorn.Models
{
    public class Major
    {
        public Int32 MajorID { get; set; }

        [Required]
        public String MajorName { get; set; } 

        public List<AppUser> AppUsers { get; set; }

        public List<MajorPosition> MajorPositions { get; set; }
    }
}
