using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hirelonghorn.Utilities;

namespace hirelonghorn.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Utilities.Time.SystemTime = DateTime.Now;
            return View();
        }

        public ActionResult GoToSetTime()
        {
            return View();
        }

        public ActionResult SetTime(DateTime datSelectedDate)
        {
            if (datSelectedDate != null)
            {
                //DateTime datSelected = datSelectedDate ?? new DateTime(1900, 1, 1);
                Utilities.Time.SystemTime = datSelectedDate;
            }
      
            else
            {
                Utilities.Time.SystemTime = DateTime.Now;
            }
            return View("Index");
        }

        public ActionResult SetToNow()
        {
            Utilities.Time.SystemTime = DateTime.Now;
            return View("Index");
        }
    }
}