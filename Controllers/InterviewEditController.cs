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
using MimeKit;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sp19team18finalproject.Controllers
{
    public class InterviewEditController : Controller
    {
        private readonly AppDbContext _context;

        public InterviewEditController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> SelectDateEdit(int? id)
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
            return View(interview);
        }

        public async Task<IActionResult> SelectRoomEdit(int id, DateTime SelectedStartingDate)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var interview = await _context.Interviews.Include(i => i.Interviewee).Include(i => i.Interviewer).Include(i => i.Position)
                .FirstOrDefaultAsync(m => m.InterviewId == id);
            if (interview == null)
            {
                return NotFound();
            }
            String strSelectedStartingDate = SelectedStartingDate.ToString("MM/dd/yyyy");
            List<SelectListItem> Room1 = FindAvailable_Room1(SelectedStartingDate);
            List<SelectListItem> Room2 = FindAvailable_Room2(SelectedStartingDate);
            List<SelectListItem> Room3 = FindAvailable_Room3(SelectedStartingDate);
            List<SelectListItem> Room4 = FindAvailable_Room4(SelectedStartingDate);
            List<SelectListItem> Display = new List<SelectListItem>();
            if (Room1.Count() != 0)
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
            var d = new SelectListItem
            {
                Value = strSelectedStartingDate,
                Text = strSelectedStartingDate
            };
            Date.Add(d);
            SelectList SelectedDate = new SelectList(Date, "Value", "Text");
            ViewBag.SelectedDate = SelectedDate;
            return View(interview);

        }

        // GET: Interviews/Edit/5
        [Authorize(Roles = "Recruiter, CSO")]
        public async Task<IActionResult> Edit(int id, String SelectedRoom1, String SelectedDate2)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var interview = await _context.Interviews.Include(i => i.Interviewee).Include(i => i.Interviewer).Include(i => i.Position).ThenInclude(p=>p.Company)
                .FirstOrDefaultAsync(m => m.InterviewId == id);
            if (interview == null)
            {
                return NotFound();
            }
            if (SelectedRoom1 == "Room1")
            {
                ViewBag.AllSlots = new SelectList(FindAvailable_Room1(interview.InterviewTime), "Value", "Text");
                //String RoomText = "Room1";
            }
            else if (SelectedRoom1 == "Room2")
            {
                ViewBag.AllSlots = new SelectList(FindAvailable_Room2(interview.InterviewTime), "Value", "Text");
                //String RoomText = "Room2";
            }
            else if (SelectedRoom1 == "Room3")
            {
                ViewBag.AllSlots = new SelectList(FindAvailable_Room3(interview.InterviewTime), "Value", "Text");
                //String RoomText = "Room3";
            }
            else if (SelectedRoom1 == "Room4")
            {
                ViewBag.AllSlots = new SelectList(FindAvailable_Room4(interview.InterviewTime), "Value", "Text");
                //String RoomText = "Room4";
            }

            //String RoomText = "Room" + (SelectedRoom1+1).ToString();
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
            ViewBag.AllPositions = GetAllPositions(interview.Position.Company.CompanyID);
            ViewBag.AllInterviewers = GetAllInterviewers(interview.Position.Company.CompanyID);

            interview.RoomNumber = SelectedRoom1;

            //interview.Interviewee = _context.AppUsers.Find(3);
            return View(interview);
        }

        // POST: Interviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("InterviewId,RoomNumber,InterviewTime, Interviewer")] Interview interview, int SelectedPosition, String SelectedInterviewer, String SelectedDate2, String SelectedRoom, int SelectedSlot)
        {
            /*if (id != interview.InterviewId)
            {
                return NotFound();
            }*/
            interview.Position = _context.Positions.Find(SelectedPosition);
            interview.Interviewer = _context.Users.FirstOrDefault(a => a.UserName == SelectedInterviewer);

            string TimeString = SelectedSlot.ToString() + ":00";
            if (SelectedSlot == 8 || SelectedSlot == 9 || SelectedSlot == 10 || SelectedSlot == 11)
            {
                TimeString = TimeString + "AM";
            }
            else
            {
                TimeString = TimeString + "PM";
            }
            String strdatetime = SelectedDate2 + " " + TimeString;
            DateTime dateSelectedDate = DateTime.Parse(strdatetime);
            interview.InterviewTime = dateSelectedDate;

            if (dateSelectedDate.Date < interview.Position.Deadline.Date.AddDays(2))
            {
                return View("No48");
            }


            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(interview);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InterviewExists(interview.InterviewId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index","Interviews");
            }
            return View(interview);
        }


        private bool InterviewExists(int id)
        {
            return _context.Interviews.Any(e => e.InterviewId == id);
        }
        public SelectList GetAllInterviewers(int Company)
        {
            List<AppUser> Colleagues = _context.Users.Where(u => u.Company.CompanyID == Company).ToList();
            SelectList AllColleauges = new SelectList(Colleagues, "UserName", "LastName");
            return AllColleauges;
        }
        public SelectList GetAllPositions(int Company)
        {
            //AppUser interviewer = _context.AppUsers.Find(id);
            List<Position> Positions = _context.Positions.Where(po => po.Company.CompanyID == Company).ToList();

            SelectList AllPositions = new SelectList(Positions.OrderBy(m => m.PositionID), "PositionID", "PositionTitle");

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

