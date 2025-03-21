using SM.Domain.Models;

namespace SM.Domain.Interfaces.IRepository
{
    public interface IEmployeeRepository
    {
        public void AddEmployee(Employee employee);
        public void DeleteEmployee(Employee employee);
        //public IEnumerable<Employee> GetEmployees();
    }
}
