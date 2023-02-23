using EmployeeCore.Interfaces;
using EmployeeInfrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeeInfrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly EmployeeContext employeeContext;

        public Repository(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }

        public async Task<T> CreateAsync(T entity)
        {
            await employeeContext.Set<T>().AddAsync(entity);
            await employeeContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            employeeContext.Set<T>().Remove(entity);
            await employeeContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await employeeContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await employeeContext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            employeeContext.Set<T>().Update(entity);
            await employeeContext.SaveChangesAsync();
        }
    }
}
