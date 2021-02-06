using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using hirelonghorn.DAL;
using hirelonghorn.Models;

namespace hirelonghorn.Controllers
{
    [Authorize]
    public class CSOsController : Controller
    {
        private readonly AppDbContext _context;

        public CSOsController(AppDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "CSO")]
        public IActionResult Index()
        {
            List<AppUser> CSOs = _context.Users.Where(c => c.Company == null && c.Major == null).ToList();
            return View(CSOs);
        }
    }
}