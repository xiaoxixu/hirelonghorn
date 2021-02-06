using hirelonghorn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hirelonghorn.Models
{
    public class Company
    {
        public Int32 CompanyID { get; set; }

        [Required(ErrorMessage = "Company name is required")]
        [Display(Name = "Company Name")]
        public String CompanyName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public String CompanyEmail { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [Display(Name = "Description")]
        public String Description { get; set; }

        [Required(ErrorMessage = "At least one industry is required")]
        [Display(Name = "Industry")]
        public String Industry { get; set; }

        public List<Position> Positions { get; set; }

        public List<AppUser> AppUsers { get; set; }
    }
}
