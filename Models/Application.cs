using sp19team18finalproject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sp19team18finalproject.Models
{
    //public enum StatusType { Pending, Accepted, Rejected };

    public class Application
    {
        [Required]
        public bool Active { get; set; }
        
        public Int32 ApplicationID { get; set; }

        [Required(ErrorMessage = "Application status is required")]
        public String StatusType { get; set; }

        [Required(ErrorMessage = "Application date is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Application Date")]
        public DateTime ApplicationDate { get; set; }

        public Position Position { get; set; }

        public AppUser AppUser { get; set; }
    }
}
