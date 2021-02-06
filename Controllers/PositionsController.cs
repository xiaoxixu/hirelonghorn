using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sp19team18finalproject.DAL;
using sp19team18finalproject.Models;

namespace sp19team18finalproject.Controllers
{   

    public enum Classification { ALL, FT, I }
    [Authorize]

    public class PositionsController : Controller
    {
        private readonly AppDbContext _context;

        public PositionsController(AppDbContext context)
        {
            _context = context;
        }

        [Authorize]
        // GET: Positions
        public IActionResult Index()
        {
            if (User.IsInRole("CSO"))
            {
                ViewBag.AllPositionCount = _context.Positions.Count();
                ViewBag.SelectedPositionCount = _context.Positions.Count();

                var query = from p in _context.Positions
                            select p;

                return View(_context.Positions.Include(p => p.Company).ToList());
            }
            
            if (User.IsInRole("Recruiter"))
            {
                AppUser recruiter = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
                List<Position> Positions = _context.Positions.Where(p => p.Company.AppUsers.Any(a=>a.Id == recruiter.Id ))
                    .Include(p => p.Company).ToList();
                return View(Positions);
            }
            

            else //(User.IsInRole("Student"))
            {
                ViewBag.AllPositionCount = _context.Positions.Where(p => p.Deadline >= Utilities.Time.SystemTime).Count();
                ViewBag.SelectedPositionCount = _context.Positions.Where(p => p.Deadline >= Utilities.Time.SystemTime).Count();

                var query = from p in _context.Positions
                            .Where(p => p.Deadline >= Utilities.Time.SystemTime)
                            select p;

                return View( _context.Positions.Where(p => p.Deadline >= Utilities.Time.SystemTime).Include(p => p.Company).ToList());
            }
        }

        [Authorize]
        // GET: Positions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Position position = await _context.Positions
                .Include(p => p.Company)
                .Include(p => p.MajorPositions).ThenInclude(m => m.Major)
                .Include(p=>p.Interviews)
                .FirstOrDefaultAsync(p => p.PositionID == id);
            if (position == null)
            {
                return NotFound();
            }
            return View(position);
        }

        [Authorize(Roles = "Recruiter, CSO")]
        public IActionResult Create()
        {
            Position pos = new Position();
            Company com = _context.Companies.FirstOrDefault(c => c.AppUsers.Any(a => a.UserName == User.Identity.Name));
            pos.Company = com;
            ViewBag.AllMajors = GetMajors();
            
            return View(pos);
        }

        [Authorize(Roles = "Recruiter, CSO")]
        public IActionResult CreateForACompany(int? id)
        {
            Position pos = new Position();
            Company com = _context.Companies.FirstOrDefault(c => c.CompanyID == id);
            pos.Company = com;
            ViewBag.AllMajors = GetMajors();

            return View(pos);
        }

        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Recruiter, CSO")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateForACompany([Bind("PositionID,PositionTitle,Description,PositionType,Location,Deadline,Company")] Position position, int[] SelectedMajors)
        {
            position.Company = _context.Companies.Find(position.Company.CompanyID);
            if (ModelState.IsValid)
            {
                _context.Add(position);
                _context.SaveChanges();

                Position dbPosition = _context.Positions
                    .Include(p => p.Company)
                    .FirstOrDefault(p => p.PositionID == position.PositionID);

                foreach (int m in SelectedMajors)
                {
                    //find the department specified by the int
                    Major maj = _context.Majors.Find(m);

                    //create a new instance of the bridge table class
                    MajorPosition cd = new MajorPosition();
                    cd.Position = dbPosition;
                    cd.Major = maj;

                    //add the new record to the database
                    _context.MajorPositions.Add(cd);
                    _context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }

            ViewBag.AllMajors = GetAllMajors();
            return View(position);
        }

        // POST: Positions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Recruiter, CSO")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("PositionID,PositionTitle,Description,PositionType,Location,Deadline,Company")] Position position, int[] SelectedMajors)
        {
            position.Company = _context.Companies.Find(position.Company.CompanyID);
            if (ModelState.IsValid)
            {
                _context.Add(position);
                _context.SaveChanges();

                Position dbPosition = _context.Positions
                    .Include(p => p.Company)
                    .FirstOrDefault(p => p.PositionID == position.PositionID);
     
                foreach (int m in SelectedMajors)
                {
                    //find the department specified by the int
                    Major maj = _context.Majors.Find(m);

                    //create a new instance of the bridge table class
                    MajorPosition cd = new MajorPosition();
                    cd.Position = dbPosition;
                    cd.Major = maj;

                    //add the new record to the database
                    _context.MajorPositions.Add(cd);
                    _context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }

            ViewBag.AllMajors = GetAllMajors();
            return View(position);
        }


        // GET: Positions/Edit/5
        [Authorize(Roles = "CSO, Recruiter")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Position position = await _context.Positions.FindAsync(id);
            if (position == null)
            {
                return NotFound();
            }

            ViewBag.AllMajors = GetAllMajors(position.PositionID);
            return View(position);
        }

        // POST: Positions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "CSO, Recruiter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("PositionID,PositionTitle,Description,PositionType,Location,Deadline")] Position position, Classification SelectedClass, int[] SelectedMajors)
        {
            if (ModelState.IsValid)
            {
                Position dbPosition = _context.Positions
                   .Include(cd => cd.MajorPositions).ThenInclude(cd => cd.Major)
                   .FirstOrDefault(p => p.PositionID == position.PositionID);

                //create a list of departments to remove
                List<MajorPosition> MajorsToRemove = new List<MajorPosition>();

                //find departments that should no longer be there
                foreach (MajorPosition cd in dbPosition.MajorPositions)
                {
                    if (SelectedMajors.Contains(cd.Major.MajorID) == false)  //this department is not on the new list
                    {
                        MajorsToRemove.Add(cd);
                    }
                }

                //remove departments you found in the list above - this has to be 2 separate steps because you can't 
                //iterate over a list you are removing things from
                foreach (MajorPosition cd in MajorsToRemove)
                {
                    _context.MajorPositions.Remove(cd);
                    _context.SaveChanges();
                }

                //add departments that aren't already there
                foreach (int i in SelectedMajors)
                {
                    if (dbPosition.MajorPositions.Any(m => m.Major.MajorID == i) == false) //department is not already connect to this course
                    {
                        //create a new instance of the bridge table class
                        MajorPosition cd = new MajorPosition();
                        cd.Major = _context.Majors.Find(i);
                        cd.Position = dbPosition;

                        //add the new instance to the database
                        _context.MajorPositions.Add(cd);
                        _context.SaveChanges();
                    }
                }

                //update the scalar properties
                dbPosition.PositionTitle = position.PositionTitle;
                dbPosition.Description = position.Description;
                dbPosition.PositionType = position.PositionType;
                dbPosition.Location = position.Location;
                dbPosition.Deadline = position.Deadline;

                //save changes
                _context.Positions.Update(dbPosition);
                _context.SaveChanges();

                //return to course listing page
                return RedirectToAction(nameof(Index));
            }

            ViewBag.AllM = GetAllMajors(position.PositionID);
            return View(position);
        }

        /*
        // GET: Positions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var position = await _context.Positions
                .FirstOrDefaultAsync(m => m.PositionID == id);
            if (position == null)
            {
                return NotFound();
            }

            return View(position);
        }

        // POST: Positions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var position = await _context.Positions.FindAsync(id);
            _context.Positions.Remove(position);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        */

        [Authorize(Roles = "CSO, Student")]
        public IActionResult JobSearch()
        {
            ViewBag.AllMajors = GetAllMajors();
            return View("JobSearch");
        }

        [Authorize(Roles = "Student")]
        public async Task<IActionResult> Apply(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Position position = await _context.Positions.FindAsync(id);
            if (position == null)
            {
                return NotFound();
            }

            return RedirectToAction("Create", "Applications", new { id = position.PositionID });
            
        }

        [Authorize(Roles = "CSO, Student")]
        public ActionResult DisplaySearchResults(String PositionTitle, String PositionDescription, Classification SelectedPosition, String Company,
            String Industry, String Location, Int32 Major, DateTime? Deadline)
        {
            if (User.IsInRole("Student"))
            {
                var query = from p in _context.Positions.
                            Where(p => p.Deadline >= Utilities.Time.SystemTime)
                            select p;

                if (PositionTitle != null && PositionTitle != "")
                {
                    query = query.Where(p => p.PositionTitle.Contains(PositionTitle));
                }

                if (PositionDescription != null && PositionDescription != "")
                {
                    query = query.Where(p => p.Description.Contains(PositionDescription));
                }

                switch (SelectedPosition)
                {
                    case Classification.FT:
                        query = query.Where(p => p.PositionType == "FT");
                        break;

                    case Classification.I:
                        query = query.Where(p => p.PositionType == "I");
                        break;

                    default:
                        query = query.Where(p => p.PositionType == "I" || p.PositionType == "FT");
                        break;

                }

                if (Company != null && Company != "")
                {
                    query = query.Where(p => p.Company.CompanyName.Contains(Company));
                }

                if (Industry != null && Industry != "")
                {
                    query = query.Where(p => p.Company.Industry.Contains(Industry));
                }

                if (Location != null && Location != "")
                {
                    query = query.Where(p => p.Location.Contains(Location));
                }

                if (Major != 0)
                {
                    query = query.Where(p => p.MajorPositions.Any(m => m.Major.MajorID == Major));
                }
                List<Position> SelectedPositions = query.Include(p => p.MajorPositions).ThenInclude(p => p.Major).Include(p => p.Company).ToList();
                ViewBag.AllPositionCount = _context.Positions.Where(p => p.Deadline >= Utilities.Time.SystemTime).Count();
                ViewBag.SelectedPositionCount = SelectedPositions.Count();
                return View("Index", SelectedPositions);
            }

            else
            {
                var query = from p in _context.Positions
                            select p;

                if (PositionTitle != null && PositionTitle != "")
                {
                    query = query.Where(p => p.PositionTitle.Contains(PositionTitle));
                }

                if (PositionDescription != null && PositionDescription != "")
                {
                    query = query.Where(p => p.Description.Contains(PositionDescription));
                }

                switch (SelectedPosition)
                {
                    case Classification.FT:
                        query = query.Where(p => p.PositionType == "FT");
                        break;

                    case Classification.I:
                        query = query.Where(p => p.PositionType == "I");
                        break;

                    default:
                        query = query.Where(p => p.PositionType == "I" || p.PositionType == "FT");
                        break;

                }

                if (Company != null && Company != "")
                {
                    query = query.Where(p => p.Company.CompanyName.Contains(Company));
                }

                if (Industry != null && Industry != "")
                {
                    query = query.Where(p => p.Company.Industry.Contains(Industry));
                }

                if (Location != null && Location != "")
                {
                    query = query.Where(p => p.Location.Contains(Location));
                }

                if (Major != 0)
                {
                    query = query.Where(p => p.MajorPositions.Any(m => m.Major.MajorID == Major));
                }
                List<Position> SelectedPositions = query.Include(p => p.MajorPositions).ThenInclude(p => p.Major).Include(p => p.Company).ToList();
                ViewBag.AllPositionCount = _context.Positions.Count();
                ViewBag.SelectedPositionCount = SelectedPositions.Count();
                return View("Index", SelectedPositions);
            }            
            
        }

        public SelectList GetAllMajors()
        {
            List<Major> Majors = _context.Majors.ToList();
            Major SelectNone = new Major() { MajorID = 0, MajorName = "All Majors" };
            Majors.Add(SelectNone);
            SelectList AllMajors = new SelectList(Majors.OrderBy(m => m.MajorID), "MajorID", "MajorName");

            //return the select list
            return AllMajors;
        }

        public SelectList GetMajors()
        {
            List<Major> Majors = _context.Majors.ToList();
            SelectList AllMajors = new SelectList(Majors.OrderBy(m => m.MajorID), "MajorID", "MajorName");
            return AllMajors;
        }

        private MultiSelectList GetAllMajors(Int32 PositionID)
        {
            //make a new list of all the departments
            List<Major> Majors = _context.Majors.ToList();

            //get the list of departments for this course
            List<MajorPosition> MajorPositions = _context.MajorPositions.Where(cd => cd.Position.PositionID == PositionID).ToList();

            //loop through this list to convert to a list of integers
            List<Int32> selectedMajors = new List<Int32>();

            foreach (MajorPosition cd in MajorPositions)
            {
                selectedMajors.Add(cd.Major.MajorID);
            }

            //create the multiselect list with the previously selected departments highlighted
            MultiSelectList AllMajors = new MultiSelectList(Majors, "MajorID", "MajorName", selectedMajors);

            //return the multiselect list
            return AllMajors;
        }

        private bool PositionExists(int id)
        {
            return _context.Positions.Any(e => e.PositionID == id);
        }


    }
}
