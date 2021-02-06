using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using hirelonghorn.DAL;
using hirelonghorn.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace hirelonghorn.Controllers
{    
    public enum YearRange { Before, After };
    public enum GPARange { GreaterThan, LessThan };

    [Authorize(Roles = "Recruiter, CSO")]

    public class StudentSearchController: Controller
    {
        private AppDbContext _db;


        public StudentSearchController(AppDbContext context)
        {
            _db = context;
        }

        
        public IActionResult Index()
        {
            if (User.IsInRole("Recruiter"))
            {
                ViewBag.AllStudentCount = _db.Users.Where(s => s.Major != null && s.Active == true).Count();
                ViewBag.SelectedStudentCount = _db.Users.Where(s => s.Major != null && s.Active == true).Count();
                List<AppUser> appUsers = _db.Users.Where(x => x.Major != null && x.Active == true).Include(s => s.Major).ToList();
                return View(appUsers);
            }
            else
            {
                ViewBag.AllStudentCount = _db.Users.Where(s => s.Major != null).Count();
                ViewBag.SelectedStudentCount = _db.Users.Where(s => s.Major != null).Count();
                List<AppUser> appUsers = _db.Users.Where(x => x.Major != null).Include(s => s.Major).ToList();
                return View(appUsers);
            }
          
        }

       
       [Authorize(Roles = "Recruiter, CSO")]
       public IActionResult StudentSearch()
       {
           ViewBag.AllMajors = GetAllMajors();
           return View();
       }

       [Authorize(Roles = "Recruiter, CSO")]
       public ActionResult DisplayStudentSearchResults(String SearchFirstName, String SearchLastName, int SelectedMajor, String SearchGraduationYear, YearRange SelectedYearRange, String SearchGPA, GPARange SelectedGPARange, Classification SelectedPositionType)
       {
           if (User.IsInRole("Recruiter"))
           {
               var query = from s in _db.Users.Where(x => x.Major != null && x.Active == true)
                           select s;
               if (SearchFirstName != null && SearchFirstName != "")
               {
                   query = query.Where(s => s.FirstName.Contains(SearchFirstName));
               }
               if (SearchLastName != null && SearchLastName != "")
               {
                   query = query.Where(s => s.LastName.Contains(SearchLastName));
               }
               if (SelectedMajor != 0) // they chose something from the drop-down list
               {
                   query = query.Where(b => b.Major.MajorID == SelectedMajor);
               }

               if (SearchGraduationYear != null && SearchGraduationYear != "")
               {
                   Int32 intGraduationYear;
                   try
                   {
                       intGraduationYear = Convert.ToInt32(SearchGraduationYear);
                       switch (SelectedYearRange)
                       {
                           case YearRange.After:

                               query = query.Where(s => s.GraduationDate >= intGraduationYear);
                               break;

                           case YearRange.Before:
                               query = query.Where(s => s.GraduationDate <= intGraduationYear);
                               break;

                           default:
                               break;

                       }
                   }
                   catch  //this code will display when something is wrong
                   {
                       //Add a message for the viewbag
                       ViewBag.Message = SearchGraduationYear + "is not valid number. Please try again";

                       //Re-populate dropdown
                       ViewBag.AllMajors = GetAllMajors();

                       //Send user back to home page
                       return View("StudentSearch");
                   }

               }
               if (SearchGPA != null && SearchGPA != "")
               {
                   Decimal decGPA;
                   try
                   {
                       decGPA = Convert.ToDecimal(SearchGPA);
                       switch (SelectedGPARange)
                       {
                           case GPARange.GreaterThan:

                               query = query.Where(s => s.GPA >= decGPA);
                               break;

                           case GPARange.LessThan:
                               query = query.Where(s => s.GPA <= decGPA);
                               break;

                           default:
                               break;

                       }
                   }
                   catch  //this code will display when something is wrong
                   {
                       //Add a message for the viewbag
                       ViewBag.Message = SearchGPA + "is not valid number. Please try again";

                       //Re-populate dropdown
                       ViewBag.AllMajors = GetAllMajors();

                       //Send user back to home page
                       return View("StudentSearch");
                   }

               }

               switch (SelectedPositionType)
               {
                   case Classification.I:
                       query = query.Where(s => s.PositionType == "I");
                       break;
                   case Classification.FT:
                       query = query.Where(s => s.PositionType == "FT");
                       break;
                   default:
                       query = query.Where(s => s.PositionType == "I" || s.PositionType == "FT");
                       break;

               }

               List<AppUser> SelectedStudents = query.Include(s => s.Major).ToList(); // change to student after identity
               ViewBag.AllStudentCount = _db.Users.Where(s => s.Major != null && s.Active == true).Count();
               ViewBag.SelectedStudentCount = SelectedStudents.Count();
               return View("Index", SelectedStudents);
           }

            else
            {
                var query = from s in _db.Users.Where(x => x.Major != null)
                            select s;
                if (SearchFirstName != null && SearchFirstName != "")
                {
                    query = query.Where(s => s.FirstName.Contains(SearchFirstName));
                }
                if (SearchLastName != null && SearchLastName != "")
                {
                    query = query.Where(s => s.LastName.Contains(SearchLastName));
                }
                if (SelectedMajor != 0) // they chose something from the drop-down list
                {
                    query = query.Where(b => b.Major.MajorID == SelectedMajor);
                }

                if (SearchGraduationYear != null && SearchGraduationYear != "")
                {
                    Int32 intGraduationYear;
                    try
                    {
                        intGraduationYear = Convert.ToInt32(SearchGraduationYear);
                        switch (SelectedYearRange)
                        {
                            case YearRange.After:

                                query = query.Where(s => s.GraduationDate >= intGraduationYear);
                                break;

                            case YearRange.Before:
                                query = query.Where(s => s.GraduationDate <= intGraduationYear);
                                break;

                            default:
                                break;

                        }
                    }
                    catch  //this code will display when something is wrong
                    {
                        //Add a message for the viewbag
                        ViewBag.Message = SearchGraduationYear + "is not valid number. Please try again";

                        //Re-populate dropdown
                        ViewBag.AllMajors = GetAllMajors();

                        //Send user back to home page
                        return View("StudentSearch");
                    }

                }
                if (SearchGPA != null && SearchGPA != "")
                {
                    Decimal decGPA;
                    try
                    {
                        decGPA = Convert.ToDecimal(SearchGPA);
                        switch (SelectedGPARange)
                        {
                            case GPARange.GreaterThan:

                                query = query.Where(s => s.GPA >= decGPA);
                                break;

                            case GPARange.LessThan:
                                query = query.Where(s => s.GPA <= decGPA);
                                break;

                            default:
                                break;

                        }
                    }
                    catch  //this code will display when something is wrong
                    {
                        //Add a message for the viewbag
                        ViewBag.Message = SearchGPA + "is not valid number. Please try again";

                        //Re-populate dropdown
                        ViewBag.AllMajors = GetAllMajors();

                        //Send user back to home page
                        return View("StudentSearch");
                    }

                }

                switch (SelectedPositionType)
                {
                    case Classification.I:
                        query = query.Where(s => s.PositionType == "I");
                        break;
                    case Classification.FT:
                        query = query.Where(s => s.PositionType == "FT");
                        break;
                    default:
                        query = query.Where(s => s.PositionType == "I" || s.PositionType == "FT");
                        break;

                }

                List<AppUser> SelectedStudents = query.Include(s => s.Major).ToList(); // change to student after identity
                ViewBag.AllStudentCount = _db.Users.Where(s => s.Major != null).Count();
                ViewBag.SelectedStudentCount = SelectedStudents.Count();
                return View("Index", SelectedStudents);
            }

        }
       public SelectList GetAllMajors()
       {
           List<Major> Majors = _db.Majors.ToList();
           Major SelectNone = new Major() { MajorID = 0, MajorName = "All Majors" };
           Majors.Add(SelectNone);
           SelectList AllMajors = new SelectList(Majors.OrderBy(m => m.MajorID), "MajorID", "MajorName");

           //return the select list
           return AllMajors;
       }


       /*public IActionResult Student.Details(int? id)
       {
           if (id == null) //StudentID not specified
           {
               return View("Error", new String[] { "BookID not specified - which book do you want to view?" });
           }

           Student student= _db.Students.Include(s => s.Major).FirstOrDefault(s => s.StudentID == id);

           if (student == null) //Student does not exist in database
           {
               return View("Error", new String[] { "Student not found in database" });
           }

           //if code gets this far, all is well
           return View(student);
       }
       */

    }



}

