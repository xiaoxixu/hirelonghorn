using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using sp19team18finalproject.DAL;
using sp19team18finalproject.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace sp19team18finalproject.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private SignInManager<AppUser> _signInManager;
        private UserManager<AppUser> _userManager;
        private PasswordValidator<AppUser> _passwordValidator;
        private AppDbContext _db;

        public AccountController(AppDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signIn)
        {
            _db = context;
            _userManager = userManager;
            _signInManager = signIn;
            //user manager only has one password validator
            _passwordValidator = (PasswordValidator<AppUser>)userManager.PasswordValidators.FirstOrDefault();
        }


        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            if (User.Identity.IsAuthenticated) //user has been redirected here from a page they're not authorized to see
            {
                return View("Error", new string[] { "Access Denied" });
            }
            _signInManager.SignOutAsync(); //this removes any old cookies hanging around
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            AppUser student = _db.Users.FirstOrDefault(u => u.UserName == model.Email);
 

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                if (student.Active == false)
                {
                    return View("Error", new string[] { "Access Denied" });
                }
                else
                {
                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
                    if (result.Succeeded)
                    {
                        return Redirect(returnUrl ?? "/");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid login attempt.");
                        return View(model);
                    }
                }
            }
            catch
            {
                ModelState.AddModelError("", "Invalid login attempt.");
                return View(model);
            }

            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true
 
        }

        //---------------------------------------Register Student--------------------------------
        // GET: /Account/RegisterStudent
        [AllowAnonymous]
        public ActionResult Register()
        {
            ViewBag.AllMajors = GetAllMajors();
            return View();
        }

        //
        // POST: /Account/RegisterStudent
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model, int SelectedMajor, Classification SelectedPositionType)
        {
            Decimal decStudentGPA;
            Int32 intGraduationDate;
            try
            {
                decStudentGPA = Convert.ToDecimal(model.GPA);
            }
            catch  //this code will display when something is wrong
            {
                //Add a message for the viewbag
                ViewBag.Message1 = "GPA must be a valid decimal";

                //Re-populate dropdown
                ViewBag.AllMajors = GetAllMajors();

                //Send user back to home page
                return View("Register");
            }

            try
            {
                intGraduationDate = Convert.ToInt32(model.GraduationDate);
            }
            catch  //this code will display when something is wrong
            {
                //Add a message for the viewbag
                ViewBag.Message2 = "GraduationDate must be a valid number";

                //Re-populate dropdown
                ViewBag.AllMajors = GetAllMajors();

                //Send user back to home page
                return View("Register");
            }

            ModelState.Clear();
            Major major = _db.Majors.Find(SelectedMajor);
            model.Major = major;
            TryValidateModel(model);

            if (ModelState.IsValid)
            {
                AppUser user = new AppUser
                {
                    //TODO: Add the rest of the user fields here
                    UserName = model.Email,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Major = major,
                    GraduationDate = intGraduationDate,
                    PositionType = SelectedPositionType.ToString(),
                    GPA = decStudentGPA,
                    Active = true
                };

                IdentityResult result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    //TODO: Add user to desired role. This example adds the user to the customer role

                    await _userManager.AddToRoleAsync(user, "Student");

                    if (User.IsInRole("CSO"))
                    {
                        AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);
                        await _signInManager.SignInAsync(userLoggedIn, isPersistent: false);
                    }

                    else
                    {
                        Microsoft.AspNetCore.Identity.SignInResult result2 = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, lockoutOnFailure: false);                        
                    }
                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            //re-populate the Viewbag in case there is an error
            ViewBag.AllMajors = GetAllMajors();
            return View(model);
        }


        // GET: /Account/RegisterRecruiter
        [Authorize(Roles = "CSO")]
        public ActionResult RegisterRecruiter()
        {
            ViewBag.AllCompanies = GetAllCompanies();
            return View();
        }

        //
        // POST: /Account/RegisterRecruiter
        [HttpPost]
        [Authorize(Roles = "CSO")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RegisterRecruiter(RegisterRecruiterViewModel model, int SelectedCompany)
        {

            ModelState.Clear();
            Company company = _db.Companies.Find(SelectedCompany);
            model.Company = company;
            TryValidateModel(model);

            if (ModelState.IsValid)
            {
                AppUser user = new AppUser
                {
                    //TODO: Add the rest of the user fields here
                    UserName = model.Email,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Company = company,
                    Active = true
                };

                IdentityResult result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    //TODO: Add user to desired role. This example adds the user to the customer role
                    await _userManager.AddToRoleAsync(user, "Recruiter");

                    //Microsoft.AspNetCore.Identity.SignInResult result2 = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, lockoutOnFailure: false);

                    AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);
                    await _signInManager.SignInAsync(userLoggedIn, isPersistent: false);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            //re-populate the Viewbag in case there is an error
            ViewBag.AllCompanies = GetAllCompanies();
            return View(model);
        }


        // GET: /Account/RegisterCSO
        [Authorize(Roles = "CSO")]
        public ActionResult RegisterCSO()
        {
            return View();
        }

        //
        // POST: /Account/RegisterCSO
        [HttpPost]
        [Authorize(Roles = "CSO")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RegisterCSO(RegisterCSOViewModel model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser
                {
                    //TODO: Add the rest of the user fields here
                    UserName = model.Email,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Active = true

                };
                IdentityResult result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    //TODO: Add user to desired role. This example adds the user to the customer role
                    await _userManager.AddToRoleAsync(user, "CSO");

                    //Microsoft.AspNetCore.Identity.SignInResult result2 = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, lockoutOnFailure: false);

                    AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);
                    await _signInManager.SignInAsync(userLoggedIn, isPersistent: false);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }

        //---------------------create lists-----------------------------
        public SelectList GetAllMajors()
        {
            List<Major> Majors = _db.Majors.ToList();

            SelectList AllMajors = new SelectList(Majors.OrderBy(m => m.MajorID), "MajorID", "MajorName");

            return AllMajors;
        }

        public SelectList GetAllMajors(int intMajorID)
        {
            List<Major> Majors = _db.Majors.ToList();

            SelectList AllMajors = new SelectList(Majors.OrderBy(m => m.MajorID), "MajorID", "MajorName", intMajorID);

            return AllMajors;
        }

        public SelectList GetAllCompanies()
        {
            List<Company> companies = _db.Companies.ToList();

            SelectList AllCompanies = new SelectList(companies.OrderBy(c => c.CompanyID), "CompanyID", "CompanyName");

            return AllCompanies;
        }

        public SelectList GetAllCompanies(int intComanyID)
        {
            List<Company> companies = _db.Companies.ToList();
            //companies.RemoveAt(0);

            SelectList AllCompanies = new SelectList(companies.OrderBy(c => c.CompanyID), "CompanyID", "CompanyName", intComanyID);

            return AllCompanies;
        }

        //------------------------------------index-----------------------------------------
        //GET: Account/Index
        public ActionResult Index()
        {
            IndexViewModel ivm = new IndexViewModel();

            //get user info
            String id = User.Identity.Name;
            AppUser user = _db.Users.Include(u=> u.Major).Include(u => u.Company).FirstOrDefault(u => u.UserName == id);

            //populate the view model
            ivm.Email = user.Email;
            ivm.HasPassword = true;
            ivm.UserID = user.Id;
            ivm.UserName = user.UserName;
            ivm.FirstName = user.FirstName;
            ivm.LastName = user.LastName;
            ivm.GraduationDate = user.GraduationDate;
            ivm.GPA = user.GPA;
            ivm.PositionType = user.PositionType;
            ivm.Major = user.Major;
            ivm.Company = user.Company;

            return View(ivm);
        }


        //Logic for change password
        // GET: /Account/ChangePassword
        public ActionResult ChangePassword()
        {
            return View();
        }

        //
        // POST: /Account/ChangePassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);
            var result = await _userManager.ChangePasswordAsync(userLoggedIn, model.OldPassword, model.NewPassword);
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(userLoggedIn, isPersistent: false);
                return RedirectToAction("Index", "Home");
            }
            AddErrors(result);
            return View(model);
        }

        //-----------------------------------------edit student-----------------------------------------------------
        // GET: student/Edit/5
        [Authorize(Roles = "Student")]
        public ActionResult EditStudentProfile()
        {
            AppUser student = _db.Users.Include(u => u.Major).FirstOrDefault(u => u.UserName == User.Identity.Name);
            EditStudentProfileViewModel esvm = new EditStudentProfileViewModel();
            esvm.Email = student.Email;
            esvm.FirstName = student.FirstName;
            esvm.LastName = student.LastName;
            esvm.GraduationDate = student.GraduationDate.ToString();
            esvm.Major = student.Major;
            esvm.GPA = student.GPA.ToString();

            if (student.PositionType == "FT")
            {
                esvm.PositionType = Classification.FT;
            }
            if (student.PositionType == "I")
            {
                esvm.PositionType = Classification.I;
            }

            ViewBag.AllMajors = GetAllMajors(student.Major.MajorID);
            return View(esvm);
        }

        // POST: student/Edit/5
        [HttpPost]
        [Authorize(Roles = "Student")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditStudentProfile(EditStudentProfileViewModel model, int SelectedMajor, Classification SelectedPositionType)
        {
            Decimal newdecStudentGPA;
            Int32 newintGraduationDate;
            try
            {
                newdecStudentGPA = Convert.ToDecimal(model.GPA);
            }
            catch  //this code will display when something is wrong
            {
                //Add a message for the viewbag
                ViewBag.Message3 = "GPA must be a valid decimal";

                //Re-populate dropdown
                ViewBag.AllMajors = GetAllMajors(SelectedMajor);

                //Send user back to home page
                return View(model);
            }

            try
            {
                newintGraduationDate = Convert.ToInt32(model.GraduationDate);
            }
            catch  //this code will display when something is wrong
            {
                //Add a message for the viewbag
                ViewBag.Message4 = "GraduationDate must be a valid number";

                //Re-populate dropdown
                ViewBag.AllMajors = GetAllMajors(SelectedMajor);

                //Send user back to home page
                return View(model);
            }

            ModelState.Clear();
            Major newMajor = _db.Majors.Find(SelectedMajor);

            /*
            if (SelectedPositionType == Classification.FT)
            {
                model.PositionType = "FT";
            }
            else
            {
                model.PositionType = "I";
            }*/

            model.Major = newMajor;
            TryValidateModel(model);

            if (!ModelState.IsValid)
            {
                ViewBag.AllMajors = GetAllMajors(SelectedMajor);
                return View(model);
            }

            if (ModelState.IsValid)
            {
                AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);
                userLoggedIn.FirstName = model.FirstName;
                userLoggedIn.LastName = model.LastName;
                userLoggedIn.Email = model.Email;
                userLoggedIn.Major = newMajor;
                userLoggedIn.GraduationDate = newintGraduationDate;
                userLoggedIn.PositionType = SelectedPositionType.ToString();
                userLoggedIn.GPA = newdecStudentGPA;


                IdentityResult editresult = await _userManager.UpdateAsync(userLoggedIn);
                if (editresult.Succeeded)
                {
                    await _signInManager.SignInAsync(userLoggedIn, isPersistent: false);
                    return RedirectToAction("Index", "Account");
                }
                else
                {
                    foreach (IdentityError error in editresult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            //re-populate the Viewbag in case there is an error
            ViewBag.AllMajors = GetAllMajors(SelectedMajor);
            return View(model);
        }


        // GET: /recruiter/edit
        [Authorize(Roles = "Recruiter")]
        public ActionResult EditRecruiterProfile()
        {
            AppUser recruiter = _db.Users.Include(u => u.Company).FirstOrDefault(u => u.UserName == User.Identity.Name);
            EditRecruiterProfileViewModel ervm = new EditRecruiterProfileViewModel();
            ervm.Email = recruiter.Email;
            ervm.FirstName = recruiter.FirstName;
            ervm.LastName = recruiter.LastName;
            //ervm.Company= recruiter.Company;

            //ViewBag.AllCompanies = GetAllCompanies(recruiter.Company.CompanyID);
            return View(ervm);
        }

        //
        // POST: /recruiter/edit
        [HttpPost]
        [Authorize(Roles = "Recruiter")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditRecruiterProfile(EditRecruiterProfileViewModel model)
        {

            ModelState.Clear();
            //Company newCompany = _db.Companies.Find(SelectedCompany);
            //model.Company = newCompany;
            TryValidateModel(model);

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (ModelState.IsValid)
            {
                AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);
                userLoggedIn.FirstName = model.FirstName;
                userLoggedIn.LastName = model.LastName;
                userLoggedIn.Email = model.Email;
                //userLoggedIn.Company = newCompany;

                IdentityResult editresult = await _userManager.UpdateAsync(userLoggedIn);
                if (editresult.Succeeded)
                {
                    await _signInManager.SignInAsync(userLoggedIn, isPersistent: false);
                    return RedirectToAction("Index", "Account");
                }
                else
                {
                    foreach (IdentityError error in editresult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            //re-populate the Viewbag in case there is an error
            ViewBag.AllCompanies = GetAllCompanies();
            return View(model);
        }

        // GET: cso/Edit/5
        [Authorize(Roles = "CSO")]
        public ActionResult EditCSOProfile()
        {
            AppUser CSO = _db.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            EditCSOProfileViewModel ecvm = new EditCSOProfileViewModel();
            ecvm.Email = CSO.Email;
            ecvm.FirstName = CSO.FirstName;
            ecvm.LastName = CSO.LastName;

            return View(ecvm);
        }

        // POST: cso/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "CSO")]
        public async Task<IActionResult> EditCSOProfile(EditCSOProfileViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (ModelState.IsValid)
            {
                AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);
                userLoggedIn.FirstName = model.FirstName;
                userLoggedIn.LastName = model.LastName;
                userLoggedIn.Email = model.Email;

                IdentityResult editresult = await _userManager.UpdateAsync(userLoggedIn);
                if (editresult.Succeeded)
                {
                    await _signInManager.SignInAsync(userLoggedIn, isPersistent: false);
                    return RedirectToAction("Index", "Account");
                }
                else
                {
                    foreach (IdentityError error in editresult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                        //ModelState.AddModelError("", error.Description);
                    }
                }
            }
            //re-populate the Viewbag in case there is an error
            return View(model);
        }


        //GET:/Account/AccessDenied
        public ActionResult AccessDenied(String ReturnURL)
        {
            return View("Error", new string[] { "Access is denied" });
        }

        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "CSO")]
        public ActionResult Deactivate(string id)
        {
            AppUser appUser = _db.Users.FirstOrDefault(u => u.Id == id);
            appUser.Active = false;
            _db.SaveChanges();
            return View();
        }

        [Authorize(Roles = "CSO")]
        public ActionResult Reactivate(string id)
        {
            AppUser appUser = _db.Users.FirstOrDefault(u => u.Id == id);
            appUser.Active = true;
            _db.SaveChanges();
            return View();
        }

        // GET: cso/Edit/5
        [Authorize(Roles = "CSO")]
        public ActionResult EditOtherCSOProfile(string id)
        {
            try
            {
                AppUser CSO = _db.Users.FirstOrDefault(u => u.Id == id);
                EditCSOProfileViewModel ecvm = new EditCSOProfileViewModel();
                ecvm.Email = CSO.Email;
                ecvm.FirstName = CSO.FirstName;
                ecvm.LastName = CSO.LastName;

                return View(ecvm);
            }

            catch
            {
                return NotFound();
            }
        }

        // POST: cso/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "CSO")]
        public async Task<IActionResult> EditOtherCSOProfile(string id, EditCSOProfileViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }


            if (ModelState.IsValid)
            {
                AppUser CSOEditing = await _userManager.FindByIdAsync(id);
                CSOEditing.FirstName = model.FirstName;
                CSOEditing.LastName = model.LastName;
                CSOEditing.Email = model.Email;

                IdentityResult editresult = await _userManager.UpdateAsync(CSOEditing);
                if (editresult.Succeeded)
                {
                    //await _signInManager.SignInAsync(CSOEditing, isPersistent: false);
                    return RedirectToAction("Index", "CSOs");
                }
                else
                {
                    foreach (IdentityError error in editresult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            //re-populate the Viewbag in case there is an error
            return View(model);
        }

        // GET: /recruiter/edit
        [Authorize(Roles = "CSO")]
        public ActionResult CSOEditRecruiterProfile(string id)
        {
            try
            {
                AppUser recruiter = _db.Users.Include(u => u.Company).FirstOrDefault(u => u.Id == id);

                CSOEditRecruiterProfileViewModel cervm = new CSOEditRecruiterProfileViewModel();
                cervm.Email = recruiter.Email;
                cervm.FirstName = recruiter.FirstName;
                cervm.LastName = recruiter.LastName;
                cervm.Company = recruiter.Company;

                ViewBag.AllCompanies = GetAllCompanies(recruiter.Company.CompanyID);
                return View(cervm);
            }

            catch
            {
                return NotFound();
            }
        }

        //
        // POST: /recruiter/edit
        [HttpPost]
        [Authorize(Roles = "CSO")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CSOEditRecruiterProfile(string id, CSOEditRecruiterProfileViewModel model,int SelectedCompany)
        {

            ModelState.Clear();
            Company newCompany = _db.Companies.Find(SelectedCompany);
            model.Company = newCompany;
            TryValidateModel(model);

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (ModelState.IsValid)
            {
                AppUser CSOEditRecruiter = await _userManager.FindByIdAsync(id);
                CSOEditRecruiter.FirstName = model.FirstName;
                CSOEditRecruiter.LastName = model.LastName;
                CSOEditRecruiter.Email = model.Email;
                CSOEditRecruiter.Company = newCompany;

                IdentityResult editresult = await _userManager.UpdateAsync(CSOEditRecruiter);
                if (editresult.Succeeded)
                {
                    AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);
                    await _signInManager.SignInAsync(userLoggedIn, isPersistent: false);
                    return RedirectToAction("Index", "Recruiters");
                }
                else
                {
                    foreach (IdentityError error in editresult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            //re-populate the Viewbag in case there is an error
            ViewBag.AllCompanies = GetAllCompanies();
            return View(model);
        }

        [Authorize(Roles = "CSO")]
        public ActionResult CSOEditStudentProfile(string id)
        {
            try
            {
                AppUser student = _db.Users
                           .Include(u => u.Major)
                           .FirstOrDefault(u => u.Id == id);

                EditStudentProfileViewModel cesvm = new EditStudentProfileViewModel();
                cesvm.Email = student.Email;
                cesvm.FirstName = student.FirstName;
                cesvm.LastName = student.LastName;
                cesvm.GraduationDate = student.GraduationDate.ToString();
                cesvm.Major = student.Major;
                cesvm.GPA = student.GPA.ToString();

                if (student.PositionType == "FT")
                {
                    cesvm.PositionType = Classification.FT;
                }
                if (student.PositionType == "I")
                {
                    cesvm.PositionType = Classification.I;
                }

                //add the rest of the fields on evm from student
                ViewBag.AllMajors = GetAllMajors(student.Major.MajorID);
                //add evm in the ()
                return View(cesvm);
            }

            catch
            {
                return NotFound();
            }
               
        }

        // POST: student/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "CSO")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CSOEditStudentProfile(string id, EditStudentProfileViewModel model, int SelectedMajor, Classification SelectedPositionType)
        {
            Decimal newdecStudentGPA;
            Int32 newintGraduationDate;
            try
            {
                newdecStudentGPA = Convert.ToDecimal(model.GPA);
            }
            catch  //this code will display when something is wrong
            {
                //Add a message for the viewbag
                ViewBag.Message5 = "GPA must be a valid decimal";

                //Re-populate dropdown
                ViewBag.AllMajors = GetAllMajors(SelectedMajor);

                //Send user back to home page
                return View(model);
            }

            try
            {
                newintGraduationDate = Convert.ToInt32(model.GraduationDate);
            }
            catch  //this code will display when something is wrong
            {
                //Add a message for the viewbag
                ViewBag.Message6 = "GraduationDate must be a valid number";

                //Re-populate dropdown
                ViewBag.AllMajors = GetAllMajors(SelectedMajor);

                //Send user back to home page
                return View(model);
            }

            ModelState.Clear();
            Major newMajor = _db.Majors.Find(SelectedMajor);

            /*
            if (SelectedPositionType == Classification.FT)
            {
                model.PositionType = "FT";
            }
            else
            {
                model.PositionType = "I";
            }*/

            model.Major = newMajor;
            TryValidateModel(model);

            if (!ModelState.IsValid)
            {
                ViewBag.AllMajors = GetAllMajors(SelectedMajor);
                return View(model);
            }


            if (ModelState.IsValid)
            {
                AppUser CSOEditStudent = await _userManager.FindByIdAsync(id);
                CSOEditStudent.FirstName = model.FirstName;
                CSOEditStudent.LastName = model.LastName;
                CSOEditStudent.Email = model.Email;
                CSOEditStudent.Major = newMajor;
                CSOEditStudent.GraduationDate = newintGraduationDate;
                CSOEditStudent.PositionType = SelectedPositionType.ToString();
                CSOEditStudent.GPA = newdecStudentGPA;


                IdentityResult editresult = await _userManager.UpdateAsync(CSOEditStudent);
                if (editresult.Succeeded)
                {
                    AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);
                    await _signInManager.SignInAsync(userLoggedIn, isPersistent: false);
                    return RedirectToAction("Index", "StudentSearch");
                }
                else
                {
                    foreach (IdentityError error in editresult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            //re-populate the Viewbag in case there is an error
            ViewBag.AllMajors = GetAllMajors(SelectedMajor);
            return View(model);
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
    }
}
