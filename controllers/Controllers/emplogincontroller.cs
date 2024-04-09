using job_data;
using emplogin_method;
using jobportal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

[ApiController]
[Route("[controller]/[action]")]
public class EmployeeController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IEmployeeMethods _employeeMethods;

    public EmployeeController(ApplicationDbContext context, IEmployeeMethods employeeMethods)
    {
        _context = context;
        _employeeMethods = employeeMethods;
    }

    [HttpPost]
    public async Task<string> AddEmployeeAsync(emplogin employee)
    {
        return await _employeeMethods.AddEmployeeAsync(_context, employee);
    }

    [HttpDelete("{username}")]
    public async Task<string> DeleteEmployeeByUsernameAsync(string username)
    {
        return await _employeeMethods.DeleteEmployeeByUsernameAsync(_context, username);
    }

    [HttpGet("{username}")]
    public async Task<ActionResult<emplogin>> ViewEmployeeByUsernameAsync(string username)
    {
        var employee = await _employeeMethods.ViewEmployeeByUsernameAsync(_context, username);
        if (employee == null)
            return NotFound();
        return employee;
    }
}
