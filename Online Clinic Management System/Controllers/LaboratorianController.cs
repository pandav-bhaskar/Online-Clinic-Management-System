using Microsoft.AspNetCore.Mvc;

namespace Online_Clinic_Management_System.Controllers
{
    public class LaboratorianController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // You can define separate actions for different clicks if needed
        // For simplicity, I'll handle all clicks in one action

        [HttpPost]
        public IActionResult HandleClick(string clickedElement)
        {
            switch (clickedElement)
            {
                case "receptionist":
                    return Redirect("./receptionist.html");
                case "about":
                    return Redirect("./about.html");
                case "register":
                    return Redirect("./register.html");
                case "login":
                    return Redirect("./login.html");
                case "logout":
                    return Redirect("./login.html");
                case "laboratorian":
                    return Redirect("./laboratorian.html");
                case "doctor":
                    return Redirect("./doc-detail.html");
                default:
                    // Handle if no matching case found
                    return BadRequest("Invalid clicked element.");
            }
        }
    }
}
