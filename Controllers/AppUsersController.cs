using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sp19team18finalproject.DAL;
using sp19team18finalproject.Models;

namespace sp19team18finalproject.Controllers
{
    public enum YearRange { Before, After };
    public enum GPARange { GreaterThan, LessThan };
    public class AppUsersController : Controller
    {
        private readonly AppDbContext _context;



        public AppUsersController(AppDbContext context)
        {
            _context = context;
        }

        /*// GET: AppUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.AppUsers.ToListAsync());
        }*/
        public IActionResult Index()
        {
            ViewBag.AllMajors = GetAllMajors();
            return View();
        }

        // GET: AppUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appUser = await _context.AppUsers
                .FirstOrDefaultAsync(m => m.AppUserID == id);
            if (appUser == null)
            {
                return NotFound();
            }

            return View(appUser);
        }

        // GET: AppUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AppUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AppUserID,FirstName,LastName,MiddleInitial,Email,GraduationDate,GPA,PositionType")] AppUser appUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(appUser);
        }

        // GET: AppUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appUser = await _context.AppUsers.FindAsync(id);
            if (appUser == null)
            {
                return NotFound();
            }
            return View(appUser);
        }

        // POST: AppUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AppUserID,FirstName,LastName,MiddleInitial,Email,GraduationDate,GPA,PositionType")] AppUser appUser)
        {
            if (id != appUser.AppUserID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppUserExists(appUser.AppUserID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(appUser);
        }

        // GET: AppUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appUser = await _context.AppUsers
                .FirstOrDefaultAsync(m => m.AppUserID == id);
            if (appUser == null)
            {
                return NotFound();
            }

            return View(appUser);
        }

        // POST: AppUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appUser = await _context.AppUsers.FindAsync(id);
            _context.AppUsers.Remove(appUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult StudentSearch()
        {
            ViewBag.AllMajors = GetAllMajors();
            return View("StudentSearch");
        }

        public ActionResult DisplayStudentSearchResults(String SearchFirstName, String SearchLastName, int SelectedMajor, String SearchGraduationYear, YearRange SelectedYearRange, String SearchGPA, GPARange SelectedGPARange, Classification SelectedPositionType)
        {
            var query = from s in _context.AppUsers
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
                query = query.Where(b => b.Major.MajorID == (SelectedMajor));
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

                            query = query.Where(s => s.GraduationDate >= (intGraduationYear));
                            break;

                        case YearRange.Before:
                            query = query.Where(s => s.GraduationDate <= (intGraduationYear));
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

                            query = query.Where(s => s.GPA >= (decGPA));
                            break;

                        case GPARange.LessThan:
                            query = query.Where(s => s.GPA <= (decGPA));
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
            ViewBag.AllPositionCount = _context.AppUsers.Count(); // change to student after identity
            ViewBag.SelectedPositionCount = SelectedStudents.Count();
            return View("Index", SelectedStudents);



        }
        public MultiSelectList GetAllMajors()
        {
            List<Major> Majors = _context.Majors.ToList();

            SelectList AllMajors = new SelectList(Majors.OrderBy(m => m.MajorID), "MajorID", "MajorName");

            return AllMajors;



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
        public async Task<IActionResult> Interview(int? id)


        {
            if (id == null)
            {
                return NotFound();
            }

            AppUser appUser = await _context.AppUsers.FindAsync(id);
            if (appUser == null)
            {
                return NotFound();
            }

            return RedirectToAction("Create", "Inverviews", new { id = appUser.AppUserID });

        }

        private bool AppUserExists(int id)
        {
            return _context.AppUsers.Any(e => e.AppUserID == id);
        }
    }
}
