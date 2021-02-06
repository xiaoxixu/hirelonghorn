using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hirelonghorn.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        public bool Active { get; set; }
    
        [Required(ErrorMessage = "First Name is Required")]
        [Display(Name = "First Name:")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        [Display(Name = "Last Name:")]
        public String LastName { get; set; }

        [Display(Name = "Middle Initial:")]
        public String MiddleInitial { get; set; }

        /*[Required(ErrorMessage = "Email is Required")]
        [Display(Name = "Email:")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public String Email { get; set; } */

        [Display(Name = "Graduation Date:")]
        public Int32 GraduationDate { get; set; }

        [Display(Name = "GPA:")]
        public Decimal GPA { get; set; }

        [Display(Name = "Position Type:")]
        public String PositionType { get; set; }

        public Major Major { get; set; }

        public Company Company { get; set; }

        public List<Application> Applications { get; set; }

        [InverseProperty("Interviewer")]
        public List<Interview> InterviewsGiven { get; set; }

        [InverseProperty ("Interviewee")]
        public List<Interview> InterviewsSuffered { get; set; }

        public String FullName
        { 
            get { return FirstName + " " + LastName; }
        }

    }
}
