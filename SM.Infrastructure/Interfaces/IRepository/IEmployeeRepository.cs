
using SM.Infrastructure.Models;

namespace SM.Infrastructure.Interfaces.IRepository
{
    public interface IEmployeeRepository
    {
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> DeleteEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        Task<List<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(Guid id);

    }
}
