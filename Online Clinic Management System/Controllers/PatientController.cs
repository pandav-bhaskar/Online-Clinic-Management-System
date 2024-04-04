using Microsoft.AspNetCore.Mvc;
using Online_Clinic_Management_System.Models;

namespace Online_Clinic_Management_System.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PatientViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Handle form submission, e.g., save to database
            // Example: 
            // var name = model.Name;
            // var phoneNo = model.PhoneNo;
            // var email = model.Email;
            // var allergies = model.Allergies;
            // var gender = model.Gender;
            // var dateOfBirth = model.DateOfBirth;

            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
