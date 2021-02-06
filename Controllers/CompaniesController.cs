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

namespace hirelonghorn.Controllers
{
    [Authorize]

    public class CompaniesController : Controller
    {
        private readonly AppDbContext _context;

        public CompaniesController(AppDbContext context)
        {
            _context = context;
        }

        
        // GET: Companies
        public IActionResult Index()
        {
            if (User.IsInRole("Student") || User.IsInRole("CSO"))
            {
                ViewBag.AllCompanyCount = _context.Companies.Count();
                ViewBag.SelectedCompanyCount = _context.Companies.Count();
                List<Company> Companies = _context.Companies.Include(c => c.Positions).ToList();
                return View(Companies);
            }

            else
            {
                AppUser recruiter = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
                List<Company> Companies = _context.Companies.Where(c => c.AppUsers.Any(a => a.Id == recruiter.Id)).Include(c => c.Positions).ToList();
                return View(Companies);
            }
        }

        // GET: Companies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies
                .Include(c => c.Positions)
                .FirstOrDefaultAsync(m => m.CompanyID == id);
            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }

        // GET: Companies/Create
        [Authorize(Roles = "CSO")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Companies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "CSO")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyID,CompanyName,CompanyEmail,Description,Industry")] Company company)
        {
            if (ModelState.IsValid)
            {
                _context.Add(company);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(company);
        }


        // GET: Companies/Edit/5
        [Authorize(Roles = "CSO, Recruiter")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }

        // POST: Companies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "CSO, Recruiter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CompanyID,CompanyName,CompanyEmail,Description,Industry")] Company company)
        {
            if (id != company.CompanyID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(company);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyExists(company.CompanyID))
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
            return View(company);
        }
        /*
        // GET: Companies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies
                .FirstOrDefaultAsync(m => m.CompanyID == id);
            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }

        // POST: Companies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var company = await _context.Companies.FindAsync(id);
            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        */

        [Authorize(Roles = "CSO, Student")]
        public IActionResult CompanySearch()
        {
            return View("CompanySearch");
        }

        [Authorize(Roles = "CSO, Student")]
        public ActionResult DisplayCompanyResults(String CompanyName, String Location, Classification SelectedPosition, String Industry)
        {
            var query = from c in _context.Companies
                        select c;

            if (CompanyName != null && CompanyName != "")
            {
                query = query.Where(c => c.CompanyName.Contains(CompanyName));
            }
            
            if (Location != null && Location != "")
            {
                query = query.Where(c => c.Positions.Any(p=> p.Location.Contains(Location)));
            }
            
            switch (SelectedPosition)
            {
                case Classification.FT:
                    query = query.Where(c => c.Positions.Any(p => p.PositionType == "FT"));
                    break;

                case Classification.I:
                    query = query.Where(c => c.Positions.Any(p => p.PositionType == "I"));
                    break;

                default:
                    query = query.Where(c => c.Positions.Any(p => p.PositionType == "I" )||c.Positions.Any(p => p.PositionType == "FT")); 
                    break;

            }
            
            if (Industry != null && Industry != "")
            {
                query = query.Where(c => c.Industry.Contains(Industry));
            }
            List<Company> SelectedCompany = query.Include(p => p.Positions).ToList();
            ViewBag.AllCompanyCount = _context.Companies.Count();
            ViewBag.SelectedCompanyCount = SelectedCompany.Count();
            return View("Index", SelectedCompany);
        }
        
        private bool CompanyExists(int id)
        {
            return _context.Companies.Any(e => e.CompanyID == id);
        }
    }
}
