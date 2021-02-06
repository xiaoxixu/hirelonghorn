using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sp19team18finalproject.DAL;
using sp19team18finalproject.Models;

namespace sp19team18finalproject.Controllers
{
    [Authorize(Roles = "CSO")]
    public class RecruitersController : Controller
    {
        private readonly AppDbContext _context;

        public RecruitersController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            List<AppUser> recruiters = _context.Users.Where(r => r.Company != null).Include(r => r.Company).ToList();
            return View(recruiters);
        }
    }
}