using System.Data.SqlTypes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sp19team18finalproject.DAL;
using sp19team18finalproject.Models;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System;
using System.Linq;
using sp19team18finalproject.Utilities;
using MimeKit;

namespace sp19team18finalproject.Controllers
{

    public class InterviewsController : Controller

    {
        private readonly AppDbContext _context;

        public InterviewsController(AppDbContext context)
        {
            _context = context;
        }


        // GET: Interviews
        [Authorize]
        public IActionResult Index()
        {
            if (User.IsInRole("CSO"))
            {
                List<Interview> interviews = _context.Interviews.Include(i=>i.Interviewer).ThenInclude(c=>c.Company).Include(i=>i.Position).ThenInclude(c=>c.Company).
                    Where(i => i.Interviewer != null && i.Interviewee != null).ToList();
                return View(interviews);
            }
            else if (User.IsInRole("Recruiter"))
            {
                List<Interview> interviews = _context.Interviews.Include(i => i.Interviewer).ThenInclude(c => c.Company).Include(i => i.Position).ThenInclude(c => c.Company)
                    .Where(i => i.Position.Company.AppUsers.Any(a=>a.UserName == User.Identity.Name) && i.Interviewee!= null).ToList();
                
                return View(interviews);
            }
            else if (User.IsInRole("Student"))
            {
                List<Interview> interviews = _context.Interviews.Include(i => i.Interviewer).ThenInclude(c => c.Company).Include(i => i.Position).ThenInclude(c => c.Company).
                    Where(i => i.Interviewee.UserName == User.Identity.Name).ToList();
                return View(interviews);
            }
            else
            {
                return View("Error", new string[] { "Access is denied" });
            }

        }

        // GET: Unbooked Interviews
        [Authorize]
        public IActionResult Unbooked()
        {
            if (User.IsInRole("CSO"))
            {
                List<Interview> interviews = _context.Interviews.Include(i => i.Interviewer).ThenInclude(c => c.Company).Include(i => i.Position).ThenInclude(c => c.Company)
                    .Where(i => i.Interviewer != null && i.Interviewee == null).ToList();
                return View( interviews);
            }
            else if (User.IsInRole("Recruiter"))
            {
                List<AppUser> colleges = _context.Users.Where(u => u.Company.AppUsers.Any(a => a.UserName == User.Identity.Name)).ToList();
                List<Interview> interviews = _context.Interviews.Include(i => i.Interviewer).ThenInclude(c => c.Company).Include(i => i.Position).ThenInclude(c => c.Company).
                    Where(i=>i.Interviewee == null && colleges.Contains(i.Interviewer)).ToList();
                return View( interviews);
            }
            else 
            {
                
                List<DateTime> existDateTime = new List<DateTime>();
                List<Position> existPosition = new List<Position>();
                List<Interview> allMyInterviews = _context.Interviews.Where(i => i.Interviewee.UserName == User.Identity.Name).ToList();
                foreach( Interview i in allMyInterviews)
                {
                    existDateTime.Add(i.InterviewTime);
                    existPosition.Add(i.Position);
                }
                List<Interview> interviews = _context.Interviews.Include(i => i.Interviewer).ThenInclude(c => c.Company).Include(i => i.Position).ThenInclude(c => c.Company).
                    Where(i => i.Position.Applications.Any(a => a.AppUser.UserName == User.Identity.Name && a.StatusType == "Accepted") && !existPosition.Contains(i.Position) &&  !existDateTime.Contains(i.InterviewTime)).ToList();
                return View( interviews);
            }
        }

        [Authorize(Roles ="Student")]
        public async Task<IActionResult> AcceptInterview(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            

            var interview = await _context.Interviews.Include(i => i.Interviewee).Include(i => i.Interviewer).Include(i => i.Position)
                .FirstOrDefaultAsync(m => m.InterviewId == id);

            
            if (interview == null)
            {
                return NotFound();
            }
            if (interview.InterviewTime.Date <= Utilities.Time.SystemTime.Date)
            {
                return View("Error");
            }

            AppUser interviewee = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

            interview.Interviewee = interviewee;

            String intervieweeEmail = interviewee.Email;
            String intervieweeName = interviewee.FullName;
            String message = "Your interview slot has been confirmed."+" Details:"+interview.InterviewTime.ToString()+interview.RoomNumber+interview.Position.PositionTitle+interview.Interviewer.FullName+" Please check the website for details.";
            string subject = "Interview Confirmation";

            if (ModelState.IsValid)
            {
                _context.Update(interview);
                await _context.SaveChangesAsync();
                List<Interview> interviews = _context.Interviews.Include(i => i.Interviewer).ThenInclude(c => c.Company).Include(i => i.Position).ThenInclude(c => c.Company).
                    Where(i => i.Interviewee.UserName == User.Identity.Name).ToList();
                Utilities.EmailMessaging.SendEmail(subject,intervieweeName, intervieweeEmail, message);
                return View("Index", interviews);

            }

            else
            {
                return View("Error", new string[] { "Access is denied" });
            }
        }


        [Authorize(Roles = "Student")]
        public async Task<IActionResult> CancelInterview(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interview = await _context.Interviews.Include(i => i.Interviewee).Include(i => i.Interviewer).Include(i => i.Position)
                .FirstOrDefaultAsync(m => m.InterviewId == id);
            if (interview == null)
            {
                return NotFound();
            }
            if (interview.InterviewTime.Date <= Utilities.Time.SystemTime.Date)
            {
                return View("Error");
            }
            interview.Interviewee = null;

            if (ModelState.IsValid)
            {
                _context.Update(interview);
                await _context.SaveChangesAsync();
                //List<Interview> interviews = _context.Interviews.Include(i => i.Position).ThenInclude(c => c.Company).
                //  Where(i => i.Position.Applications.Any(a => a.AppUser.UserName == User.Identity.Name && a.StatusType == "Accepted")).ToList();
                List<Interview> interviews = _context.Interviews.Include(i => i.Position).ThenInclude(c => c.Company).
                    Where(i => i.Position.Applications.Any(a => a.AppUser.UserName == User.Identity.Name && a.StatusType == "Accepted") && i.Interviewee == null).ToList();
                return View("Unbooked", interviews);
            }

            else
            {
                return View("Error", new string[] { "Access is denied" });
            }
        }


        // GET: Interviews/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interview = await _context.Interviews.Include(i => i.Interviewee).Include(i => i.Interviewer).Include(i => i.Position)
                .FirstOrDefaultAsync(m => m.InterviewId == id);
            if (interview == null)
            {
                return NotFound();
            }
            Interview interview1 = _context.Interviews.FirstOrDefault(i => i.Position.Applications.Any(a => a.AppUser.UserName == User.Identity.Name && a.StatusType == "Accepted"));
            List<AppUser> colleges = _context.Users.Where(u => u.Company.AppUsers.Any(a => a.UserName == User.Identity.Name)).ToList();
            if (User.IsInRole("CSO") || interview1!=null || colleges.Contains(interview.Interviewer))
            {
                return View(interview);
            }
            else
            {
                return View("Error", new string[] { "You are not authorized to edit this interview!" });
            }
        }
        [Authorize(Roles = ("Recruiter, CSO"))]
        public IActionResult SelectDate()
        {
            return View();
        }
        public IActionResult SelectRoom(DateTime SelectedStartingDate)
        {
            DateTime defaultDT = new DateTime();
            if (SelectedStartingDate == defaultDT)
            {
                return RedirectToAction("SelectDate");
            }


            if (SelectedStartingDate.DayOfWeek == DayOfWeek.Saturday || SelectedStartingDate.DayOfWeek == DayOfWeek.Sunday)
            {
                return RedirectToAction("SelectDate");
            }

            
            String strSelectedStartingDate = SelectedStartingDate.ToString("MM/dd/yyyy");
            List<SelectListItem> Room1 = FindAvailable_Room1(SelectedStartingDate);
            List<SelectListItem> Room2 = FindAvailable_Room2(SelectedStartingDate);
            List<SelectListItem> Room3 = FindAvailable_Room3(SelectedStartingDate);
            List<SelectListItem> Room4 = FindAvailable_Room4(SelectedStartingDate);
            List<SelectListItem> Display = new List<SelectListItem>();
            if (Room1.Count()!=0)
            {

                var item = new SelectListItem
                {
                    Value = "Room1",
                    Text = "Room1"

                };
                Display.Add(item);

            };
            if (Room2.Count() != 0)
            {

                var item = new SelectListItem
                {
                    Value = "Room2",
                    Text = "Room2"

                };
                Display.Add(item);

            };
            if (Room3.Count() != 0)
            {

                var item = new SelectListItem
                {
                    Value = "Room3",
                    Text = "Room3"

                };
                Display.Add(item);

            };
            if (Room4.Count() != 0)
            {

                var item = new SelectListItem
                {
                    Value = "Room4",
                    Text = "Room4"

                };
                Display.Add(item);

            };
            SelectList AllRooms = new SelectList(Display, "Value", "Text");
            ViewBag.AllRooms = AllRooms;
            List<SelectListItem> Date = new List<SelectListItem>();
            var selectedDate = new SelectListItem
            {
                Value = strSelectedStartingDate,
                Text = strSelectedStartingDate
            };
            Date.Add(selectedDate);
            SelectList SelectedDate = new SelectList(Date, "Value", "Text");
            ViewBag.SelectedDate = SelectedDate;
            return View();



        }
        public IActionResult SelectCompany(string SelectedDate2, String SelectedRoom1)
        {

            if (User.IsInRole("Recruiter"))
            {
                List<Company> company = _context.Companies.Where(c => c.AppUsers.Any(a => a.UserName == User.Identity.Name)).ToList();
                SelectList AllCompanies = new SelectList(company, "CompanyID", "CompanyName");
                ViewBag.AllCompanies = AllCompanies;
            }
            else
            {
                SelectList AllCompanies = GetAllCompanies();
                ViewBag.AllCompanies = AllCompanies;
            }
            List<SelectListItem> Date = new List<SelectListItem>();
            var d = new SelectListItem
            {
                Value = SelectedDate2,
                Text = SelectedDate2
            };
            Date.Add(d);
            SelectList SelectedDate = new SelectList(Date, "Value", "Text");
            ViewBag.SelectedDate = SelectedDate;
            List<SelectListItem> Room = new List<SelectListItem>();
            var r = new SelectListItem
            {
                Value = SelectedRoom1,
                Text = SelectedRoom1
            };
            Room.Add(r);
            SelectList SelectedRoom = new SelectList(Room, "Value", "Text");
            ViewBag.SelectedRoom = SelectedRoom;
            return View();
        }
        /*private class Time
        {
            int Id { get; set; }
            string Name { get; set; }
        }*/

        // GET: Interviews/Create
        [Authorize(Roles = ("Recruiter, CSO"))]
        public IActionResult Create(string SelectedDate2, String SelectedRoom1, int SelectedCompany3)
        {
            DateTime dateSelectedDate = DateTime.Parse(SelectedDate2);
            Interview interv = new Interview();
            if(SelectedRoom1 == "Room1")
            {
                ViewBag.AllSlots = new MultiSelectList(FindAvailable_Room1(dateSelectedDate), "Value", "Text");
                //String RoomText = "Room1";
            }
            else if (SelectedRoom1 == "Room2")
            {
                ViewBag.AllSlots = new MultiSelectList(FindAvailable_Room2(dateSelectedDate), "Value", "Text");
                //String RoomText = "Room2";
            }
            else if (SelectedRoom1 == "Room3")
            {
                ViewBag.AllSlots = new MultiSelectList(FindAvailable_Room3(dateSelectedDate), "Value", "Text");
                //String RoomText = "Room3";
            }
            else if (SelectedRoom1 == "Room4")
            {
                ViewBag.AllSlots = new MultiSelectList(FindAvailable_Room4(dateSelectedDate), "Value", "Text");
                //String RoomText = "Room4";
            }

            List<SelectListItem> Date = new List<SelectListItem>();
            var d = new SelectListItem
            {
                Value = SelectedDate2,
                Text = SelectedDate2
            };
            Date.Add(d);
            SelectList SelectedDate = new SelectList(Date, "Value", "Text");
            ViewBag.SelectedDate = SelectedDate;
            List<SelectListItem> Room = new List<SelectListItem>();
            var r = new SelectListItem
            {
                Value = SelectedRoom1,
                Text = SelectedRoom1
        };
            Room.Add(r);
            SelectList SelectedRoom = new SelectList(Room, "Value", "Text");
            ViewBag.SelectedRoom = SelectedRoom;
            //AppUser Scheduler = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            ViewBag.AllPositions = GetAllPositions(SelectedCompany3);
            ViewBag.AllInterviewers = GetAllInterviewers(SelectedCompany3);

            interv.RoomNumber = SelectedRoom1;

            return View(interv);
        }


        // POST: Interviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InterviewId,RoomNumber,InterviewTime, Position")] Interview interview, int SelectedPosition, String SelectedInterviewer, String SelectedDate2, String SelectedRoom, int[] SelectedSlots)
        {
            interview.Position = _context.Positions.Find(SelectedPosition);
            interview.Interviewer = _context.Users.FirstOrDefault(a => a.UserName == SelectedInterviewer);
            //DateTime dateSelectedDate = DateTime.Parse(SelectedDate);
            //interview.RoomNumber = SelectedRoom;
            var newInterviews = new List<Interview>();
            
            int Count = 0;
            try
            {
                foreach (int i in SelectedSlots)
                {
                    newInterviews.Add(new Interview());
                    newInterviews[Count].Interviewer = interview.Interviewer;
                    newInterviews[Count].Position = interview.Position;
                    newInterviews[Count].RoomNumber = interview.RoomNumber;

                    string TimeString = i.ToString() + ":00";
                    if (i == 8 || i == 9 || i == 10 || i == 11)
                    {
                        TimeString = TimeString + "AM";
                    }
                    else
                    {
                        TimeString = TimeString + "PM";
                    }

                    String strdatetime = SelectedDate2 + " " + TimeString;
                    DateTime dateSelectedDate = DateTime.Parse(strdatetime);
                    if(newInterviews[Count].Position != null)
                    {
                        if (dateSelectedDate.Date < newInterviews[Count].Position.Deadline.Date.AddDays(2))
                        {
                            return View("No48");
                        }
                    }
                    
                    
                    /*
                    if ((dateSelectedDate - newInterviews[Count].Position.Deadline).Hours < 48)
                    {
                        return View("No48");
                    }
                    */
                    newInterviews[Count].InterviewTime = dateSelectedDate;

                    //var conflictInterview = await _context.Interviews.FirstOrDefaultAsync(i => i.InterviewTime== dateSelectedDate && i.Interviewer.UserName==User.Identity.Name);

                    if (ModelState.IsValid)
                    {
                        _context.Add(newInterviews[Count]);
                        await _context.SaveChangesAsync();

                    }

                    Count = Count + 1;
                }
                return RedirectToAction("Unbooked");
            }
            catch
            {
                return View("Error");
            }
            

            
        }
        

        private bool InterviewExists(int id)
        {
            return _context.Interviews.Any(e => e.InterviewId == id);
        }
        private SelectList GetAllCompanies()
        {
            List<Company> companies = _context.Companies.ToList();
            Company SelectNone = new Company() { CompanyID = 0, CompanyName = "CSO use" };
            companies.Add(SelectNone);
            SelectList AllCompanies = new SelectList(companies, "CompanyID", "CompanyName");
            return AllCompanies;
        }
        public SelectList GetAllInterviewers(int Company)
        {
            List<AppUser> Colleagues = _context.Users.Where(u => u.Company.CompanyID==Company).ToList();
            SelectList AllColleauges = new SelectList(Colleagues, "UserName", "LastName");
            return AllColleauges;
        }
        public SelectList GetAllPositions(int Company)
        {
            //AppUser interviewer = _context.AppUsers.Find(id);
            List<Position> positions = _context.Positions.Where(po => po.Company.CompanyID == Company).ToList();
            Position SelectNone = new Position() { PositionID = 0, PositionTitle = "Block Out" };
            positions.Add(SelectNone);
            SelectList AllPositions = new SelectList(positions.OrderBy(m => m.PositionID), "PositionID", "PositionTitle");

            //return the select list
            return AllPositions;
        }
        public static IEnumerable<SelectListItem> GetAllSlots()
        {

            List<SelectListItem> Times = new List<SelectListItem>()
            {
                    new SelectListItem {Text="8:00 AM", Value="8:00 AM"},
                    new SelectListItem {Text="9:00 AM", Value="9:00 AM"},
                    new SelectListItem {Text="10:00 AM", Value="10:00 AM"},
                    new SelectListItem {Text="11:00 AM", Value="11:00 AM"},
                    new SelectListItem {Text="1:00 PM", Value="1:00 PM"},
                    new SelectListItem {Text="2:00 PM", Value="2:00 PM"},
                    new SelectListItem {Text="3:00 PM", Value="3:00 PM"},
                    new SelectListItem {Text="4:00 PM", Value="4:00 PM"},
                    new SelectListItem {Text="5:00 PM", Value="5:00 PM"},

                };
            return Times;
        }
        private List<SelectListItem> FindAvailable_Room1(DateTime SelectedDate)
        {
            List<int> Exist = new List<int>();
            Exist.Add(8);
            Exist.Add(9);
            Exist.Add(10);
            Exist.Add(11);
            Exist.Add(13);
            Exist.Add(14);
            Exist.Add(15);
            Exist.Add(16);

            List<int> Taken = new List<int>();
            List<Interview> InterviewTaken = _context.Interviews.Where(i => i.InterviewTime.Date == SelectedDate && i.RoomNumber == "Room1").ToList();
            foreach (Interview interview in InterviewTaken)
            {
                Taken.Add(interview.InterviewTime.Hour);
            }

            List<int> AvailableRaw = new List<int>();
            foreach (int i in Exist)
            {
                if (!Taken.Contains(i))
                {
                    AvailableRaw.Add(i);
                };

            }

            List<String> TimeText = new List<String>();
            foreach (int i in AvailableRaw)
            {

                if (i == 8 || i == 9 || i == 10 || i == 11)
                {
                    string TimeString = i.ToString() + ":00";
                    TimeString = TimeString + "AM";
                    TimeText.Add(TimeString);
                }
                else
                {
                    int i_regular = i - 12;
                    string TimeString = i_regular.ToString() + ":00";
                    TimeString = TimeString + "PM";
                    TimeText.Add(TimeString);
                }
            }


            //var Times = new List<Time>();

            List<SelectListItem> Times = new List<SelectListItem>();
            int LenTimeText = TimeText.Count();
            int LenAvailableRaw = AvailableRaw.Count();
            for (int i = 0; i < LenTimeText; i++)
            {

                var item = new SelectListItem
                {
                    Value = AvailableRaw[i].ToString(),
                    Text = TimeText[i]

                };
                Times.Add(item);

            };
            return Times;

        }
        private List<SelectListItem> FindAvailable_Room2(DateTime SelectedDate)
        {
            List<int> Exist = new List<int>();
            Exist.Add(8);
            Exist.Add(9);
            Exist.Add(10);
            Exist.Add(11);
            Exist.Add(13);
            Exist.Add(14);
            Exist.Add(15);
            Exist.Add(16);

            List<int> Taken = new List<int>();
            List<Interview> InterviewTaken = _context.Interviews.Where(i => i.InterviewTime.Date == SelectedDate && i.RoomNumber == "Room2").ToList();
            foreach (Interview interview in InterviewTaken)
            {
                Taken.Add(interview.InterviewTime.Hour);
            }

            List<int> AvailableRaw = new List<int>();
            foreach (int i in Exist)
            {
                if (!Taken.Contains(i))
                {
                    AvailableRaw.Add(i);
                };

            }

            List<String> TimeText = new List<String>();
            foreach (int i in AvailableRaw)
            {

                if (i == 8 || i == 9 || i == 10 || i == 11)
                {
                    string TimeString = i.ToString() + ":00";
                    TimeString = TimeString + "AM";
                    TimeText.Add(TimeString);
                }
                else
                {
                    int i_regular = i - 12;
                    string TimeString = i_regular.ToString() + ":00";
                    TimeString = TimeString + "PM";
                    TimeText.Add(TimeString);
                }
            }


            //var Times = new List<Time>();

            List<SelectListItem> Times = new List<SelectListItem>();
            int LenTimeText = TimeText.Count();
            int LenAvailableRaw = AvailableRaw.Count();
            for (int i = 0; i < LenTimeText; i++)
            {

                var item = new SelectListItem
                {
                    Value = AvailableRaw[i].ToString(),
                    Text = TimeText[i]

                };
                Times.Add(item);

            };
            return Times;

        }
        private List<SelectListItem> FindAvailable_Room3(DateTime SelectedDate)
        {
            List<int> Exist = new List<int>();
            Exist.Add(8);
            Exist.Add(9);
            Exist.Add(10);
            Exist.Add(11);
            Exist.Add(13);
            Exist.Add(14);
            Exist.Add(15);
            Exist.Add(16);

            List<int> Taken = new List<int>();
            List<Interview> InterviewTaken = _context.Interviews.Where(i => i.InterviewTime.Date == SelectedDate && i.RoomNumber == "Room3").ToList();
            foreach (Interview interview in InterviewTaken)
            {
                Taken.Add(interview.InterviewTime.Hour);
            }

            List<int> AvailableRaw = new List<int>();
            foreach (int i in Exist)
            {
                if (!Taken.Contains(i))
                {
                    AvailableRaw.Add(i);
                };

            }

            List<String> TimeText = new List<String>();
            foreach (int i in AvailableRaw)
            {

                if (i == 8 || i == 9 || i == 10 || i == 11)
                {
                    string TimeString = i.ToString() + ":00";
                    TimeString = TimeString + "AM";
                    TimeText.Add(TimeString);
                }
                else
                {
                    int i_regular = i - 12;
                    string TimeString = i_regular.ToString() + ":00";
                    TimeString = TimeString + "PM";
                    TimeText.Add(TimeString);
                }
            }


            //var Times = new List<Time>();

            List<SelectListItem> Times = new List<SelectListItem>();
            int LenTimeText = TimeText.Count();
            int LenAvailableRaw = AvailableRaw.Count();
            for (int i = 0; i < LenTimeText; i++)
            {

                var item = new SelectListItem
                {
                    Value = AvailableRaw[i].ToString(),
                    Text = TimeText[i]

                };
                Times.Add(item);

            };
            return Times;

        }
        private List<SelectListItem> FindAvailable_Room4(DateTime SelectedDate)
        {
            List<int> Exist = new List<int>();
            Exist.Add(8);
            Exist.Add(9);
            Exist.Add(10);
            Exist.Add(11);
            Exist.Add(13);
            Exist.Add(14);
            Exist.Add(15);
            Exist.Add(16);

            List<int> Taken = new List<int>();
            List<Interview> InterviewTaken = _context.Interviews.Where(i => i.InterviewTime.Date == SelectedDate && i.RoomNumber == "Room4").ToList();
            foreach (Interview interview in InterviewTaken)
            {
                Taken.Add(interview.InterviewTime.Hour);
            }

            List<int> AvailableRaw = new List<int>();
            foreach (int i in Exist)
            {
                if (!Taken.Contains(i))
                {
                    AvailableRaw.Add(i);
                };

            }

            List<String> TimeText = new List<String>();
            foreach (int i in AvailableRaw)
            {

                if (i == 8 || i == 9 || i == 10 || i == 11)
                {
                    string TimeString = i.ToString() + ":00";
                    TimeString = TimeString + "AM";
                    TimeText.Add(TimeString);
                }
                else
                {
                    int i_regular = i - 12;
                    string TimeString = i_regular.ToString() + ":00";
                    TimeString = TimeString + "PM";
                    TimeText.Add(TimeString);
                }
            }


            //var Times = new List<Time>();

            List<SelectListItem> Times = new List<SelectListItem>();
            int LenTimeText = TimeText.Count();
            int LenAvailableRaw = AvailableRaw.Count();
            for (int i = 0; i < LenTimeText; i++)
            {

                var item = new SelectListItem
                {
                    Value = AvailableRaw[i].ToString(),
                    Text = TimeText[i]

                };
                Times.Add(item);

            };
            return Times;

        }


    }
}