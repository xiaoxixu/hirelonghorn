using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hirelonghorn.Models
{
    public class MajorPosition
    {
        public Int32 MajorPositionID { get; set; }

        public Major Major { get; set; }

        public Position Position { get; set; }
    }
}
