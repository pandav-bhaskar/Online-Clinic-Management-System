using Microsoft.AspNetCore.Mvc;
using Online_Clinic_Management_System.Models;
using Online_Clinic_Management_System.Models.DBCONTEXT;
using System;

namespace Online_Clinic_Management_System.Controllers
{
    public class RegisterController : Controller
    {
        private readonly LoginContext _context;

        public RegisterController(LoginContext context)
        {
            _context = context;
        }

        // GET: /Home/Index
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Home/Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Home/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                // Assuming RegisterViewModel maps to your database model
                var user1 = new User
                {
                    Name = registerViewModel.Name,
                    Email = registerViewModel.Email,
                    // Map other properties as needed
                };

                _context.Users1.Add(user1);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(registerViewModel);
        }

        // GET: /Home/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Home/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                // Your login logic here
                // Redirect to appropriate page upon successful login
                return RedirectToAction("Index");
            }
            return View(loginViewModel);
        }

        // Other controller actions...
    }
}
