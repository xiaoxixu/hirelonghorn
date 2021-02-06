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
using sp19team18finalproject.Utilities;

namespace sp19team18finalproject.Controllers
{

    public class ApplicationsController : Controller
    {
        private readonly AppDbContext _context;

        public ApplicationsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Applications
        [Authorize]
        public IActionResult Index()
        {
            if (User.IsInRole("CSO"))
            {
                List<Application> Applications = _context.Applications.Include(o => o.Position).ThenInclude(c => c.Company).Include(a => a.AppUser).ThenInclude(c => c.Company).ToList();
                return View(Applications);
            }
            if (User.IsInRole("Student"))
            {
                List<Application> Applications = _context.Applications.Where(o => o.AppUser.UserName == User.Identity.Name&&o.Active==true).
                    Include(ord => ord.Position).
                    ThenInclude(c=>c.Company).ToList();
                return View(Applications);
            }
            else
            {
                List<Application> Applications = _context.Applications.Where(o => o.Position.Company.AppUsers.Any(a=>a.UserName == User.Identity.Name) && o.StatusType=="Pending"&& o.Active == true && o.Position.Deadline<Utilities.Time.SystemTime).Include(ord => ord.Position).Include(s => s.AppUser).ThenInclude(m=>m.Major).ToList();
                return View(Applications);
            }
            //return View(await _context.Applications.ToListAsync());
        }

        // GET: Applications/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Applications.Include(cd => cd.AppUser).ThenInclude(cd=>cd.Major).Include(cd => cd.Position).ThenInclude(od => od.Company)
                .FirstOrDefaultAsync(m => m.ApplicationID == id);
            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        // GET: Applications/Create
        [Authorize(Roles = "Student")]
        public IActionResult Create (int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Application app = new Application();
            app.Position = _context.Positions.Find(id);
            Application existApp = _context.Applications.FirstOrDefault(a => a.AppUser.UserName == User.Identity.Name && a.Position.PositionID==id);
            if (existApp != null)
            {
                return View("Error");
            }
            app.StatusType = "Pending";
            app.ApplicationDate= Utilities.Time.SystemTime;
            return View(app);

        }


        // POST: Applications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Student")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ApplicationID,ApplicationDate,StatusType,Position")] Application application)
        {
            //application.ApplicationDate = DateTime.Now;
            Position po = _context.Positions.Find(application.Position.PositionID);
            application.Position = po;
            //String str1 = "Pending";
            //application.StatusType = str1;
            AppUser user= _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            application.AppUser = user;
            application.Active = true;
            Major maj = _context.Majors.FirstOrDefault(m => m.AppUsers.Any(a=>a.UserName == User.Identity.Name));
            //application.AppUser = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            // int num = application.Position.MajorPositions.Where(a => a.Position.MajorPositions.Any(m=>m.Major==application.AppUser.Major)).Count;
            List<Major> Majors = _context.Majors.Where(m => m.MajorPositions.Any(mp => mp.Position.PositionID==po.PositionID)).ToList();

            if (ModelState.IsValid)
            {
                if (application.ApplicationDate < application.Position.Deadline
                    && application.AppUser.PositionType == application.Position.PositionType
                    && Majors.Contains(maj))

                {

                    _context.Add(application);
                    await _context.SaveChangesAsync();
                    return View("ThanksForApplication");
                }
               
            }
            return View("Error");
        }

        // GET: Applications/Edit/5
        /*public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Applications.FindAsync(id);
            if (application == null)
            {
                return NotFound();
            }
            return View(application);
        }

        // POST: Applications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ApplicationID,StatusType,ApplicationDate")] Application application)
        {
            if (id != application.ApplicationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(application);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationExists(application.ApplicationID))
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
            return View(application);
        }

        // GET: Applications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Applications
                .FirstOrDefaultAsync(m => m.ApplicationID == id);
            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        // POST: Applications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var application = await _context.Applications.FindAsync(id);
            _context.Applications.Remove(application);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }*/
        [Authorize(Roles = "Student")]
        public async Task<IActionResult> Withdraw(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Application app = _context.Applications.Include(a=>a.AppUser).Include(a=>a.Position).FirstOrDefault(a=>a.ApplicationID==id);
            if (app == null)
            {
                return NotFound();
            }
            if (app.Position.Deadline < Utilities.Time.SystemTime)
            {
                return View("Error");
            }
            app.Active = false;
            app.StatusType = "Withdrawn";
            if (ModelState.IsValid)
            {
                _context.Update(app);
                await _context.SaveChangesAsync();
                return View("SuccessWithdraw");
            }
            return View("Error");
        }
        // GET: Applications/OfferInterview
        [HttpGet]
        [Authorize(Roles = "Recruiter")]
        public IActionResult OfferInterviewForApp(int ? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Application application = _context.Applications.Include(a=>a.AppUser).Include(a => a.Position).ThenInclude(p=>p.Company).FirstOrDefault(u => u.ApplicationID == id);

            List<Position> Positions = _context.Positions.Where(p => p.Applications.Any(a => a.ApplicationID == id)).ToList();
            SelectList AllPositions = new SelectList(Positions.OrderBy(m => m.PositionID), "PositionID", "PositionTitle");
            ViewBag.AllPositions = AllPositions;

            return View(application);

        }

        // POST: Applications/OfferInterview
        [HttpPost]
        [Authorize(Roles = "Recruiter")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OfferInterviewForApp([Bind("ApplicationID,StatusType,ApplicationDate,Position,AppUser,Active")]Application application, int selectedPosition)
        {
            if (application == null)
            {
                return NotFound();
            }
            Application dbApp = _context.Applications.Include(a => a.Position).ThenInclude(p=>p.Company).Include(a=>a.AppUser).FirstOrDefault(p => p.ApplicationID == application.ApplicationID);
            //application.Position = _context.Positions.Find(selectedPosition);
            dbApp.StatusType = "Accepted";
            AppUser student = dbApp.AppUser;
            String studentEmail = student.Email;
            String studentName = student.FullName;
            String message = "You have an interview offer from " + dbApp.Position.Company.CompanyName+ " for " +dbApp.Position.PositionTitle+". Please check the website for details.";
            String subject = "Interview Offer";
            //ModelState.Clear();
            //TryValidateModel(application);

            if (ModelState.IsValid)
            {
                _context.Update(dbApp);
                await _context.SaveChangesAsync();
                Utilities.EmailMessaging.SendEmail(subject, studentName, studentEmail, message);
                return View("Success");
            }

            List<Position> Positions = _context.Positions.Where(p => p.Applications.Any(a => a.ApplicationID == application.ApplicationID)).ToList();
            SelectList AllPositions = new SelectList(Positions.OrderBy(m => m.PositionID), "PositionID", "PositionTitle");
            ViewBag.AllPositions = AllPositions;
            return View("OfferInterviewforApp", application);
        }




        // GET: Applications/OfferInterview
        [HttpGet]
        [Authorize(Roles = "Recruiter")]
        public IActionResult OfferInterview(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            AppUser student = _context.Users.FirstOrDefault(u => u.Id ==id);
            AppUser recruiter = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            ViewBag.AllPositions = GetAllPositions(recruiter.UserName);
            return View(student);
        }
        // POST: Applications/OfferInterview
        [HttpPost]
        [Authorize(Roles = "Recruiter")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OfferInterview(AppUser student, int SelectedPosition)
        {
            if (student == null)
            {
                return NotFound();
            }

            AppUser stu = _context.Users.Find(student.Id);
            var application = await _context.Applications.FirstOrDefaultAsync(a=> a.AppUser.Id == stu.Id && a.Position.PositionID== SelectedPosition);
            if ( application != null)
            {
                String studentEmail = application.AppUser.Email;
                String studentName = application.AppUser.FullName;
                String message = "You have an interview offer. Please check the website for details.";
                string subject = "Interview Offer";
                application.StatusType = "Accepted";
                application.Active = true;
                

                if (ModelState.IsValid)
                {
                    _context.Update(application);
                    await _context.SaveChangesAsync();
                    Utilities.EmailMessaging.SendEmail(subject, studentName, studentEmail, message);
                    return View("Success");
                }
            }

            else
            {
                Application app = new Application();
                app.StatusType = "Accepted";
                app.ApplicationDate = Utilities.Time.SystemTime;
                Position po = _context.Positions.Find(SelectedPosition);
                app.Position = po;
                //AppUser student = _context.Users.FirstOrDefault(u => u.Id==userid);
                app.AppUser = stu;
                app.Active = true;
                String studentEmail = app.AppUser.Email;
                String studentName = app.AppUser.FullName;
                String message = "You have an interview offer. Please check the website for details.";
                string subject = "Interview Offer";
              
                //application.AppUser = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

                if (ModelState.IsValid)
                {
                    _context.Add(app);
                    await _context.SaveChangesAsync();
                    Utilities.EmailMessaging.SendEmail(subject, studentName, studentEmail, message);
                    return View("Success");
                } 
                
            }
            AppUser recruiter = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            ViewBag.AllPositions = GetAllPositions(recruiter.UserName);
            return View("OfferInterview", stu);
        }
        [Authorize(Roles = "Recruiter")]
        public async Task<IActionResult> Decline(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Application app = _context.Applications.Include(a => a.AppUser).Include(a => a.Position).FirstOrDefault(a => a.ApplicationID == id);
            if (app == null)
            {
                return NotFound();
            }
            app.StatusType = "Declined";
            if (ModelState.IsValid)
            {
                _context.Update(app);
                await _context.SaveChangesAsync();
                return View("Success");
            }
            return View("Error");
        }

        public SelectList GetAllPositions(String username)
        {
            //AppUser interviewer = _context.AppUsers.Find(id);
            List<Position> Positions = _context.Positions.Where(po => po.Company.AppUsers.Any(a => a.UserName == username)).ToList();

            SelectList AllPositions = new SelectList(Positions.OrderBy(m => m.PositionID), "PositionID", "PositionTitle");

            //return the select list
            return AllPositions;
        }
        private bool ApplicationExists(int id)
        {
            return _context.Applications.Any(e => e.ApplicationID == id);
        }
    }
}
