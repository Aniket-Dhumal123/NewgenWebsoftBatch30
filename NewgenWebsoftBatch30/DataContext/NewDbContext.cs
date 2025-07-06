using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FinalNewProject.Models;

namespace FinalNewProject.DataContext
{
    public class NewDbContext: IdentityDbContext<ApplicationUser>
    {
        public NewDbContext(DbContextOptions<NewDbContext> options) : base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }  

        public DbSet<Employee> Employees { get; set; }

    }
}
