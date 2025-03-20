using SM.Domain.Models;

namespace SM.Domain.Interfaces.IRepository
{
    public interface IEmployeeRepository
    {
        public void AddEmployee();
        public void DeleteEmployee();
        //public IEnumerable<Employee> GetEmployees();
    }
}
