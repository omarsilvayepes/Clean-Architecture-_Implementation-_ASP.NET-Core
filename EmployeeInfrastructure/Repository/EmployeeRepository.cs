using EmployeeCore.Entities;
using EmployeeCore.Interfaces;
using EmployeeInfrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeeInfrastructure.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        // public EmployeeRepository(EmployeeContext employeeContext):base(employeeContext) { }

        // remaining add packages sqlserver in this layer??

        protected readonly EmployeeContext employeeContext;

        public EmployeeRepository(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }

        public Task<Employee> CreateAsync(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Employee>> GetEmployeeByLastName(string lastName)
        {
            return await employeeContext.Employees.Where(employee=>employee.LastName==lastName).ToListAsync();
        }

        public Task UpdateAsync(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
