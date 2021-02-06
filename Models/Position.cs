using sp19team18finalproject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sp19team18finalproject.Models
{
    public class Position
    {
        public Int32 PositionID { get; set; }

        [Required(ErrorMessage = "Position title is required")]
        [Display(Name = "Position Title")]
        public String PositionTitle { get; set; }

        [Display(Name = "Description")]
        public String Description { get; set; }

        [Required(ErrorMessage = "Position type is required")]
        [Display(Name = "Position Type")]
        public String PositionType { get; set; }

        [Required(ErrorMessage = "Location is required")]
        [Display(Name = "Location")]
        public String Location { get; set; }

        [Required(ErrorMessage = "Deadline is required")]
        [Display(Name = "Deadline")]
        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; }

        public List <MajorPosition> MajorPositions { get; set; }

        public List<Application> Applications { get; set; }

        public List <Interview> Interviews { get; set; }

        public Company Company { get; set; }
    }
}
