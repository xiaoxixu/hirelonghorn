using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

using sp19team18finalproject.DAL;
using sp19team18finalproject.Models;

namespace sp19team18finalproject.Seeding
{
    //add identity data
    public static class SeedIdentity
    {
        public static async Task AddAdmin(IServiceProvider serviceProvider)
        {
            AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            //TODO: Add the needed roles
            //if role doesn't exist, add it
            if (await _roleManager.RoleExistsAsync("CSO") == false)
            {
                await _roleManager.CreateAsync(new IdentityRole("CSO"));
            }

            if (await _roleManager.RoleExistsAsync("Recruiter") == false)
            {
                await _roleManager.CreateAsync(new IdentityRole("Recruiter"));
            }

            if (await _roleManager.RoleExistsAsync("Student") == false)
            {
                await _roleManager.CreateAsync(new IdentityRole("Student"));
            }


            /*

            //check to see if the manager has been added
            AppUser cso = _db.Users.FirstOrDefault(u => u.Email == "admin@example.com");

            //if manager hasn't been created, then add them
           
            if (cso == null)
            {
                cso = new AppUser();
                cso.UserName = "admin@example.com";
                cso.Email = "admin@example.com";
                cso.FirstName = "Admin";
                //TODO: Add additional fields that you created on the AppUser class
                cso.LastName = "Example";

                var result = await _userManager.CreateAsync(cso, "Abc123!");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
                cso = _db.Users.FirstOrDefault(u => u.UserName == "admin@example.com");
            }

            //make sure user is in role
            if (await _userManager.IsInRoleAsync(cso, "CSO") == false)
            {
                await _userManager.AddToRoleAsync(cso, "CSO");
            }

            //save changes
            _db.SaveChanges();
            */
            AppUser cso1 = _db.Users.FirstOrDefault(u => u.Email == "ra@aoo.com");
            if (cso1 == null)
            {
                cso1 = new AppUser() { UserName = "ra@aoo.com", Email = "ra@aoo.com", FirstName = "Allen", LastName = "Rogers" };
                cso1.Active = true;
                var result = await _userManager.CreateAsync(cso1, "3wCynC");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                cso1 = _db.Users.FirstOrDefault(u => u.UserName == "ra@aoo.com");
            }
            if (await _userManager.IsInRoleAsync(cso1, "CSO") == false)
            {
                await _userManager.AddToRoleAsync(cso1, "CSO");
            }
            _db.SaveChanges();
            AppUser cso2 = _db.Users.FirstOrDefault(u => u.Email == "rwood@voyager.net");
            if (cso2 == null)
            {
                cso2 = new AppUser() { UserName = "rwood@voyager.net", Email = "rwood@voyager.net", FirstName = "Reagan", LastName = "Wood" };
                cso2.Active = true;
                var result = await _userManager.CreateAsync(cso2, "Pbon0r");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                cso2 = _db.Users.FirstOrDefault(u => u.UserName == "rwood@voyager.net");
            }
            if (await _userManager.IsInRoleAsync(cso2, "CSO") == false)
            {
                await _userManager.AddToRoleAsync(cso2, "CSO");
            }
            _db.SaveChanges();
            AppUser cso3 = _db.Users.FirstOrDefault(u => u.Email == "westj@pioneer.net");
            if (cso3 == null)
            {
                cso3 = new AppUser() { UserName = "westj@pioneer.net", Email = "westj@pioneer.net", FirstName = "Jake", LastName = "West" };
                cso3.Active = true;
                var result = await _userManager.CreateAsync(cso3, "jW5fPP");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                cso3 = _db.Users.FirstOrDefault(u => u.UserName == "westj@pioneer.net");
            }
            if (await _userManager.IsInRoleAsync(cso3, "CSO") == false)
            {
                await _userManager.AddToRoleAsync(cso3, "CSO");
            }
            _db.SaveChanges();
            AppUser cso4 = _db.Users.FirstOrDefault(u => u.Email == "liz@ggmail.com");
            if (cso4 == null)
            {
                cso4 = new AppUser() { UserName = "liz@ggmail.com", Email = "liz@ggmail.com", FirstName = "Elizabeth", LastName = "Markham"};
                cso4.Active = true;
                var result = await _userManager.CreateAsync(cso4, "0QyilL");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                cso4 = _db.Users.FirstOrDefault(u => u.UserName == "liz@ggmail.com");
            }
            if (await _userManager.IsInRoleAsync(cso4, "CSO") == false)
            {
                await _userManager.AddToRoleAsync(cso4, "CSO");
            }
            _db.SaveChanges();
            AppUser cso5 = _db.Users.FirstOrDefault(u => u.Email == "chaley@thug.com");
            if (cso5 == null)
            {
                cso5 = new AppUser() { UserName = "chaley@thug.com", Email = "chaley@thug.com", FirstName = "Charles", LastName = "Haley" };
                cso5.Active = true;
                var result = await _userManager.CreateAsync(cso5, "atLm6W");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                cso5 = _db.Users.FirstOrDefault(u => u.UserName == "chaley@thug.com");
            }
            if (await _userManager.IsInRoleAsync(cso5, "CSO") == false)
            {
                await _userManager.AddToRoleAsync(cso5, "CSO");
            }
            _db.SaveChanges();



            AppUser student1 = _db.Users.FirstOrDefault(u => u.Email == "cbaker@example.com");
            if (student1 == null)
            {
                student1 = new AppUser() { UserName = "cbaker@example.com", LastName = "Baker", FirstName = "Christopher", MiddleInitial = "L.", Email = "cbaker@example.com", PositionType = "FT", GraduationDate = 2019, GPA = 3.91m };
                student1.Active = true;
                student1.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "MIS");
                var result = await _userManager.CreateAsync(student1, "bookworm");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student1 = _db.Users.FirstOrDefault(u => u.UserName == "cbaker@example.com");
            }
            if (await _userManager.IsInRoleAsync(student1, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student1, "Student");
            }
            _db.SaveChanges();
            AppUser student2 = _db.Users.FirstOrDefault(u => u.Email == "banker@longhorn.net");
            if (student2 == null)
            {
                student2 = new AppUser() { UserName = "banker@longhorn.net", LastName = "Banks", FirstName = "Michelle", MiddleInitial = "", Email = "banker@longhorn.net", PositionType = "I", GraduationDate = 2020, GPA = 3.52m };
                student2.Active = true;
                student2.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "International Business");
                var result = await _userManager.CreateAsync(student2, "aclfest2017");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student2 = _db.Users.FirstOrDefault(u => u.UserName == "banker@longhorn.net");
            }
            if (await _userManager.IsInRoleAsync(student2, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student2, "Student");
            }
            _db.SaveChanges();
            AppUser student3 = _db.Users.FirstOrDefault(u => u.Email == "franco@example.com");
            if (student3 == null)
            {
                student3 = new AppUser() { UserName = "franco@example.com", LastName = "Broccolo", FirstName = "Franco", MiddleInitial = "V", Email = "franco@example.com", PositionType = "FT", GraduationDate = 2019, GPA = 3.2m };
                student3.Active = true;
                student3.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "MIS");
                var result = await _userManager.CreateAsync(student3, "aggies");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student3 = _db.Users.FirstOrDefault(u => u.UserName == "franco@example.com");
            }
            if (await _userManager.IsInRoleAsync(student3, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student3, "Student");
            }
            _db.SaveChanges();
            AppUser student4 = _db.Users.FirstOrDefault(u => u.Email == "wchang@example.com");
            if (student4 == null)
            {
                student4 = new AppUser() { UserName = "wchang@example.com", LastName = "Chang", FirstName = "Wendy", MiddleInitial = "L", Email = "wchang@example.com", PositionType = "I", GraduationDate = 2021, GPA = 3.56m };
                student4.Active = true;
                student4.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Finance");
                var result = await _userManager.CreateAsync(student4, "alaskaboy");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student4 = _db.Users.FirstOrDefault(u => u.UserName == "wchang@example.com");
            }
            if (await _userManager.IsInRoleAsync(student4, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student4, "Student");
            }
            _db.SaveChanges();
            AppUser student5 = _db.Users.FirstOrDefault(u => u.Email == "limchou@gogle.com");
            if (student5 == null)
            {
                student5 = new AppUser() { UserName = "limchou@gogle.com", LastName = "Chou", FirstName = "Lim", MiddleInitial = "", Email = "limchou@gogle.com", PositionType = "I", GraduationDate = 2020, GPA = 2.63m };
                student5.Active = true;
                student5.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Finance");
                var result = await _userManager.CreateAsync(student5, "allyrally");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student5 = _db.Users.FirstOrDefault(u => u.UserName == "limchou@gogle.com");
            }
            if (await _userManager.IsInRoleAsync(student5, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student5, "Student");
            }
            _db.SaveChanges();
            AppUser student6 = _db.Users.FirstOrDefault(u => u.Email == "shdixon@aoll.com");
            if (student6 == null)
            {
                student6 = new AppUser() { UserName = "shdixon@aoll.com", LastName = "Dixon", FirstName = "Shan", MiddleInitial = "D", Email = "shdixon@aoll.com", PositionType = "I", GraduationDate = 2022, GPA = 3.62m };
                student6.Active = true;
                student6.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "International Business");
                var result = await _userManager.CreateAsync(student6, "Anchorage");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student6 = _db.Users.FirstOrDefault(u => u.UserName == "shdixon@aoll.com");
            }
            if (await _userManager.IsInRoleAsync(student6, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student6, "Student");
            }
            _db.SaveChanges();
            AppUser student7 = _db.Users.FirstOrDefault(u => u.Email == "j.b.evans@aheca.org");
            if (student7 == null)
            {
                student7 = new AppUser() { UserName = "j.b.evans@aheca.org", LastName = "Evans", FirstName = "Jim Bob", MiddleInitial = "", Email = "j.b.evans@aheca.org", PositionType = "FT", GraduationDate = 2019, GPA = 2.64m };
                student7.Active = true;
                student7.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Accounting");
                var result = await _userManager.CreateAsync(student7, "billyboy");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student7 = _db.Users.FirstOrDefault(u => u.UserName == "j.b.evans@aheca.org");
            }
            if (await _userManager.IsInRoleAsync(student7, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student7, "Student");
            }
            _db.SaveChanges();
            AppUser student8 = _db.Users.FirstOrDefault(u => u.Email == "feeley@penguin.org");
            if (student8 == null)
            {
                student8 = new AppUser() { UserName = "feeley@penguin.org", LastName = "Feeley", FirstName = "Lou Ann", MiddleInitial = "K", Email = "feeley@penguin.org", PositionType = "I", GraduationDate = 2020, GPA = 3.66m };
                student8.Active = true;
                student8.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Marketing");
                var result = await _userManager.CreateAsync(student8, "bunnyhop");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student8 = _db.Users.FirstOrDefault(u => u.UserName == "feeley@penguin.org");
            }
            if (await _userManager.IsInRoleAsync(student8, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student8, "Student");
            }
            _db.SaveChanges();
            AppUser student9 = _db.Users.FirstOrDefault(u => u.Email == "tfreeley@minnetonka.ci.us");
            if (student9 == null)
            {
                student9 = new AppUser() { UserName = "tfreeley@minnetonka.ci.us", LastName = "Freeley", FirstName = "Tesa", MiddleInitial = "P", Email = "tfreeley@minnetonka.ci.us", PositionType = "FT", GraduationDate = 2019, GPA = 3.98m };
                student9.Active = true;
                student9.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Accounting");
                var result = await _userManager.CreateAsync(student9, "dustydusty");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student9 = _db.Users.FirstOrDefault(u => u.UserName == "tfreeley@minnetonka.ci.us");
            }
            if (await _userManager.IsInRoleAsync(student9, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student9, "Student");
            }
            _db.SaveChanges();
            AppUser student10 = _db.Users.FirstOrDefault(u => u.Email == "mgarcia@gogle.com");
            if (student10 == null)
            {
                student10 = new AppUser() { UserName = "mgarcia@gogle.com", LastName = "Garcia", FirstName = "Margaret", MiddleInitial = "L", Email = "mgarcia@gogle.com", PositionType = "FT", GraduationDate = 2019, GPA = 3.22m };
                student10.Active = true;
                student10.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "MIS");
                var result = await _userManager.CreateAsync(student10, "gowest");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student10 = _db.Users.FirstOrDefault(u => u.UserName == "mgarcia@gogle.com");
            }
            if (await _userManager.IsInRoleAsync(student10, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student10, "Student");
            }
            _db.SaveChanges();
            AppUser student11 = _db.Users.FirstOrDefault(u => u.Email == "jeffh@sonic.com");
            if (student11 == null)
            {
                student11 = new AppUser() { UserName = "jeffh@sonic.com", LastName = "Hampton", FirstName = "Jeffrey", MiddleInitial = "T.", Email = "jeffh@sonic.com", PositionType = "I", GraduationDate = 2020, GPA = 3.66m };
                student11.Active = true;
                student11.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Science and Technology Management");
                var result = await _userManager.CreateAsync(student11, "hickhickup");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student11 = _db.Users.FirstOrDefault(u => u.UserName == "jeffh@sonic.com");
            }
            if (await _userManager.IsInRoleAsync(student11, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student11, "Student");
            }
            _db.SaveChanges();
            AppUser student12 = _db.Users.FirstOrDefault(u => u.Email == "wjhearniii@umich.org");
            if (student12 == null)
            {
                student12 = new AppUser() { UserName = "wjhearniii@umich.org", LastName = "Hearn", FirstName = "John", MiddleInitial = "B", Email = "wjhearniii@umich.org", PositionType = "FT", GraduationDate = 2019, GPA = 3.46m };
                student12.Active = true;
                student12.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Business Honors");
                var result = await _userManager.CreateAsync(student12, "ingram2015");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student12 = _db.Users.FirstOrDefault(u => u.UserName == "wjhearniii@umich.org");
            }
            if (await _userManager.IsInRoleAsync(student12, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student12, "Student");
            }
            _db.SaveChanges();
            AppUser student13 = _db.Users.FirstOrDefault(u => u.Email == "ahick@yaho.com");
            if (student13 == null)
            {
                student13 = new AppUser() { UserName = "ahick@yaho.com", LastName = "Hicks", FirstName = "Anthony", MiddleInitial = "J", Email = "ahick@yaho.com", PositionType = "I", GraduationDate = 2020, GPA = 3.12m };
                student13.Active = true;
                student13.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Supply Chain Management");
                var result = await _userManager.CreateAsync(student13, "jhearn22");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student13 = _db.Users.FirstOrDefault(u => u.UserName == "ahick@yaho.com");
            }
            if (await _userManager.IsInRoleAsync(student13, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student13, "Student");
            }
            _db.SaveChanges();
            AppUser student14 = _db.Users.FirstOrDefault(u => u.Email == "ingram@jack.com");
            if (student14 == null)
            {
                student14 = new AppUser() { UserName = "ingram@jack.com", LastName = "Ingram", FirstName = "Brad", MiddleInitial = "S.", Email = "ingram@jack.com", PositionType = "I", GraduationDate = 2020, GPA = 3.72m };
                student14.Active = true;
                student14.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Supply Chain Management");
                var result = await _userManager.CreateAsync(student14, "joejoejoe");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student14 = _db.Users.FirstOrDefault(u => u.UserName == "ingram@jack.com");
            }
            if (await _userManager.IsInRoleAsync(student14, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student14, "Student");
            }
            _db.SaveChanges();
            AppUser student15 = _db.Users.FirstOrDefault(u => u.Email == "toddj@yourmom.com");
            if (student15 == null)
            {
                student15 = new AppUser() { UserName = "toddj@yourmom.com", LastName = "Jacobs", FirstName = "Todd", MiddleInitial = "L.", Email = "toddj@yourmom.com", PositionType = "FT", GraduationDate = 2019, GPA = 2.64m };
                student15.Active = true;
                student15.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "MIS");
                var result = await _userManager.CreateAsync(student15, "jrod2017");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student15 = _db.Users.FirstOrDefault(u => u.UserName == "toddj@yourmom.com");
            }
            if (await _userManager.IsInRoleAsync(student15, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student15, "Student");
            }
            _db.SaveChanges();
            AppUser student16 = _db.Users.FirstOrDefault(u => u.Email == "thequeen@aska.net");
            if (student16 == null)
            {
                student16 = new AppUser() { UserName = "thequeen@aska.net", LastName = "Lawrence", FirstName = "Victoria", MiddleInitial = "M.", Email = "thequeen@aska.net", PositionType = "I", GraduationDate = 2021, GPA = 3.72m };
                student16.Active = true;
                student16.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "MIS");
                var result = await _userManager.CreateAsync(student16, "longhorns");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student16 = _db.Users.FirstOrDefault(u => u.UserName == "thequeen@aska.net");
            }
            if (await _userManager.IsInRoleAsync(student16, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student16, "Student");
            }
            _db.SaveChanges();
            AppUser student17 = _db.Users.FirstOrDefault(u => u.Email == "linebacker@gogle.com");
            if (student17 == null)
            {
                student17 = new AppUser() { UserName = "linebacker@gogle.com", LastName = "Lineback", FirstName = "Erik", MiddleInitial = "W", Email = "linebacker@gogle.com", PositionType = "I", GraduationDate = 2022, GPA = 3.15m };
                student17.Active = true;
                student17.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Accounting");
                var result = await _userManager.CreateAsync(student17, "louielouie");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student17 = _db.Users.FirstOrDefault(u => u.UserName == "linebacker@gogle.com");
            }
            if (await _userManager.IsInRoleAsync(student17, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student17, "Student");
            }
            _db.SaveChanges();
            AppUser student18 = _db.Users.FirstOrDefault(u => u.Email == "elowe@netscare.net");
            if (student18 == null)
            {
                student18 = new AppUser() { UserName = "elowe@netscare.net", LastName = "Lowe", FirstName = "Ernest", MiddleInitial = "S", Email = "elowe@netscare.net", PositionType = "FT", GraduationDate = 2019, GPA = 3.07m };
                student18.Active = true;
                student18.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Finance");
                var result = await _userManager.CreateAsync(student18, "martin1234");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student18 = _db.Users.FirstOrDefault(u => u.UserName == "elowe@netscare.net");
            }
            if (await _userManager.IsInRoleAsync(student18, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student18, "Student");
            }
            _db.SaveChanges();
            AppUser student19 = _db.Users.FirstOrDefault(u => u.Email == "cluce@gogle.com");
            if (student19 == null)
            {
                student19 = new AppUser() { UserName = "cluce@gogle.com", LastName = "Luce", FirstName = "Chuck", MiddleInitial = "B", Email = "cluce@gogle.com", PositionType = "I", GraduationDate = 2020, GPA = 3.87m };
                student19.Active = true;
                student19.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Accounting");
                var result = await _userManager.CreateAsync(student19, "meganr34");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student19 = _db.Users.FirstOrDefault(u => u.UserName == "cluce@gogle.com");
            }
            if (await _userManager.IsInRoleAsync(student19, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student19, "Student");
            }
            _db.SaveChanges();
            AppUser student20 = _db.Users.FirstOrDefault(u => u.Email == "mackcloud@george.com");
            if (student20 == null)
            {
                student20 = new AppUser() { UserName = "mackcloud@george.com", LastName = "MacLeod", FirstName = "Jennifer", MiddleInitial = "D.", Email = "mackcloud@george.com", PositionType = "FT", GraduationDate = 2019, GPA = 4.0m };
                student20.Active = true;
                student20.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "MIS");
                var result = await _userManager.CreateAsync(student20, "meow88");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student20 = _db.Users.FirstOrDefault(u => u.UserName == "mackcloud@george.com");
            }
            if (await _userManager.IsInRoleAsync(student20, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student20, "Student");
            }
            _db.SaveChanges();
            AppUser student21 = _db.Users.FirstOrDefault(u => u.Email == "cmartin@beets.com");
            if (student21 == null)
            {
                student21 = new AppUser() { UserName = "cmartin@beets.com", LastName = "Markham", FirstName = "Elizabeth", MiddleInitial = "P.", Email = "cmartin@beets.com", PositionType = "FT", GraduationDate = 2019, GPA = 3.53m };
                student21.Active = true;
                student21.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Business Honors");
                var result = await _userManager.CreateAsync(student21, "mustangs");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student21 = _db.Users.FirstOrDefault(u => u.UserName == "cmartin@beets.com");
            }
            if (await _userManager.IsInRoleAsync(student21, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student21, "Student");
            }
            _db.SaveChanges();
            AppUser student22 = _db.Users.FirstOrDefault(u => u.Email == "clarence@yoho.com");
            if (student22 == null)
            {
                student22 = new AppUser() { UserName = "clarence@yoho.com", LastName = "Martin", FirstName = "Clarence", MiddleInitial = "A", Email = "clarence@yoho.com", PositionType = "I", GraduationDate = 2020, GPA = 3.11m };
                student22.Active = true;
                student22.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Supply Chain Management");
                var result = await _userManager.CreateAsync(student22, "mydogspot");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student22 = _db.Users.FirstOrDefault(u => u.UserName == "clarence@yoho.com");
            }
            if (await _userManager.IsInRoleAsync(student22, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student22, "Student");
            }
            _db.SaveChanges();
            AppUser student23 = _db.Users.FirstOrDefault(u => u.Email == "gregmartinez@drdre.com");
            if (student23 == null)
            {
                student23 = new AppUser() { UserName = "gregmartinez@drdre.com", LastName = "Martinez", FirstName = "Gregory", MiddleInitial = "R.", Email = "gregmartinez@drdre.com", PositionType = "I", GraduationDate = 2021, GPA = 3.43m };
                student23.Active = true;
                student23.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Business Honors");
                var result = await _userManager.CreateAsync(student23, "nothinggood");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student23 = _db.Users.FirstOrDefault(u => u.UserName == "gregmartinez@drdre.com");
            }
            if (await _userManager.IsInRoleAsync(student23, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student23, "Student");
            }
            _db.SaveChanges();
            AppUser student24 = _db.Users.FirstOrDefault(u => u.Email == "cmiller@bob.com");
            if (student24 == null)
            {
                student24 = new AppUser() { UserName = "cmiller@bob.com", LastName = "Miller", FirstName = "Charles", MiddleInitial = "R.", Email = "cmiller@bob.com", PositionType = "I", GraduationDate = 2020, GPA = 3.14m };
                student24.Active = true;
                student24.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Management");
                var result = await _userManager.CreateAsync(student24, "onetime");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student24 = _db.Users.FirstOrDefault(u => u.UserName == "cmiller@bob.com");
            }
            if (await _userManager.IsInRoleAsync(student24, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student24, "Student");
            }
            _db.SaveChanges();
            AppUser student25 = _db.Users.FirstOrDefault(u => u.Email == "knelson@aoll.com");
            if (student25 == null)
            {
                student25 = new AppUser() { UserName = "knelson@aoll.com", LastName = "Nelson", FirstName = "Kelly", MiddleInitial = "T", Email = "knelson@aoll.com", PositionType = "FT", GraduationDate = 2019, GPA = 3.03m };
                student25.Active = true;
                student25.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Finance");
                var result = await _userManager.CreateAsync(student25, "painting");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student25 = _db.Users.FirstOrDefault(u => u.UserName == "knelson@aoll.com");
            }
            if (await _userManager.IsInRoleAsync(student25, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student25, "Student");
            }
            _db.SaveChanges();
            AppUser student26 = _db.Users.FirstOrDefault(u => u.Email == "joewin@xfactor.com");
            if (student26 == null)
            {
                student26 = new AppUser() { UserName = "joewin@xfactor.com", LastName = "Nguyen", FirstName = "Joe", MiddleInitial = "C", Email = "joewin@xfactor.com", PositionType = "FT", GraduationDate = 2019, GPA = 3.65m };
                student26.Active = true;
                student26.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Management");
                var result = await _userManager.CreateAsync(student26, "Password1");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student26 = _db.Users.FirstOrDefault(u => u.UserName == "joewin@xfactor.com");
            }
            if (await _userManager.IsInRoleAsync(student26, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student26, "Student");
            }
            _db.SaveChanges();
            AppUser student27 = _db.Users.FirstOrDefault(u => u.Email == "orielly@foxnews.cnn");
            if (student27 == null)
            {
                student27 = new AppUser() { UserName = "orielly@foxnews.cnn", LastName = "O'Reilly", FirstName = "Bill", MiddleInitial = "T", Email = "orielly@foxnews.cnn", PositionType = "I", GraduationDate = 2020, GPA = 3.46m };
                student27.Active = true;
                student27.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Finance");
                var result = await _userManager.CreateAsync(student27, "penguin12");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student27 = _db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnews.cnn");
            }
            if (await _userManager.IsInRoleAsync(student27, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student27, "Student");
            }
            _db.SaveChanges();
            AppUser student28 = _db.Users.FirstOrDefault(u => u.Email == "ankaisrad@gogle.com");
            if (student28 == null)
            {
                student28 = new AppUser() { UserName = "ankaisrad@gogle.com", LastName = "Radkovich", FirstName = "Anka", MiddleInitial = "L", Email = "ankaisrad@gogle.com", PositionType = "FT", GraduationDate = 2019, GPA = 3.67m };
                student28.Active = true;
                student28.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Business Honors");
                var result = await _userManager.CreateAsync(student28, "pepperoni");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student28 = _db.Users.FirstOrDefault(u => u.UserName == "ankaisrad@gogle.com");
            }
            if (await _userManager.IsInRoleAsync(student28, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student28, "Student");
            }
            _db.SaveChanges();
            AppUser student29 = _db.Users.FirstOrDefault(u => u.Email == "megrhodes@freserve.co.uk");
            if (student29 == null)
            {
                student29 = new AppUser() { UserName = "megrhodes@freserve.co.uk", LastName = "Rhodes", FirstName = "Megan", MiddleInitial = "C.", Email = "megrhodes@freserve.co.uk", PositionType = "I", GraduationDate = 2020, GPA = 3.14m };
                student29.Active = true;
                student29.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Management");
                var result = await _userManager.CreateAsync(student29, "potato");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student29 = _db.Users.FirstOrDefault(u => u.UserName == "megrhodes@freserve.co.uk");
            }
            if (await _userManager.IsInRoleAsync(student29, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student29, "Student");
            }
            _db.SaveChanges();
            AppUser student30 = _db.Users.FirstOrDefault(u => u.Email == "erynrice@aoll.com");
            if (student30 == null)
            {
                student30 = new AppUser() { UserName = "erynrice@aoll.com", LastName = "Rice", FirstName = "Eryn", MiddleInitial = "M.", Email = "erynrice@aoll.com", PositionType = "I", GraduationDate = 2022, GPA = 3.92m };
                student30.Active = true;
                student30.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Marketing");
                var result = await _userManager.CreateAsync(student30, "radgirl");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student30 = _db.Users.FirstOrDefault(u => u.UserName == "erynrice@aoll.com");
            }
            if (await _userManager.IsInRoleAsync(student30, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student30, "Student");
            }
            _db.SaveChanges();
            AppUser student31 = _db.Users.FirstOrDefault(u => u.Email == "jorge@noclue.com");
            if (student31 == null)
            {
                student31 = new AppUser() { UserName = "jorge@noclue.com", LastName = "Rodriguez", FirstName = "Jorge", MiddleInitial = "", Email = "jorge@noclue.com", PositionType = "I", GraduationDate = 2021, GPA = 3.64m };
                student31.Active = true;
                student31.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "MIS");
                var result = await _userManager.CreateAsync(student31, "raiders");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student31 = _db.Users.FirstOrDefault(u => u.UserName == "jorge@noclue.com");
            }
            if (await _userManager.IsInRoleAsync(student31, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student31, "Student");
            }
            _db.SaveChanges();
            AppUser student32 = _db.Users.FirstOrDefault(u => u.Email == "mrrogers@lovelyday.com");
            if (student32 == null)
            {
                student32 = new AppUser() { UserName = "mrrogers@lovelyday.com", LastName = "Rogers", FirstName = "Allen", MiddleInitial = "B.", Email = "mrrogers@lovelyday.com", PositionType = "I", GraduationDate = 2020, GPA = 3.01m };
                student32.Active = true;
                student32.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Marketing");
                var result = await _userManager.CreateAsync(student32, "ricearoni");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student32 = _db.Users.FirstOrDefault(u => u.UserName == "mrrogers@lovelyday.com");
            }
            if (await _userManager.IsInRoleAsync(student32, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student32, "Student");
            }
            _db.SaveChanges();
            AppUser student33 = _db.Users.FirstOrDefault(u => u.Email == "stjean@athome.com");
            if (student33 == null)
            {
                student33 = new AppUser() { UserName = "stjean@athome.com", LastName = "Saint-Jean", FirstName = "Olivier", MiddleInitial = "M", Email = "stjean@athome.com", PositionType = "FT", GraduationDate = 2019, GPA = 3.24m };
                student33.Active = true;
                student33.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Science and Technology Management");
                var result = await _userManager.CreateAsync(student33, "rogerthat");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student33 = _db.Users.FirstOrDefault(u => u.UserName == "stjean@athome.com");
            }
            if (await _userManager.IsInRoleAsync(student33, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student33, "Student");
            }
            _db.SaveChanges();
            AppUser student34 = _db.Users.FirstOrDefault(u => u.Email == "saunders@pen.com");
            if (student34 == null)
            {
                student34 = new AppUser() { UserName = "saunders@pen.com", LastName = "Saunders", FirstName = "Sarah", MiddleInitial = "J.", Email = "saunders@pen.com", PositionType = "I", GraduationDate = 2020, GPA = 3.16m };
                student34.Active = true;
                student34.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Supply Chain Management");
                var result = await _userManager.CreateAsync(student34, "slowwind");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student34 = _db.Users.FirstOrDefault(u => u.UserName == "saunders@pen.com");
            }
            if (await _userManager.IsInRoleAsync(student34, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student34, "Student");
            }
            _db.SaveChanges();
            AppUser student35 = _db.Users.FirstOrDefault(u => u.Email == "willsheff@email.com");
            if (student35 == null)
            {
                student35 = new AppUser() { UserName = "willsheff@email.com", LastName = "Sewell", FirstName = "William", MiddleInitial = "T.", Email = "willsheff@email.com", PositionType = "FT", GraduationDate = 2019, GPA = 3.07m };
                student35.Active = true;
                student35.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "MIS");
                var result = await _userManager.CreateAsync(student35, "smitty444");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student35 = _db.Users.FirstOrDefault(u => u.UserName == "willsheff@email.com");
            }
            if (await _userManager.IsInRoleAsync(student35, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student35, "Student");
            }
            _db.SaveChanges();
            AppUser student36 = _db.Users.FirstOrDefault(u => u.Email == "sheffiled@gogle.com");
            if (student36 == null)
            {
                student36 = new AppUser() { UserName = "sheffiled@gogle.com", LastName = "Sheffield", FirstName = "Martin", MiddleInitial = "J.", Email = "sheffiled@gogle.com", PositionType = "I", GraduationDate = 2020, GPA = 3.36m };
                student36.Active = true;
                student36.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "MIS");
                var result = await _userManager.CreateAsync(student36, "snowsnow");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student36 = _db.Users.FirstOrDefault(u => u.UserName == "sheffiled@gogle.com");
            }
            if (await _userManager.IsInRoleAsync(student36, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student36, "Student");
            }
            _db.SaveChanges();
            AppUser student37 = _db.Users.FirstOrDefault(u => u.Email == "johnsmith187@aoll.com");
            if (student37 == null)
            {
                student37 = new AppUser() { UserName = "johnsmith187@aoll.com", LastName = "Smith", FirstName = "John", MiddleInitial = "A", Email = "johnsmith187@aoll.com", PositionType = "FT", GraduationDate = 2019, GPA = 3.57m };
                student37.Active = true;
                student37.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Finance");
                var result = await _userManager.CreateAsync(student37, "something");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student37 = _db.Users.FirstOrDefault(u => u.UserName == "johnsmith187@aoll.com");
            }
            if (await _userManager.IsInRoleAsync(student37, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student37, "Student");
            }
            _db.SaveChanges();
            AppUser student38 = _db.Users.FirstOrDefault(u => u.Email == "dustroud@mail.com");
            if (student38 == null)
            {
                student38 = new AppUser() { UserName = "dustroud@mail.com", LastName = "Stroud", FirstName = "Dustin", MiddleInitial = "P", Email = "dustroud@mail.com", PositionType = "I", GraduationDate = 2020, GPA = 3.49m };
                student38.Active = true;
                student38.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Marketing");
                var result = await _userManager.CreateAsync(student38, "spotmydog");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student38 = _db.Users.FirstOrDefault(u => u.UserName == "dustroud@mail.com");
            }
            if (await _userManager.IsInRoleAsync(student38, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student38, "Student");
            }
            _db.SaveChanges();
            AppUser student39 = _db.Users.FirstOrDefault(u => u.Email == "estuart@anchor.net");
            if (student39 == null)
            {
                student39 = new AppUser() { UserName = "estuart@anchor.net", LastName = "Stuart", FirstName = "Eric", MiddleInitial = "D.", Email = "estuart@anchor.net", PositionType = "FT", GraduationDate = 2019, GPA = 3.58m };
                student39.Active = true;
                student39.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Business Honors");
                var result = await _userManager.CreateAsync(student39, "stewball");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student39 = _db.Users.FirstOrDefault(u => u.UserName == "estuart@anchor.net");
            }
            if (await _userManager.IsInRoleAsync(student39, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student39, "Student");
            }
            _db.SaveChanges();
            AppUser student40 = _db.Users.FirstOrDefault(u => u.Email == "peterstump@noclue.com");
            if (student40 == null)
            {
                student40 = new AppUser() { UserName = "peterstump@noclue.com", LastName = "Stump", FirstName = "Peter", MiddleInitial = "L", Email = "peterstump@noclue.com", PositionType = "I", GraduationDate = 2021, GPA = 2.55m };
                student40.Active = true;
                student40.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Supply Chain Management");
                var result = await _userManager.CreateAsync(student40, "tanner5454");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student40 = _db.Users.FirstOrDefault(u => u.UserName == "peterstump@noclue.com");
            }
            if (await _userManager.IsInRoleAsync(student40, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student40, "Student");
            }
            _db.SaveChanges();
            AppUser student41 = _db.Users.FirstOrDefault(u => u.Email == "jtanner@mustang.net");
            if (student41 == null)
            {
                student41 = new AppUser() { UserName = "jtanner@mustang.net", LastName = "Tanner", FirstName = "Jeremy", MiddleInitial = "S.", Email = "jtanner@mustang.net", PositionType = "I", GraduationDate = 2020, GPA = 3.16m };
                student41.Active = true;
                student41.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Management");
                var result = await _userManager.CreateAsync(student41, "taylorbaylor");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student41 = _db.Users.FirstOrDefault(u => u.UserName == "jtanner@mustang.net");
            }
            if (await _userManager.IsInRoleAsync(student41, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student41, "Student");
            }
            _db.SaveChanges();
            AppUser student42 = _db.Users.FirstOrDefault(u => u.Email == "taylordjay@aoll.com");
            if (student42 == null)
            {
                student42 = new AppUser() { UserName = "taylordjay@aoll.com", LastName = "Taylor", FirstName = "Allison", MiddleInitial = "R.", Email = "taylordjay@aoll.com", PositionType = "FT", GraduationDate = 2019, GPA = 3.07m };
                student42.Active = true;
                student42.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Marketing");
                var result = await _userManager.CreateAsync(student42, "teeoff22");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student42 = _db.Users.FirstOrDefault(u => u.UserName == "taylordjay@aoll.com");
            }
            if (await _userManager.IsInRoleAsync(student42, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student42, "Student");
            }
            _db.SaveChanges();
            AppUser student43 = _db.Users.FirstOrDefault(u => u.Email == "rtaylor@gogle.com");
            if (student43 == null)
            {
                student43 = new AppUser() { UserName = "rtaylor@gogle.com", LastName = "Taylor", FirstName = "Rachel", MiddleInitial = "K.", Email = "rtaylor@gogle.com", PositionType = "I", GraduationDate = 2020, GPA = 2.88m };
                student43.Active = true;
                student43.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Finance");
                var result = await _userManager.CreateAsync(student43, "texas1");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student43 = _db.Users.FirstOrDefault(u => u.UserName == "rtaylor@gogle.com");
            }
            if (await _userManager.IsInRoleAsync(student43, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student43, "Student");
            }
            _db.SaveChanges();
            AppUser student44 = _db.Users.FirstOrDefault(u => u.Email == "teefrank@noclue.com");
            if (student44 == null)
            {
                student44 = new AppUser() { UserName = "teefrank@noclue.com", LastName = "Tee", FirstName = "Frank", MiddleInitial = "J", Email = "teefrank@noclue.com", PositionType = "FT", GraduationDate = 2019, GPA = 3.5m };
                student44.Active = true;
                student44.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Finance");
                var result = await _userManager.CreateAsync(student44, "toddy25");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student44 = _db.Users.FirstOrDefault(u => u.UserName == "teefrank@noclue.com");
            }
            if (await _userManager.IsInRoleAsync(student44, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student44, "Student");
            }
            _db.SaveChanges();
            AppUser student45 = _db.Users.FirstOrDefault(u => u.Email == "ctucker@alphabet.co.uk");
            if (student45 == null)
            {
                student45 = new AppUser() { UserName = "ctucker@alphabet.co.uk", LastName = "Tucker", FirstName = "Clent", MiddleInitial = "J", Email = "ctucker@alphabet.co.uk", PositionType = "I", GraduationDate = 2020, GPA = 3.04m };
                student45.Active = true;
                student45.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "MIS");
                var result = await _userManager.CreateAsync(student45, "tucksack1");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student45 = _db.Users.FirstOrDefault(u => u.UserName == "ctucker@alphabet.co.uk");
            }
            if (await _userManager.IsInRoleAsync(student45, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student45, "Student");
            }
            _db.SaveChanges();
            AppUser student46 = _db.Users.FirstOrDefault(u => u.Email == "avelasco@yoho.com");
            if (student46 == null)
            {
                student46 = new AppUser() { UserName = "avelasco@yoho.com", LastName = "Velasco", FirstName = "Allen", MiddleInitial = "G", Email = "avelasco@yoho.com", PositionType = "FT", GraduationDate = 2019, GPA = 3.55m };
                student46.Active = true;
                student46.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "MIS");
                var result = await _userManager.CreateAsync(student46, "vinovino");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student46 = _db.Users.FirstOrDefault(u => u.UserName == "avelasco@yoho.com");
            }
            if (await _userManager.IsInRoleAsync(student46, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student46, "Student");
            }
            _db.SaveChanges();
            AppUser student47 = _db.Users.FirstOrDefault(u => u.Email == "vinovino@grapes.com");
            if (student47 == null)
            {
                student47 = new AppUser() { UserName = "vinovino@grapes.com", LastName = "Vino", FirstName = "Janet", MiddleInitial = "E", Email = "vinovino@grapes.com", PositionType = "I", GraduationDate = 2021, GPA = 3.28m };
                student47.Active = true;
                student47.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Business Honors");
                var result = await _userManager.CreateAsync(student47, "whatever");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student47 = _db.Users.FirstOrDefault(u => u.UserName == "vinovino@grapes.com");
            }
            if (await _userManager.IsInRoleAsync(student47, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student47, "Student");
            }
            _db.SaveChanges();
            AppUser student48 = _db.Users.FirstOrDefault(u => u.Email == "winner@hootmail.com");
            if (student48 == null)
            {
                student48 = new AppUser() { UserName = "winner@hootmail.com", LastName = "Winthorpe", FirstName = "Louis", MiddleInitial = "L", Email = "winner@hootmail.com", PositionType = "FT", GraduationDate = 2019, GPA = 2.57m };
                student48.Active = true;
                student48.Major = _db.Majors.FirstOrDefault(c => c.MajorName == "Finance");
                var result = await _userManager.CreateAsync(student48, "woodyman1");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                student48 = _db.Users.FirstOrDefault(u => u.UserName == "winner@hootmail.com");
            }
            if (await _userManager.IsInRoleAsync(student48, "Student") == false)
            {
                await _userManager.AddToRoleAsync(student48, "Student");
            }
            _db.SaveChanges();


            AppUser recruiter1 = _db.Users.FirstOrDefault(u => u.Email == "michelle@example.com");
            if (recruiter1 == null)
            {
                recruiter1 = new AppUser() { UserName = "michelle@example.com", Email = "michelle@example.com", FirstName = "Michelle", LastName = "Banks", };
                recruiter1.Active = true;
                recruiter1.Company = _db.Companies.FirstOrDefault(c => c.CompanyName == "Accenture");
                var result = await _userManager.CreateAsync(recruiter1, "jVb0Z6");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                recruiter1 = _db.Users.FirstOrDefault(u => u.UserName == "michelle@example.com");
            }
            if (await _userManager.IsInRoleAsync(recruiter1, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(recruiter1, "Recruiter");
            }
            _db.SaveChanges();
            AppUser recruiter2 = _db.Users.FirstOrDefault(u => u.Email == "toddy@aool.com");
            if (recruiter2 == null)
            {
                recruiter2 = new AppUser() { UserName = "toddy@aool.com", Email = "toddy@aool.com", FirstName = "Todd", LastName = "Jacobs", };
                recruiter2.Active = true;
                recruiter2.Company = _db.Companies.FirstOrDefault(c => c.CompanyName == "Accenture");
                var result = await _userManager.CreateAsync(recruiter2, "1PnrBV");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                recruiter2 = _db.Users.FirstOrDefault(u => u.UserName == "toddy@aool.com");
            }
            if (await _userManager.IsInRoleAsync(recruiter2, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(recruiter2, "Recruiter");
            }
            _db.SaveChanges();
            AppUser recruiter3 = _db.Users.FirstOrDefault(u => u.Email == "elowe@netscrape.net");
            if (recruiter3 == null)
            {
                recruiter3 = new AppUser() { UserName = "elowe@netscrape.net", Email = "elowe@netscrape.net", FirstName = "Ernest", LastName = "Lowe", };
                recruiter3.Active = true;
                recruiter3.Company = _db.Companies.FirstOrDefault(c => c.CompanyName == "Shell");
                var result = await _userManager.CreateAsync(recruiter3, "v3n5AV");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                recruiter3 = _db.Users.FirstOrDefault(u => u.UserName == "elowe@netscrape.net");
            }
            if (await _userManager.IsInRoleAsync(recruiter3, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(recruiter3, "Recruiter");
            }
            _db.SaveChanges();
            AppUser recruiter4 = _db.Users.FirstOrDefault(u => u.Email == "mclarence@aool.com");
            if (recruiter4 == null)
            {
                recruiter4 = new AppUser() { UserName = "mclarence@aool.com", Email = "mclarence@aool.com", FirstName = "Clarence", LastName = "Martin", };
                recruiter4.Active = true;
                recruiter4.Company = _db.Companies.FirstOrDefault(c => c.CompanyName == "Deloitte");
                var result = await _userManager.CreateAsync(recruiter4, "zBLq3S");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                recruiter4 = _db.Users.FirstOrDefault(u => u.UserName == "mclarence@aool.com");
            }
            if (await _userManager.IsInRoleAsync(recruiter4, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(recruiter4, "Recruiter");
            }
            _db.SaveChanges();
            AppUser recruiter5 = _db.Users.FirstOrDefault(u => u.Email == "nelson.Kelly@aool.com");
            if (recruiter5 == null)
            {
                recruiter5 = new AppUser() { UserName = "nelson.Kelly@aool.com", Email = "nelson.Kelly@aool.com", FirstName = "Kelly", LastName = "Nelson", };
                recruiter5.Active = true;
                recruiter5.Company = _db.Companies.FirstOrDefault(c => c.CompanyName == "Deloitte");
                var result = await _userManager.CreateAsync(recruiter5, "FSb8rA");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                recruiter5 = _db.Users.FirstOrDefault(u => u.UserName == "nelson.Kelly@aool.com");
            }
            if (await _userManager.IsInRoleAsync(recruiter5, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(recruiter5, "Recruiter");
            }
            _db.SaveChanges();
            AppUser recruiter6 = _db.Users.FirstOrDefault(u => u.Email == "megrhodes@freezing.co.uk");
            if (recruiter6 == null)
            {
                recruiter6 = new AppUser() { UserName = "megrhodes@freezing.co.uk", Email = "megrhodes@freezing.co.uk", FirstName = "Megan", LastName = "Rhodes", };
                recruiter6.Active = true;
                recruiter6.Company = _db.Companies.FirstOrDefault(c => c.CompanyName == "Deloitte");
                var result = await _userManager.CreateAsync(recruiter6, "1xVfHp");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                recruiter6 = _db.Users.FirstOrDefault(u => u.UserName == "megrhodes@freezing.co.uk");
            }
            if (await _userManager.IsInRoleAsync(recruiter6, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(recruiter6, "Recruiter");
            }
            _db.SaveChanges();
            AppUser recruiter7 = _db.Users.FirstOrDefault(u => u.Email == "sheff44@ggmail.com");
            if (recruiter7 == null)
            {
                recruiter7 = new AppUser() { UserName = "sheff44@ggmail.com", Email = "sheff44@ggmail.com", FirstName = "Martin", LastName = "Sheffield", };
                recruiter7.Active = true;
                recruiter7.Company = _db.Companies.FirstOrDefault(c => c.CompanyName == "Texas Instruments");
                var result = await _userManager.CreateAsync(recruiter7, "4XKLsd");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                recruiter7 = _db.Users.FirstOrDefault(u => u.UserName == "sheff44@ggmail.com");
            }
            if (await _userManager.IsInRoleAsync(recruiter7, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(recruiter7, "Recruiter");
            }
            _db.SaveChanges();
            AppUser recruiter8 = _db.Users.FirstOrDefault(u => u.Email == "peterstump@hootmail.com");
            if (recruiter8 == null)
            {
                recruiter8 = new AppUser() { UserName = "peterstump@hootmail.com", Email = "peterstump@hootmail.com", FirstName = "Peter", LastName = "Stump", };
                recruiter8.Active = true;
                recruiter8.Company = _db.Companies.FirstOrDefault(c => c.CompanyName == "Texas Instruments");
                var result = await _userManager.CreateAsync(recruiter8, "1XdmSV");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                recruiter8 = _db.Users.FirstOrDefault(u => u.UserName == "peterstump@hootmail.com");
            }
            if (await _userManager.IsInRoleAsync(recruiter8, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(recruiter8, "Recruiter");
            }
            _db.SaveChanges();
            AppUser recruiter9 = _db.Users.FirstOrDefault(u => u.Email == "yhuik9.Taylor@aool.com");
            if (recruiter9 == null)
            {
                recruiter9 = new AppUser() { UserName = "yhuik9.Taylor@aool.com", Email = "yhuik9.Taylor@aool.com", FirstName = "Rachel", LastName = "Taylor", };
                recruiter9.Active = true;
                recruiter9.Company = _db.Companies.FirstOrDefault(c => c.CompanyName == "Hilton Worldwide");
                var result = await _userManager.CreateAsync(recruiter9, "9yhFS3");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                recruiter9 = _db.Users.FirstOrDefault(u => u.UserName == "yhuik9.Taylor@aool.com");
            }
            if (await _userManager.IsInRoleAsync(recruiter9, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(recruiter9, "Recruiter");
            }
            _db.SaveChanges();
            AppUser recruiter10 = _db.Users.FirstOrDefault(u => u.Email == "tuck33@ggmail.com");
            if (recruiter10 == null)
            {
                recruiter10 = new AppUser() { UserName = "tuck33@ggmail.com", Email = "tuck33@ggmail.com", FirstName = "Clent", LastName = "Tucker", };
                recruiter10.Active = true;
                recruiter10.Company = _db.Companies.FirstOrDefault(c => c.CompanyName == "Aon");
                var result = await _userManager.CreateAsync(recruiter10, "I6BgsS");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                recruiter10 = _db.Users.FirstOrDefault(u => u.UserName == "tuck33@ggmail.com");
            }
            if (await _userManager.IsInRoleAsync(recruiter10, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(recruiter10, "Recruiter");
            }
            _db.SaveChanges();
            AppUser recruiter11 = _db.Users.FirstOrDefault(u => u.Email == "taylordjay@aool.com");
            if (recruiter11 == null)
            {
                recruiter11 = new AppUser() { UserName = "taylordjay@aool.com", Email = "taylordjay@aool.com", FirstName = "Allison", LastName = "Taylor", };
                recruiter11.Active = true;
                recruiter11.Company = _db.Companies.FirstOrDefault(c => c.CompanyName == "Adlucent");
                var result = await _userManager.CreateAsync(recruiter11, "Vjb1wI");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                recruiter11 = _db.Users.FirstOrDefault(u => u.UserName == "taylordjay@aool.com");
            }
            if (await _userManager.IsInRoleAsync(recruiter11, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(recruiter11, "Recruiter");
            }
            _db.SaveChanges();
            AppUser recruiter12 = _db.Users.FirstOrDefault(u => u.Email == "jojoe@ggmail.com");
            if (recruiter12 == null)
            {
                recruiter12 = new AppUser() { UserName = "jojoe@ggmail.com", Email = "jojoe@ggmail.com", FirstName = "Joe", LastName = "Nguyen", };
                recruiter12.Active = true;
                recruiter12.Company = _db.Companies.FirstOrDefault(c => c.CompanyName == "Stream Realty Partners");
                var result = await _userManager.CreateAsync(recruiter12, "xI8Brg");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                recruiter12 = _db.Users.FirstOrDefault(u => u.UserName == "jojoe@ggmail.com");
            }
            if (await _userManager.IsInRoleAsync(recruiter12, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(recruiter12, "Recruiter");
            }
            _db.SaveChanges();
            AppUser recruiter13 = _db.Users.FirstOrDefault(u => u.Email == "hicks43@ggmail.com");
            if (recruiter13 == null)
            {
                recruiter13 = new AppUser() { UserName = "hicks43@ggmail.com", Email = "hicks43@ggmail.com", FirstName = "Anthony", LastName = "Hicks", };
                recruiter13.Active = true;
                recruiter13.Company = _db.Companies.FirstOrDefault(c => c.CompanyName == "Microsoft");
                var result = await _userManager.CreateAsync(recruiter13, "s33WOz");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                recruiter13 = _db.Users.FirstOrDefault(u => u.UserName == "hicks43@ggmail.com");
            }
            if (await _userManager.IsInRoleAsync(recruiter13, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(recruiter13, "Recruiter");
            }
            _db.SaveChanges();
            AppUser recruiter14 = _db.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com");
            if (recruiter14 == null)
            {
                recruiter14 = new AppUser() { UserName = "orielly@foxnets.com", Email = "orielly@foxnets.com", FirstName = "Bill", LastName = "O'Reilly", };
                recruiter14.Active = true;
                recruiter14.Company = _db.Companies.FirstOrDefault(c => c.CompanyName == "Microsoft");
                var result = await _userManager.CreateAsync(recruiter14, "pS2OJh");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                recruiter14 = _db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnets.com");
            }
            if (await _userManager.IsInRoleAsync(recruiter14, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(recruiter14, "Recruiter");
            }
            _db.SaveChanges();
            AppUser recruiter15 = _db.Users.FirstOrDefault(u => u.Email == "louielouie@aool.com");
            if (recruiter15 == null)
            {
                recruiter15 = new AppUser() { UserName = "louielouie@aool.com", Email = "louielouie@aool.com", FirstName = "Louis", LastName = "Winthorpe", };
                recruiter15.Active = true;
                recruiter15.Company = _db.Companies.FirstOrDefault(c => c.CompanyName == "Microsoft");
                var result = await _userManager.CreateAsync(recruiter15, "fq7yDw");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                recruiter15 = _db.Users.FirstOrDefault(u => u.UserName == "louielouie@aool.com");
            }
            if (await _userManager.IsInRoleAsync(recruiter15, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(recruiter15, "Recruiter");
            }
            _db.SaveChanges();
            AppUser recruiter16 = _db.Users.FirstOrDefault(u => u.Email == "smartinmartin.Martin@aool.com");
            if (recruiter16 == null)
            {
                recruiter16 = new AppUser() { UserName = "smartinmartin.Martin@aool.com", Email = "smartinmartin.Martin@aool.com", FirstName = "Gregory", LastName = "Martinez", };
                recruiter16.Active = true;
                recruiter16.Company = _db.Companies.FirstOrDefault(c => c.CompanyName == "Capital One");
                var result = await _userManager.CreateAsync(recruiter16, "1rKkMW");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                recruiter16 = _db.Users.FirstOrDefault(u => u.UserName == "smartinmartin.Martin@aool.com");
            }
            if (await _userManager.IsInRoleAsync(recruiter16, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(recruiter16, "Recruiter");
            }
            _db.SaveChanges();
            AppUser recruiter17 = _db.Users.FirstOrDefault(u => u.Email == "or@aool.com");
            if (recruiter17 == null)
            {
                recruiter17 = new AppUser() { UserName = "or@aool.com", Email = "or@aool.com", FirstName = "Anka", LastName = "Radkovich", };
                recruiter17.Active = true;
                recruiter17.Company = _db.Companies.FirstOrDefault(c => c.CompanyName == "Capital One");
                var result = await _userManager.CreateAsync(recruiter17, "8K0cAh");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                recruiter17 = _db.Users.FirstOrDefault(u => u.UserName == "or@aool.com");
            }
            if (await _userManager.IsInRoleAsync(recruiter17, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(recruiter17, "Recruiter");
            }
            _db.SaveChanges();
            AppUser recruiter18 = _db.Users.FirstOrDefault(u => u.Email == "tanner@ggmail.com");
            if (recruiter18 == null)
            {
                recruiter18 = new AppUser() { UserName = "tanner@ggmail.com", Email = "tanner@ggmail.com", FirstName = "Jeremy", LastName = "Tanner", };
                recruiter18.Active = true;
                recruiter18.Company = _db.Companies.FirstOrDefault(c => c.CompanyName == "United Airlines");
                var result = await _userManager.CreateAsync(recruiter18, "w9wPff");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                recruiter18 = _db.Users.FirstOrDefault(u => u.UserName == "tanner@ggmail.com");
            }
            if (await _userManager.IsInRoleAsync(recruiter18, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(recruiter18, "Recruiter");
            }
            _db.SaveChanges();
            AppUser recruiter19 = _db.Users.FirstOrDefault(u => u.Email == "tee_frank@hootmail.com");
            if (recruiter19 == null)
            {
                recruiter19 = new AppUser() { UserName = "tee_frank@hootmail.com", Email = "tee_frank@hootmail.com", FirstName = "Frank", LastName = "Tee", };
                recruiter19.Active = true;
                recruiter19.Company = _db.Companies.FirstOrDefault(c => c.CompanyName == "Academy Sports & Outdoors");
                var result = await _userManager.CreateAsync(recruiter19, "1EIwbx");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                recruiter19 = _db.Users.FirstOrDefault(u => u.UserName == "tee_frank@hootmail.com");
            }
            if (await _userManager.IsInRoleAsync(recruiter19, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(recruiter19, "Recruiter");
            }
            _db.SaveChanges();
            AppUser recruiter20 = _db.Users.FirstOrDefault(u => u.Email == "target_spot@example.com");
            if (recruiter20 == null)
            {
                recruiter20 = new AppUser() { UserName = "target_spot@example.com", Email = "target_spot@example.com", FirstName = "Spot", LastName = "Dog", };
                recruiter20.Active = true;
                recruiter20.Company = _db.Companies.FirstOrDefault(c => c.CompanyName == "Target");
                var result = await _userManager.CreateAsync(recruiter20, "spotthedog");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can not be added - " + result.ToString());
                }
                _db.SaveChanges();
                recruiter20 = _db.Users.FirstOrDefault(u => u.UserName == "target_spot@example.com");
            }
            if (await _userManager.IsInRoleAsync(recruiter20, "Recruiter") == false)
            {
                await _userManager.AddToRoleAsync(recruiter20, "Recruiter");
            }
            _db.SaveChanges();


        }
    }
}
