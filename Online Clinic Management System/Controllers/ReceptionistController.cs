using Microsoft.AspNetCore.Mvc;
using Online_Clinic_Management_System.Models;

namespace Online_Clinic_Management_System.Controllers
{
    public class ReceptionistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ReceptionistViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Process the form data (e.g., save to database)
                // Here you can implement your logic to save receptionist details

                // Redirect to another page after successful submission
                return RedirectToAction("Success");
            }
            return View(model);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
