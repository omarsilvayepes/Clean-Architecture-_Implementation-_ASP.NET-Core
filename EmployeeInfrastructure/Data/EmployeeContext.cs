using EmployeeCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeInfrastructure.Data
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions <EmployeeContext> options) :base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
