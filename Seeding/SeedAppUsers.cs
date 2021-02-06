using hirelonghorn.Models;
using hirelonghorn.DAL;
using System.Collections.Generic;
using System;
using System.Linq;

namespace hirelonghorn.Seeding
{
    public static class SeedAppUsers
    {
        public static void SeedAllAppUsers(AppDbContext db)
        {
            /*if (db.AppUsers.Count() == 51)
            {
                throw new NotSupportedException("The database already contains all 51 AppUsers!");
            }*/

            if (db.AppUsers.Count() == 71)
            {
                throw new NotSupportedException("The database already contains all 71 AppUsers!");
            }

            Int32 intAppUsersAdded = 0;
            String strFirstName = "Begin"; //helps to keep track of error on books
            List<AppUser> AppUsers = new List<AppUser>();

            try
            {/*
                AppUser a1 = new AppUser() { LastName = "Baker", FirstName = "Christopher", MiddleInitial = "L.", Email = "cbaker@example.com",  PositionType = "FT", GraduationDate = 2019, GPA = 3.91m };
                a1.Major = db.Majors.FirstOrDefault(c => c.MajorName == "MIS");
                AppUsers.Add(a1);
                AppUser a2 = new AppUser() { LastName = "Banks", FirstName = "Michelle", MiddleInitial = "", Email = "banker@longhorn.net", PositionType = "I", GraduationDate = 2020, GPA = 3.52m};
                a2.Major = db.Majors.FirstOrDefault(c => c.MajorName == "International Business");
                AppUsers.Add(a2);
                AppUser a3 = new AppUser() { LastName = "Broccolo", FirstName = "Franco", MiddleInitial = "V", Email = "franco@example.com",  PositionType = "FT", GraduationDate = 2019, GPA = 3.2m};
                a3.Major = db.Majors.FirstOrDefault(c => c.MajorName == "MIS");
                AppUsers.Add(a3);
                AppUser a4 = new AppUser() { LastName = "Chang", FirstName = "Wendy", MiddleInitial = "L", Email = "wchang@example.com",  PositionType = "I", GraduationDate = 2021, GPA = 3.56m };
                a4.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Finance");
                AppUsers.Add(a4);
                AppUser a5 = new AppUser() { LastName = "Chou", FirstName = "Lim", MiddleInitial = "", Email = "limchou@gogle.com",  PositionType = "I", GraduationDate = 2020, GPA = 2.63m };
                a5.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Finance");
                AppUsers.Add(a5);
                AppUser a6 = new AppUser() { LastName = "Dixon", FirstName = "Shan", MiddleInitial = "D", Email = "shdixon@aoll.com", PositionType = "I", GraduationDate = 2022, GPA = 3.62m };
                a6.Major = db.Majors.FirstOrDefault(c => c.MajorName == "International Business");
                AppUsers.Add(a6);
                AppUser a7 = new AppUser() { LastName = "Evans", FirstName = "Jim Bob", MiddleInitial = "", Email = "j.b.evans@aheca.org",  PositionType = "FT", GraduationDate = 2019, GPA = 2.64m};
                a7.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Accounting");
                AppUsers.Add(a7);
                AppUser a8 = new AppUser() { LastName = "Feeley", FirstName = "Lou Ann", MiddleInitial = "K", Email = "feeley@penguin.org",  PositionType = "I", GraduationDate = 2020, GPA = 3.66m};
                a8.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Marketing");
                AppUsers.Add(a8);
                AppUser a9 = new AppUser() { LastName = "Freeley", FirstName = "Tesa", MiddleInitial = "P", Email = "tfreeley@minnetonka.ci.us", PositionType = "FT", GraduationDate = 2019, GPA = 3.98m };
                a9.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Accounting");
                AppUsers.Add(a9);
                AppUser a10 = new AppUser() { LastName = "Garcia", FirstName = "Margaret", MiddleInitial = "L", Email = "mgarcia@gogle.com",  PositionType = "FT", GraduationDate = 2019, GPA = 3.22m };
                a10.Major = db.Majors.FirstOrDefault(c => c.MajorName == "MIS");
                AppUsers.Add(a10);
                AppUser a11 = new AppUser() { LastName = "Haley", FirstName = "Charles", MiddleInitial = "E", Email = "chaley@thug.com",  PositionType = "I", GraduationDate = 2020, GPA = 3.78m };
                a11.Major = db.Majors.FirstOrDefault(c => c.MajorName == "MIS");
                AppUsers.Add(a11);
                AppUser a12 = new AppUser() { LastName = "Hampton", FirstName = "Jeffrey", MiddleInitial = "T.", Email = "jeffh@sonic.com",  PositionType = "I", GraduationDate = 2020, GPA = 3.66m };
                a12.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Science and Technology Management");
                AppUsers.Add(a12);
                AppUser a13 = new AppUser() { LastName = "Hearn", FirstName = "John", MiddleInitial = "B", Email = "wjhearniii@umich.org",  PositionType = "FT", GraduationDate = 2019, GPA = 3.46m };
                a13.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Business Honors");
                AppUsers.Add(a13);
                AppUser a14 = new AppUser() { LastName = "Hicks", FirstName = "Anthony", MiddleInitial = "J", Email = "ahick@yaho.com", PositionType = "I", GraduationDate = 2020, GPA = 3.12m};
                a14.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Supply Chain Management");
                AppUsers.Add(a14);
                AppUser a15 = new AppUser() { LastName = "Ingram", FirstName = "Brad", MiddleInitial = "S.", Email = "ingram@jack.com",  PositionType = "I", GraduationDate = 2020, GPA = 3.72m };
                a15.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Supply Chain Management");
                AppUsers.Add(a15);
                AppUser a16 = new AppUser() { LastName = "Jacobs", FirstName = "Todd", MiddleInitial = "L.", Email = "toddj@yourmom.com",  PositionType = "FT", GraduationDate = 2019, GPA = 2.64m };
                a16.Major = db.Majors.FirstOrDefault(c => c.MajorName == "MIS");
                AppUsers.Add(a16);
                AppUser a17 = new AppUser() { LastName = "Lawrence", FirstName = "Victoria", MiddleInitial = "M.", Email = "thequeen@aska.net",  PositionType = "I", GraduationDate = 2021, GPA = 3.72m};
                a17.Major = db.Majors.FirstOrDefault(c => c.MajorName == "MIS");
                AppUsers.Add(a17);
                AppUser a18 = new AppUser() { LastName = "Lineback", FirstName = "Erik", MiddleInitial = "W", Email = "linebacker@gogle.com",  PositionType = "I", GraduationDate = 2022, GPA = 3.15m };
                a18.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Accounting");
                AppUsers.Add(a18);
                AppUser a19 = new AppUser() { LastName = "Lowe", FirstName = "Ernest", MiddleInitial = "S", Email = "elowe@netscare.net",  PositionType = "FT", GraduationDate = 2019, GPA = 3.07m };
                a19.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Finance");
                AppUsers.Add(a19);
                AppUser a20 = new AppUser() { LastName = "Luce", FirstName = "Chuck", MiddleInitial = "B", Email = "cluce@gogle.com",  PositionType = "I", GraduationDate = 2020, GPA = 3.87m };
                a20.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Accounting");
                AppUsers.Add(a20);
                AppUser a21 = new AppUser() { LastName = "MacLeod", FirstName = "Jennifer", MiddleInitial = "D.", Email = "mackcloud@george.com",  PositionType = "FT", GraduationDate = 2019, GPA = 4.0m};
                a21.Major = db.Majors.FirstOrDefault(c => c.MajorName == "MIS");
                AppUsers.Add(a21);
                AppUser a22 = new AppUser() { LastName = "Markham", FirstName = "Elizabeth", MiddleInitial = "P.", Email = "cmartin@beets.com",  PositionType = "FT", GraduationDate = 2019, GPA = 3.53m};
                a22.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Business Honors");
                AppUsers.Add(a22);
                AppUser a23 = new AppUser() { LastName = "Martin", FirstName = "Clarence", MiddleInitial = "A", Email = "clarence@yoho.com",  PositionType = "I", GraduationDate = 2020, GPA = 3.11m};
                a23.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Supply Chain Management");
                AppUsers.Add(a23);
                AppUser a24 = new AppUser() { LastName = "Martinez", FirstName = "Gregory", MiddleInitial = "R.", Email = "gregmartinez@drdre.com",  PositionType = "I", GraduationDate = 2021, GPA = 3.43m };
                a24.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Business Honors");
                AppUsers.Add(a24);
                AppUser a25 = new AppUser() { LastName = "Miller", FirstName = "Charles", MiddleInitial = "R.", Email = "cmiller@bob.com", PositionType = "I", GraduationDate = 2020, GPA = 3.14m };
                a25.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Management");
                AppUsers.Add(a25);
                AppUser a26 = new AppUser() { LastName = "Nelson", FirstName = "Kelly", MiddleInitial = "T", Email = "knelson@aoll.com", PositionType = "FT", GraduationDate = 2019, GPA = 3.03m };
                a26.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Finance");
                AppUsers.Add(a26);
                AppUser a27 = new AppUser() { LastName = "Nguyen", FirstName = "Joe", MiddleInitial = "C", Email = "joewin@xfactor.com", PositionType = "FT", GraduationDate = 2019, GPA = 3.65m };
                a27.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Management");
                AppUsers.Add(a27);
                AppUser a28 = new AppUser() { LastName = "O'Reilly", FirstName = "Bill", MiddleInitial = "T", Email = "orielly@foxnews.cnn",  PositionType = "I", GraduationDate = 2020, GPA = 3.46m };
                a28.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Finance");
                AppUsers.Add(a28);
                AppUser a29 = new AppUser() { LastName = "Radkovich", FirstName = "Anka", MiddleInitial = "L", Email = "ankaisrad@gogle.com", PositionType = "FT", GraduationDate = 2019, GPA = 3.67m };
                a29.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Business Honors");
                AppUsers.Add(a29);
                AppUser a30 = new AppUser() { LastName = "Rhodes", FirstName = "Megan", MiddleInitial = "C.", Email = "megrhodes@freserve.co.uk",  PositionType = "I", GraduationDate = 2020, GPA = 3.14m };
                a30.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Management");
                AppUsers.Add(a30);
                AppUser a31 = new AppUser() { LastName = "Rice", FirstName = "Eryn", MiddleInitial = "M.", Email = "erynrice@aoll.com",  PositionType = "I", GraduationDate = 2022, GPA = 3.92m };
                a31.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Marketing");
                AppUsers.Add(a31);
                AppUser a32 = new AppUser() { LastName = "Rodriguez", FirstName = "Jorge", MiddleInitial = "", Email = "jorge@noclue.com",  PositionType = "I", GraduationDate = 2021, GPA = 3.64m };
                a32.Major = db.Majors.FirstOrDefault(c => c.MajorName == "MIS");
                AppUsers.Add(a32);
                AppUser a33 = new AppUser() { LastName = "Rogers", FirstName = "Allen", MiddleInitial = "B.", Email = "mrrogers@lovelyday.com",  PositionType = "I", GraduationDate = 2020, GPA = 3.01m };
                a33.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Marketing");
                AppUsers.Add(a33);
                AppUser a34 = new AppUser() { LastName = "Saint-Jean", FirstName = "Olivier", MiddleInitial = "M", Email = "stjean@athome.com",  PositionType = "FT", GraduationDate = 2019, GPA = 3.24m };
                a34.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Science and Technology Management");
                AppUsers.Add(a34);
                AppUser a35 = new AppUser() { LastName = "Saunders", FirstName = "Sarah", MiddleInitial = "J.", Email = "saunders@pen.com",  PositionType = "I", GraduationDate = 2020, GPA = 3.16m };
                a35.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Supply Chain Management");
                AppUsers.Add(a35);
                AppUser a36 = new AppUser() { LastName = "Sewell", FirstName = "William", MiddleInitial = "T.", Email = "willsheff@email.com",  PositionType = "FT", GraduationDate = 2019, GPA = 3.07m };
                a36.Major = db.Majors.FirstOrDefault(c => c.MajorName == "MIS");
                AppUsers.Add(a36);
                AppUser a37 = new AppUser() { LastName = "Sheffield", FirstName = "Martin", MiddleInitial = "J.", Email = "sheffiled@gogle.com",  PositionType = "I", GraduationDate = 2020, GPA = 3.36m };
                a37.Major = db.Majors.FirstOrDefault(c => c.MajorName == "MIS");
                AppUsers.Add(a37);
                AppUser a38 = new AppUser() { LastName = "Smith", FirstName = "John", MiddleInitial = "A", Email = "johnsmith187@aoll.com",  PositionType = "FT", GraduationDate = 2019, GPA = 3.57m };
                a38.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Finance");
                AppUsers.Add(a38);
                AppUser a39 = new AppUser() { LastName = "Stroud", FirstName = "Dustin", MiddleInitial = "P", Email = "dustroud@mail.com",  PositionType = "I", GraduationDate = 2020, GPA = 3.49m };
                a39.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Marketing");
                AppUsers.Add(a39);
                AppUser a40 = new AppUser() { LastName = "Stuart", FirstName = "Eric", MiddleInitial = "D.", Email = "estuart@anchor.net",  PositionType = "FT", GraduationDate = 2019, GPA = 3.58m };
                a40.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Business Honors");
                AppUsers.Add(a40);
                AppUser a41 = new AppUser() { LastName = "Stump", FirstName = "Peter", MiddleInitial = "L", Email = "peterstump@noclue.com",  PositionType = "I", GraduationDate = 2021, GPA = 2.55m };
                a41.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Supply Chain Management");
                AppUsers.Add(a41);
                AppUser a42 = new AppUser() { LastName = "Tanner", FirstName = "Jeremy", MiddleInitial = "S.", Email = "jtanner@mustang.net",  PositionType = "I", GraduationDate = 2020, GPA = 3.16m };
                a42.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Management");
                AppUsers.Add(a42);
                AppUser a43 = new AppUser() { LastName = "Taylor", FirstName = "Allison", MiddleInitial = "R.", Email = "taylordjay@aoll.com",  PositionType = "FT", GraduationDate = 2019, GPA = 3.07m };
                a43.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Marketing");
                AppUsers.Add(a43);
                AppUser a44 = new AppUser() { LastName = "Taylor", FirstName = "Rachel", MiddleInitial = "K.", Email = "rtaylor@gogle.com",  PositionType = "I", GraduationDate = 2020, GPA = 2.88m };
                a44.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Finance");
                AppUsers.Add(a44);
                AppUser a45 = new AppUser() { LastName = "Tee", FirstName = "Frank", MiddleInitial = "J", Email = "teefrank@noclue.com",  PositionType = "FT", GraduationDate = 2019, GPA = 3.5m };
                a45.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Finance");
                AppUsers.Add(a45);
                AppUser a46 = new AppUser() { LastName = "Tucker", FirstName = "Clent", MiddleInitial = "J", Email = "ctucker@alphabet.co.uk",  PositionType = "I", GraduationDate = 2020, GPA = 3.04m };
                a46.Major = db.Majors.FirstOrDefault(c => c.MajorName == "MIS");
                AppUsers.Add(a46);
                AppUser a47 = new AppUser() { LastName = "Velasco", FirstName = "Allen", MiddleInitial = "G", Email = "avelasco@yoho.com", PositionType = "FT", GraduationDate = 2019, GPA = 3.55m };
                a47.Major = db.Majors.FirstOrDefault(c => c.MajorName == "MIS");
                AppUsers.Add(a47);
                AppUser a48 = new AppUser() { LastName = "Vino", FirstName = "Janet", MiddleInitial = "E", Email = "vinovino@grapes.com",  PositionType = "I", GraduationDate = 2021, GPA = 3.28m };
                a48.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Business Honors");
                AppUsers.Add(a48);
                AppUser a49 = new AppUser() { LastName = "West", FirstName = "Jake", MiddleInitial = "T", Email = "westj@pioneer.net",  PositionType = "FT", GraduationDate = 2019, GPA = 3.66m };
                a49.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Finance");
                AppUsers.Add(a49);
                AppUser a50 = new AppUser() { LastName = "Winthorpe", FirstName = "Louis", MiddleInitial = "L", Email = "winner@hootmail.com",  PositionType = "FT", GraduationDate = 2019, GPA = 2.57m };
                a50.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Finance");
                AppUsers.Add(a50);
                AppUser a51 = new AppUser() { LastName = "Wood", FirstName = "Reagan", MiddleInitial = "B.", Email = "rwood@voyager.net", PositionType = "FT", GraduationDate = 2019, GPA = 3.78m };
                a51.Major = db.Majors.FirstOrDefault(c => c.MajorName == "Accounting");
                AppUsers.Add(a51);
                */
                AppUser a52 = new AppUser() { Email = "michelle@example.com", FirstName = "Michelle", LastName = "Banks", };
                a52.Company = db.Companies.FirstOrDefault(c => c.CompanyName == "Accenture");
                AppUsers.Add(a52);
                AppUser a53 = new AppUser() { Email = "toddy@aool.com", FirstName = "Todd", LastName = "Jacobs", };
                a53.Company = db.Companies.FirstOrDefault(c => c.CompanyName == "Accenture");
                AppUsers.Add(a53);
                AppUser a54 = new AppUser() { Email = "elowe@netscrape.net", FirstName = "Ernest", LastName = "Lowe", };
                a54.Company = db.Companies.FirstOrDefault(c => c.CompanyName == "Shell");
                AppUsers.Add(a54);
                AppUser a55 = new AppUser() { Email = "mclarence@aool.com", FirstName = "Clarence", LastName = "Martin", };
                a55.Company = db.Companies.FirstOrDefault(c => c.CompanyName == "Deloitte");
                AppUsers.Add(a55);
                AppUser a56 = new AppUser() { Email = "nelson.Kelly@aool.com", FirstName = "Kelly", LastName = "Nelson", };
                a56.Company = db.Companies.FirstOrDefault(c => c.CompanyName == "Deloitte");
                AppUsers.Add(a56);
                AppUser a57 = new AppUser() { Email = "megrhodes@freezing.co.uk", FirstName = "Megan", LastName = "Rhodes", };
                a57.Company = db.Companies.FirstOrDefault(c => c.CompanyName == "Deloitte");
                AppUsers.Add(a57);
                AppUser a58 = new AppUser() { Email = "sheff44@ggmail.com", FirstName = "Martin", LastName = "Sheffield", };
                a58.Company = db.Companies.FirstOrDefault(c => c.CompanyName == "Texas Instruments");
                AppUsers.Add(a58);
                AppUser a59 = new AppUser() { Email = "peterstump@hootmail.com", FirstName = "Peter", LastName = "Stump", };
                a59.Company = db.Companies.FirstOrDefault(c => c.CompanyName == "Texas Instruments");
                AppUsers.Add(a59);
                AppUser a60 = new AppUser() { Email = "yhuik9.Taylor@aool.com", FirstName = "Rachel", LastName = "Taylor", };
                a60.Company = db.Companies.FirstOrDefault(c => c.CompanyName == "Hilton Worldwide");
                AppUsers.Add(a60);
                AppUser a61 = new AppUser() { Email = "tuck33@ggmail.com", FirstName = "Clent", LastName = "Tucker", };
                a61.Company = db.Companies.FirstOrDefault(c => c.CompanyName == "Aon");
                AppUsers.Add(a61);
                AppUser a62 = new AppUser() { Email = "taylordjay@aool.com", FirstName = "Allison", LastName = "Taylor", };
                a62.Company = db.Companies.FirstOrDefault(c => c.CompanyName == "Aldlucent");
                AppUsers.Add(a62);
                AppUser a63 = new AppUser() { Email = "jojoe@ggmail.com", FirstName = "Joe", LastName = "Nguyen", };
                a63.Company = db.Companies.FirstOrDefault(c => c.CompanyName == "Stream Realty Partners");
                AppUsers.Add(a63);
                AppUser a64 = new AppUser() { Email = "hicks43@ggmail.com", FirstName = "Anthony", LastName = "Hicks", };
                a64.Company = db.Companies.FirstOrDefault(c => c.CompanyName == "Microsoft");
                AppUsers.Add(a64);
                AppUser a65 = new AppUser() { Email = "orielly@foxnets.com", FirstName = "Bill", LastName = "O'Reilly", };
                a65.Company = db.Companies.FirstOrDefault(c => c.CompanyName == "Microsoft");
                AppUsers.Add(a65);
                AppUser a66 = new AppUser() { Email = "louielouie@aool.com", FirstName = "Louis", LastName = "Winthorpe", };
                a66.Company = db.Companies.FirstOrDefault(c => c.CompanyName == "Microsoft");
                AppUsers.Add(a66);
                AppUser a67 = new AppUser() { Email = "smartinmartin.Martin@aool.com", FirstName = "Gregory", LastName = "Martinez", };
                a67.Company = db.Companies.FirstOrDefault(c => c.CompanyName == "Capital One");
                AppUsers.Add(a67);
                AppUser a68 = new AppUser() { Email = "or@aool.com", FirstName = "Anka", LastName = "Radkovich", };
                a68.Company = db.Companies.FirstOrDefault(c => c.CompanyName == "Capital One");
                AppUsers.Add(a68);
                AppUser a69 = new AppUser() { Email = "tanner@ggmail.com", FirstName = "Jeremy", LastName = "Tanner", };
                a69.Company = db.Companies.FirstOrDefault(c => c.CompanyName == "United Airlines");
                AppUsers.Add(a69);
                AppUser a70 = new AppUser() { Email = "tee_frank@hootmail.com", FirstName = "Frank", LastName = "Tee", };
                a70.Company = db.Companies.FirstOrDefault(c => c.CompanyName == "Academy Sports & Outdoors");
                AppUsers.Add(a70);
                AppUser a71 = new AppUser() { Email = "target_spot@example.com", FirstName = "Spot", LastName = "Dog", };
                a71.Company = db.Companies.FirstOrDefault(c => c.CompanyName == "Target");
                AppUsers.Add(a71);

                try
                {
                    foreach (AppUser appUserToAdd in AppUsers)
                    {
                        strFirstName = appUserToAdd.FirstName;
                        AppUser dbAppUser = db.AppUsers.FirstOrDefault(a => a.Email == appUserToAdd.Email);
                        if (dbAppUser == null) //this title doesn't exist
                        {
                            db.AppUsers.Add(appUserToAdd);
                            db.SaveChanges();
                            intAppUsersAdded += 1;
                        }
                        else //book exists - update values
                        {
                            dbAppUser.LastName = appUserToAdd.LastName;
                            dbAppUser.FirstName = appUserToAdd.FirstName;
                            //dbAppUser.MiddleInitial = appUserToAdd.MiddleInitial;
                            dbAppUser.Email = appUserToAdd.Email;
                            
                           // dbAppUser.PositionType = appUserToAdd.PositionType;
                            //dbAppUser.GraduationDate = appUserToAdd.GraduationDate;
                            //dbAppUser.GPA = appUserToAdd.GPA;

                            db.Update(dbAppUser);
                            db.SaveChanges();
                            intAppUsersAdded += 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    String msg = "  Repositories added:" + intAppUsersAdded + "; Error on " + strFirstName;
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

