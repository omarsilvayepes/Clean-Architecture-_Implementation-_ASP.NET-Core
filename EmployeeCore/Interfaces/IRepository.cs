namespace EmployeeCore.Interfaces
{
    public interface IRepository <T> where T : class
    {
        //Generic interface

        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync (int id);
        Task<T> CreateAsync(T entity);
        Task UpdateAsync (T entity);
        Task DeleteAsync(T entity);

    }
 
}
