using Microsoft.AspNetCore.Mvc;
using Online_Clinic_Management_System.Models;

namespace Online_Clinic_Management_System.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            // Perform login logic here
            if (model.Username == "admin" && model.Password == "adminpassword")
            {
                // Redirect to admin page if login is successful
                return RedirectToAction("Admin", "Home");
            }
            else
            {
                // Redirect to login page with error message if login fails
                TempData["ErrorMessage"] = "Invalid username or password";
                return RedirectToAction("Index");
            }
        }

    }
}
