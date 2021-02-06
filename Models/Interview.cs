using sp19team18finalproject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sp19team18finalproject.Models
{
    
    public class Interview
    {   
        public Int32 InterviewId { get; set; }

        [Required(ErrorMessage = "Room number is required")]
        [Display(Name = "Room Number")]
        public String RoomNumber { get; set; }

        [Required(ErrorMessage = "Interview time is required")]
        [Display(Name = "Interview Time")]
        [DataType(DataType.DateTime)]
        public DateTime InterviewTime { get; set; }

        public Position Position { get; set; }
      
        public AppUser Interviewer { get; set; }

        public AppUser Interviewee { get; set; }
    }
}
