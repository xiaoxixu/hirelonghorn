using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hirelonghorn.DAL;
using hirelonghorn.Seeding;

namespace hirelonghorn.Controllers
{
    public class SeedController : Controller
    {

        private AppDbContext _db;

        //public object Seeding { get; private set; }

        public SeedController(AppDbContext context)
        {
            _db = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SeedCompanies()
        {
            try
            {
                Seeding.SeedCompanies.SeedAllCompanies(_db);
            }
            catch (NotSupportedException ex)
            {
                return View("Error", new String[] { "The company have already been added", ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", new String[] { "There was an error adding companies to the database", ex.Message });
            }

            return View("Confirm");
        }

        public IActionResult SeedMajors()
        {
            try
            {
                Seeding.SeedMajors.SeedAllMajors(_db);
            }
            catch (NotSupportedException ex)
            {
                return View("Error", new String[] { "The majors have already been added", ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", new String[] { "There was an error adding majors to the database", ex.Message });
            }

            return View("Confirm");
        }

        public IActionResult Seed()
        {
            try
            {
                Seeding.SeedMajors.SeedAllMajors(_db);
            }
            catch (NotSupportedException ex)
            {
                return View("Error", new String[] { "The majors have already been added", ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", new String[] { "There was an error adding majors to the database", ex.Message });
            }

            return View("Confirm");
        }

        /*public IActionResult SeedAppUsers()
        {
            try
            {
                Seeding.SeedAppUsers.SeedAllAppUsers(_db);
            }
            catch (NotSupportedException ex)
            {
                return View("Error", new String[] { "The app users have already been added", ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", new String[] { "There was an error adding app users to the database", ex.Message });
            }

            return View("Confirm");
        }
        */
        public IActionResult SeedPositions()
        {
            try
            {
                Seeding.SeedPositions.SeedAllPositions(_db);
            }
            catch (NotSupportedException ex)
            {
                return View("Error", new String[] { "The positions have already been added", ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", new String[] { "There was an error adding positions to the database", ex.Message });
            }

            return View("Confirm");
        }

        public IActionResult SeedInterviews()
        {
            try
            {
                Seeding.SeedInterview.SeedAllInterviews(_db);
            }
            catch (NotSupportedException ex)
            {
                return View("Error", new String[] { "The positions have already been added", ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return View("Error", new String[] { "There was an error adding positions to the database", ex.Message });
            }

            return View("Confirm");
        }

    } 
}