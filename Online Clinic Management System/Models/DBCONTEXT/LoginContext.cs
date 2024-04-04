using Microsoft.EntityFrameworkCore;

namespace Online_Clinic_Management_System.Models.DBCONTEXT
{
    public class LoginContext : DbContext
    {
       

        public LoginContext(DbContextOptions<LoginContext> options) :base(options)
        {
                
        }

        public DbSet<LoginViewModel> Logins { get; set; }
        public DbSet<RegisterViewModel> Users1 { get; set; }

    }
}

