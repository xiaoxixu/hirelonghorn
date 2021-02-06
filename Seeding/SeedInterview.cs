using hirelonghorn.DAL;
using hirelonghorn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace hirelonghorn.Seeding
    {
        public class SeedInterview
        {
            public static void SeedAllInterviews(AppDbContext db)
            {
                //if (db.AppUsers.Count() == 51)
                //{
                //   throw new NotSupportedException("The database already contains all 51 AppUsers!");
                //}

                Int32 intInterviewsAdded = 0;
                Int32 intApplicationsAdded = 0;
                Int32 idInterview = 0; //helps to keep track of error on books
                Int32 idApplication = 0; //helps to keep track of error on books
                List<Interview> Interviews = new List<Interview>();
                List<Application> Applications = new List<Application>();

                try
                {
                    Interview i1 = new Interview();
                    i1.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Marketing Intern" && p.Company.CompanyName == "Adlucent");
                    i1.Interviewee = db.Users.FirstOrDefault(e => e.UserName== "feeley@penguin.org");
                    i1.Interviewer = db.Users.FirstOrDefault(r => r.UserName== "taylordjay@aool.com");
                    i1.RoomNumber = "Room2";
                    i1.InterviewTime = new DateTime(2019, 5, 13, 13, 0, 0);
                    Interviews.Add(i1);


                    Application a1 = new Application();
                    a1.AppUser = db.Users.FirstOrDefault(e => e.UserName == "feeley@penguin.org");
                    a1.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Marketing Intern" && p.Company.CompanyName == "Adlucent");
                    a1.ApplicationDate = new DateTime(1900, 1, 1);
                    a1.Active = true;
                    a1.StatusType = "Accepted";
                    Applications.Add(a1);

                    Interview i2 = new Interview();
                    i2.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Marketing Intern" && p.Company.CompanyName == "Adlucent");
                    i2.Interviewee = db.Users.FirstOrDefault(e => e.UserName== "erynrice@aoll.com");
                    i2.Interviewer = db.Users.FirstOrDefault(r => r.UserName== "taylordjay@aool.com");
                    i2.RoomNumber = "Room2";
                    i2.InterviewTime = new DateTime(2019, 5, 14, 13, 0, 0);
                    Interviews.Add(i2);

                    Application a2 = new Application();
                    a2.AppUser = db.Users.FirstOrDefault(e => e.UserName== "erynrice@aoll.com");
                    a2.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Marketing Intern" && p.Company.CompanyName == "Adlucent");
                    a2.ApplicationDate = new DateTime(1900, 1, 1);
                    a2.Active = true;
                    a2.StatusType = "Accepted";
                    Applications.Add(a2);

                    Interview i3 = new Interview();
                    i3.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Corporate Recruiting Intern" && p.Company.CompanyName == "Microsoft");
                    i3.Interviewee = db.Users.FirstOrDefault(e => e.UserName== "cmiller@bob.com");
                    i3.Interviewer = db.Users.FirstOrDefault(r => r.UserName== "louielouie@aool.com");
                    i3.RoomNumber = "Room2";
                    i3.InterviewTime = new DateTime(2019, 5, 15, 13, 0, 0);
                    Interviews.Add(i3);

                    Application a3 = new Application();
                    a3.AppUser = db.Users.FirstOrDefault(e => e.UserName=="cmiller@bob.com");
                    a3.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Corporate Recruiting Intern" && p.Company.CompanyName == "Microsoft");
                    a3.ApplicationDate = new DateTime(1900, 1, 1);
                    a3.Active = true;
                    a3.StatusType = "Accepted";
                    Applications.Add(a3);

                    Interview i4 = new Interview();
                    i4.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Account Manager" && p.Company.CompanyName == "Deloitte");
                    i4.Interviewee = db.Users.FirstOrDefault(e => e.UserName== "estuart@anchor.net");
                    i4.Interviewer = db.Users.FirstOrDefault(r => r.UserName== "mclarence@aool.com");
                    i4.RoomNumber = "Room1";
                    i4.InterviewTime = new DateTime(2019, 5, 15, 10, 0, 0);
                    Interviews.Add(i4);

                    Application a4 = new Application();
                    a4.AppUser = db.Users.FirstOrDefault(e => e.UserName== "estuart@anchor.net");
                    a4.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Account Manager" && p.Company.CompanyName == "Deloitte");
                    a4.ApplicationDate = new DateTime(1900, 1, 1);
                    a4.Active = true;
                    a4.StatusType = "Accepted";
                    Applications.Add(a4);

                    Interview i5 = new Interview();
                    i5.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Web Development" && p.Company.CompanyName == "Capital One");
                    i5.Interviewee = db.Users.FirstOrDefault(e => e.UserName== "cbaker@example.com");
                    i5.Interviewer = db.Users.FirstOrDefault(r => r.UserName== "smartinmartin.Martin@aool.com");
                    i5.RoomNumber = "Room2";
                    i5.InterviewTime = new DateTime(2019, 5, 16, 14, 0, 0);
                    Interviews.Add(i5);

                    Application a5 = new Application();
                    a5.AppUser = db.Users.FirstOrDefault(e => e.UserName== "cbaker@example.com");
                    a5.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Web Development" && p.Company.CompanyName == "Capital One");
                    a5.ApplicationDate = new DateTime(1900, 1, 1);
                    a5.Active = true;
                    a5.StatusType = "Accepted";
                    Applications.Add(a5);

                    Interview i6 = new Interview();
                    i6.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Amenities Analytics Intern" && p.Company.CompanyName == "Hilton Worldwide");
                    i6.Interviewee = db.Users.FirstOrDefault(e => e.UserName== "erynrice@aoll.com");
                    i6.Interviewer = db.Users.FirstOrDefault(r => r.UserName== "yhuik9.Taylor@aool.com");
                    i6.RoomNumber = "Room1";
                    i6.InterviewTime = new DateTime(2019, 4, 1, 9, 0, 0);
                    Interviews.Add(i6);

                    Application a6 = new Application();
                    a6.AppUser = db.Users.FirstOrDefault(e => e.UserName== "erynrice@aoll.com");
                    a6.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Amenities Analytics Intern" && p.Company.CompanyName == "Hilton Worldwide");
                    a6.ApplicationDate = new DateTime(1900, 1, 1);
                    a6.Active = true;
                    a6.StatusType = "Accepted";
                    Applications.Add(a6);

                    Interview i7 = new Interview();
                    i7.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Amenities Analytics Intern" && p.Company.CompanyName == "Hilton Worldwide");
                    i7.Interviewee = db.Users.FirstOrDefault(e => e.UserName== "tfreeley@minnetonka.ci.us");
                    i7.Interviewer = db.Users.FirstOrDefault(r => r.UserName== "yhuik9.Taylor@aool.com");
                    i7.RoomNumber = "Room1";
                    i7.InterviewTime = new DateTime(2019, 4, 1, 10, 0, 0);
                    Interviews.Add(i7);

                    Application a7 = new Application();
                    a7.AppUser = db.Users.FirstOrDefault(e => e.UserName== "tfreeley@minnetonka.ci.us");
                    a7.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Amenities Analytics Intern" && p.Company.CompanyName == "Hilton Worldwide");
                    a7.ApplicationDate = new DateTime(1900, 1, 1);
                    a7.Active = true;
                    a7.StatusType = "Accepted";
                    Applications.Add(a7);

                    Interview i8 = new Interview();
                    i8.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Amenities Analytics Intern" && p.Company.CompanyName == "Hilton Worldwide");
                    i8.Interviewee = db.Users.FirstOrDefault(e => e.UserName== "limchou@gogle.com");
                    i8.Interviewer = db.Users.FirstOrDefault(r => r.UserName== "yhuik9.Taylor@aool.com");
                    i8.RoomNumber = "Room4";
                    i8.InterviewTime = new DateTime(2019, 4, 2, 15, 0, 0);
                    Interviews.Add(i8);

                    Application a8 = new Application();
                    a8.AppUser = db.Users.FirstOrDefault(e => e.UserName== "limchou@gogle.com");
                    a8.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Amenities Analytics Intern" && p.Company.CompanyName == "Hilton Worldwide");
                    a8.ApplicationDate = new DateTime(1900, 1, 1);
                    a8.Active = true;
                    a8.StatusType = "Accepted";
                    Applications.Add(a8);

                    Interview i9 = new Interview();
                    i9.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Supply Chain Internship" && p.Company.CompanyName == "Shell");
                    i9.Interviewee = db.Users.FirstOrDefault(e => e.UserName== "ingram@jack.com");
                    i9.Interviewer = db.Users.FirstOrDefault(r => r.UserName== "elowe@netscrape.net");
                    i9.RoomNumber = "Room1";
                    i9.InterviewTime = new DateTime(2019, 5, 10, 9, 0, 0);
                    Interviews.Add(i9);

                    Application a9 = new Application();
                    a9.AppUser = db.Users.FirstOrDefault(e => e.UserName== "ingram@jack.com");
                    a9.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Supply Chain Internship" && p.Company.CompanyName == "Shell");
                    a9.ApplicationDate = new DateTime(1900, 1, 1);
                    a9.Active = true;
                    a9.StatusType = "Accepted";
                    Applications.Add(a9);

                    Interview i10 = new Interview();
                    i10.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Supply Chain Internship" && p.Company.CompanyName == "Shell");
                    i10.Interviewee = db.Users.FirstOrDefault(e => e.UserName== "saunders@pen.com");
                    i10.Interviewer = db.Users.FirstOrDefault(r => r.UserName== "elowe@netscrape.net");
                    i10.RoomNumber = "Room1";
                    i10.InterviewTime = new DateTime(2019, 5, 10, 11, 0, 0);
                    Interviews.Add(i10);

                    Application a10 = new Application();
                    a10.AppUser = db.Users.FirstOrDefault(e => e.UserName== "saunders@pen.com");
                    a10.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Supply Chain Internship" && p.Company.CompanyName == "Shell");
                    a10.ApplicationDate = new DateTime(1900, 1, 1);
                    a10.Active = true;
                    a10.StatusType = "Accepted";
                    Applications.Add(a10);

                    Interview i11 = new Interview();
                    i11.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Financial Analyst" && p.Company.CompanyName == "Capital One");
                    i11.Interviewee = db.Users.FirstOrDefault(e => e.UserName== "johnsmith187@aoll.com");
                    i11.Interviewer = db.Users.FirstOrDefault(r => r.UserName== "or@aool.com");
                    i11.RoomNumber = "Room3";
                    i11.InterviewTime = new DateTime(2019, 5, 16, 15, 0, 0);
                    Interviews.Add(i11);

                    Application a11 = new Application();
                    a11.AppUser = db.Users.FirstOrDefault(e => e.UserName== "johnsmith187@aoll.com");
                    a11.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Financial Analyst" && p.Company.CompanyName == "Capital One");
                    a11.ApplicationDate = new DateTime(1900, 1, 1);
                    a11.Active = true;
                    a11.StatusType = "Accepted";
                    Applications.Add(a11);

                    Interview i12 = new Interview();
                    i12.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Accounting Intern" && p.Company.CompanyName == "Deloitte");
                    i12.Interviewee = db.Users.FirstOrDefault(e => e.UserName== "cluce@gogle.com");
                    i12.Interviewer = db.Users.FirstOrDefault(r => r.UserName== "nelson.Kelly@aool.com");
                    i12.RoomNumber = "Room4";
                    i12.InterviewTime = new DateTime(2019, 5, 16, 11, 0, 0);
                    Interviews.Add(i12);

                    Application a12 = new Application();
                    a12.AppUser = db.Users.FirstOrDefault(e => e.UserName== "cluce@gogle.com");
                    a12.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Accounting Intern" && p.Company.CompanyName == "Deloitte");
                    a12.ApplicationDate = new DateTime(1900, 1, 1);
                    a12.Active = true;
                    a12.StatusType = "Accepted";
                    Applications.Add(a12);

                    Interview i13 = new Interview();
                    i13.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Consultant" && p.Company.CompanyName == "Accenture");
                    i13.Interviewee = db.Users.FirstOrDefault(e => e.UserName== "estuart@anchor.net");
                    i13.Interviewer = db.Users.FirstOrDefault(r => r.UserName== "michelle@example.com");
                    i13.RoomNumber = "Room3";
                    i13.InterviewTime = new DateTime(2019, 6, 5, 14, 0, 0);
                    Interviews.Add(i13);

                    Application a13 = new Application();
                    a13.AppUser = db.Users.FirstOrDefault(e => e.UserName== "estuart@anchor.net");
                    a13.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Consultant" && p.Company.CompanyName == "Accenture");
                    a13.ApplicationDate = new DateTime(1900, 1, 1);
                    a13.Active = true;
                    a13.StatusType = "Accepted";
                    Applications.Add(a13);

                    Interview i14 = new Interview();
                    i14.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Consultant" && p.Company.CompanyName == "Accenture");
                    i14.Interviewee = db.Users.FirstOrDefault(e => e.UserName== "wjhearniii@umich.org");
                    i14.Interviewer = db.Users.FirstOrDefault(r => r.UserName== "toddy@aool.com");
                    i14.RoomNumber = "Room3";
                    i14.InterviewTime = new DateTime(2019, 6, 5, 16, 0, 0);
                    Interviews.Add(i14);

                    Application a14 = new Application();
                    a14.AppUser = db.Users.FirstOrDefault(e => e.UserName== "wjhearniii@umich.org");
                    a14.Position = db.Positions.FirstOrDefault(p => p.PositionTitle == "Consultant" && p.Company.CompanyName == "Accenture");
                    a14.ApplicationDate = new DateTime(1900, 1, 1);
                    a14.Active = true;
                    a14.StatusType = "Accepted";
                    Applications.Add(a14);


                    try
                    {
                        foreach (Interview interviewToAdd in Interviews)
                        {
                            idInterview = interviewToAdd.InterviewId;
                            Interview dbInterview = db.Interviews.FirstOrDefault(a => a.InterviewId == interviewToAdd.InterviewId);
                            if (dbInterview == null) //this title doesn't exist
                            {
                                db.Interviews.Add(interviewToAdd);
                                db.SaveChanges();
                                intInterviewsAdded += 1;
                            }
                            else //book exists - update values
                            {
                                dbInterview.Position = interviewToAdd.Position;
                                dbInterview.Interviewee = interviewToAdd.Interviewee;
                                dbInterview.Interviewer = interviewToAdd.Interviewer;
                                dbInterview.RoomNumber = interviewToAdd.RoomNumber;
                                dbInterview.InterviewTime = interviewToAdd.InterviewTime;
      
                                db.Update(interviewToAdd);
                                db.SaveChanges();
                                intInterviewsAdded += 1;
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        String msg = "  Repositories added:" + intInterviewsAdded + "; Error on " + idInterview;
                        throw new InvalidOperationException(ex.Message + msg);
                    }

                    try
                    {
                        foreach (Application applicationToAdd in Applications)
                        {
                            idApplication = applicationToAdd.ApplicationID;
                            Application dbApplication = db.Applications.FirstOrDefault(a => a.ApplicationID == applicationToAdd.ApplicationID);
                            if (dbApplication == null) //this title doesn't exist
                            {
                                db.Applications.Add(applicationToAdd);
                                db.SaveChanges();
                                intApplicationsAdded += 1;
                            }
                            else //book exists - update values
                            {
                                dbApplication.AppUser = applicationToAdd.AppUser;
                                dbApplication.Position = applicationToAdd.Position;
                                dbApplication.ApplicationDate = applicationToAdd.ApplicationDate;
                                dbApplication.Active = applicationToAdd.Active;
                                db.Update(dbApplication);
                                db.SaveChanges();
                                intApplicationsAdded += 1;
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        String msg = "  Repositories added:" + intApplicationsAdded + "; Error on " + idApplication.ToString();
                        throw new InvalidOperationException(ex.Message + msg);
                    }

                }
                catch (Exception e)
                {
                    throw new InvalidOperationException(e.Message);
                }
            }
        }
    }
