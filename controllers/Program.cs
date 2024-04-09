
using emplogin_method;
using job_data;
using Microsoft.EntityFrameworkCore;
using recruiter_method;

namespace Health_Controllers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //builder.Services.AddScoped<EmployeeController>();

            builder.Services.AddScoped<IEmployeeMethods, EmployeeMethods>();

            builder.Services.AddScoped<IRecruiterMethods, RecruiterMethods>();
            builder.Services.AddEntityFrameworkNpgsql().AddDbContext<ApplicationDbContext>(Options =>
            {
                Options.UseNpgsql(
                    connectionString: "Server=localhost; Port = 5432; User Id = postgres; Password=1234;Database= poojithadatabase; Pooling = true;");
            });
            
            var app = builder.Build();
            app.UseCors(options => options
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}