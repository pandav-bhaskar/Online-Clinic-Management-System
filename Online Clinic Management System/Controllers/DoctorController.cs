using Microsoft.AspNetCore.Mvc;
using Online_Clinic_Management_System.Models;
using System.Numerics;

namespace Online_Clinic_Management_System.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Registration
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(DoctorViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Save registration data or perform registration logic here
                // For demonstration purpose, let's redirect to login page
                return RedirectToAction("Login", "Account");
            }
            return View(model);
        }
    }
}
