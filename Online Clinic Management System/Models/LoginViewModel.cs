using System.ComponentModel.DataAnnotations;

namespace Online_Clinic_Management_System.Models
{
    public class LoginViewModel
    {
        public int Id { get; set; }

        public string Username { get; set; }
        [Key]
        public string Password { get; set; }
    }
}
