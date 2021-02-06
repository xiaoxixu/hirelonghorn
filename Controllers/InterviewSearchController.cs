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
    [Authorize(Roles = "CSO")]

    public class InterviewSearchController : Controller
    {
        private AppDbContext _db;


        public InterviewSearchController(AppDbContext context)
        {
            _db = context;
        }
      
        public IActionResult Index()
        {
            List<Interview> SelectedInterviews = _db.Interviews.Include(i =>i.Position)
                .ThenInclude(p => p.Company).ToList();
            ViewBag.AllInterviewCount = _db.Interviews.Count();
            ViewBag.SelectedInterviewCount = _db.Interviews.Count();
            return View(SelectedInterviews);
        }

        public ActionResult InterviewSearch()
        {
            List<SelectListItem> Rooms = new List<SelectListItem>()
            {
                new SelectListItem{Text = "AllRooms", Value = "AllRooms"},
                new SelectListItem{Text = "Room1", Value = "Room1"},
                new SelectListItem{Text = "Room2", Value = "Room2"},
                new SelectListItem{Text = "Room3", Value = "Room3"},
                new SelectListItem{Text = "Room4", Value = "Room4"}
        };

            ViewBag.AllRooms = new SelectList(Rooms, "Value", "Text");
            ViewBag.AllCompanies = GetAllCompanies();
            return View("InterviewSearch");
        }

        public ActionResult DisplayInterviewSearchResults(DateTime? InterviewDate, String SelectedRoomNumber, int SelectedInterviewCompany)
        {
                var query = from s in _db.Interviews.Include(i => i.Position).ThenInclude(p => p.Company)
                            select s;
                if (InterviewDate != null)
                {
                    DateTime datSelected = InterviewDate ?? new DateTime(1900, 1, 1);
                    query = query.Where(i => i.InterviewTime.Date == InterviewDate);
                }
                if (SelectedRoomNumber != "AllRooms")
                {
                    query = query.Where(i => i.RoomNumber == SelectedRoomNumber);
                }
                if (SelectedInterviewCompany != 0)
                {
                    query = query.Where(i => i.Position.Company.CompanyID == SelectedInterviewCompany);
                }

                List<Interview> SelectedInterviews = query.Include(c => c.Position).ThenInclude(p => p.Company).ToList();
                ViewBag.AllInterviewCount = _db.Interviews.Count();
                ViewBag.SelectedInterviewCount = SelectedInterviews.Count();
                return View("Index", SelectedInterviews);
        }

        public SelectList GetAllCompanies()
        {
            List<Company> Companies = _db.Companies.ToList();
            Company SelectNone = new Company() { CompanyID = 0, CompanyEmail = "All Companies" };
            Companies.Add(SelectNone);
            SelectList AllCompanies = new SelectList(Companies.OrderBy(m => m.CompanyID), "CompanyID", "CompanyName");

            //return the select list
            return AllCompanies;
        }



    }
}
