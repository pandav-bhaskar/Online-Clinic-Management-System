using Microsoft.AspNetCore.Mvc;
using Online_Clinic_Management_System.Models;

namespace Online_Clinic_Management_System.Controllers
{
    public class PrescriptionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(PrescriptionViewModel model)
        {
            // Here you can handle the submitted data like saving to a database
            // For demonstration purposes, let's assume we redirect back to the index page
            return RedirectToAction("Index");
        }
    }
}
