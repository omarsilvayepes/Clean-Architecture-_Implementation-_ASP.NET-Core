namespace EmployeeCore.Interfaces
{
    public interface IEmployeeRepository :IRepository<EmployeeCore.Entities.Employee>
    {
        //Custom operation Here

        Task<List<EmployeeCore.Entities.Employee>> GetEmployeeByLastName(string lastName);
    }
}
