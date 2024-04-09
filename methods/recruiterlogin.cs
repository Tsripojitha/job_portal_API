using jobportal;
using job_data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using RecruiterLogin;

namespace recruiter_method
{
    public interface IRecruiterMethods
    {
        Task<string> AddRecruiterAsync(ApplicationDbContext context, recruiterlogin recruiter);
        Task<string> DeleteRecruiterByCompanyNameAsync(ApplicationDbContext context, string companyName);
        Task<recruiterlogin> ViewRecruiterByCompanyNameAsync(ApplicationDbContext context, string companyName);
    }
    public class RecruiterMethods : IRecruiterMethods
    {

        public async Task<string> AddRecruiterAsync(ApplicationDbContext context, recruiterlogin recruiter)
        {
            context.Recruiterlogin.Add(recruiter);
            await context.SaveChangesAsync();
            return "Recruiter added successfully";
        }

        public async Task<string> DeleteRecruiterByCompanyNameAsync(ApplicationDbContext context, string companyName)
        {
            var recruiter = await context.Recruiterlogin.FirstOrDefaultAsync(r => r.companyname == companyName);
            if (recruiter != null)
            {
                context.Recruiterlogin.Remove(recruiter);
                await context.SaveChangesAsync();
                return "Recruiter deleted successfully";
            }
            return "Recruiter not found";
        }

        public async Task<recruiterlogin> ViewRecruiterByCompanyNameAsync(ApplicationDbContext context, string companyName)
        {
            return await context.Recruiterlogin.FirstOrDefaultAsync(r => r.companyname == companyName);
        }
    }
}
