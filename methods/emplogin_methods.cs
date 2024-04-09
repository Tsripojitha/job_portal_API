using jobportal;
using job_data; 
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace emplogin_method // Correct namespace
{
    public interface IEmployeeMethods
    {
        Task<string> AddEmployeeAsync(ApplicationDbContext context, emplogin employee);
        Task<string> DeleteEmployeeByUsernameAsync(ApplicationDbContext context, string username);
        Task<emplogin> ViewEmployeeByUsernameAsync(ApplicationDbContext context, string username);
    }
    public class EmployeeMethods: IEmployeeMethods
    {
        public async Task<string> AddEmployeeAsync(ApplicationDbContext context, emplogin employee)
        {
            context.Emplogin.Add(employee);
            await context.SaveChangesAsync();
            return "Employee added successfully";
        }

        public async Task<string> DeleteEmployeeByUsernameAsync(ApplicationDbContext context, string username)
        {
            var employee = await context.Emplogin.FirstOrDefaultAsync(e => e.username == username);
            if (employee != null)
            {
                context.Emplogin.Remove(employee);
                await context.SaveChangesAsync();
                return "Employee deleted successfully";
            }
            return "Employee not found";
        }

        public async Task<emplogin> ViewEmployeeByUsernameAsync(ApplicationDbContext context, string username)
        {
            return await context.Emplogin.FirstOrDefaultAsync(e => e.username == username);
        }
    }
}

