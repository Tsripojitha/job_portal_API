using jobportal;
using Microsoft.EntityFrameworkCore;
using RecruiterLogin;

namespace job_data // Correct namespace
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<emplogin> Emplogin { get; set; }
        public DbSet<recruiterlogin> Recruiterlogin { get; set; }
    }
}
