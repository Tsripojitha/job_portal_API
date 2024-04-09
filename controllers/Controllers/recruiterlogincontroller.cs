using job_data;
using recruiter_method;
using jobportal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using RecruiterLogin;

[ApiController]
[Route("[controller]/[action]")]
public class RecruiterController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IRecruiterMethods _recruiterMethods;

    public RecruiterController(ApplicationDbContext context, IRecruiterMethods recruiterMethods)
    {
        _context = context;
        _recruiterMethods = recruiterMethods;
    }

    [HttpPost]
    public async Task<string> AddRecruiterAsync(recruiterlogin recruiter)
    {
        return await _recruiterMethods.AddRecruiterAsync(_context, recruiter);
    }

    [HttpDelete("{companyName}")]
    public async Task<string> DeleteRecruiterByCompanyNameAsync(string companyName)
    {
        return await _recruiterMethods.DeleteRecruiterByCompanyNameAsync(_context, companyName);
    }

    [HttpGet("{companyName}")]
    public async Task<ActionResult<recruiterlogin>> ViewRecruiterByCompanyNameAsync(string companyName)
    {
        var recruiter = await _recruiterMethods.ViewRecruiterByCompanyNameAsync(_context, companyName);
        if (recruiter == null)
            return NotFound();
        return recruiter;
    }
}
