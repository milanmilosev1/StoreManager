using SM.Domain.Interfaces.IRepository;
using SM.Domain.Models;
using SM.Infrastructure.Context;

namespace SM.Infrastructure.Repositories
{
    public class EmployeeRepository(StoreDbContext context) : IEmployeeRepository
    {
        private readonly StoreDbContext Context = context;
        public void AddEmployee(Employee employee)
        {
            //fix functionality
            Context.Employees.Add(employee);
        }

        public void DeleteEmployee()
        {
            //fix functionality
            Context.Employees.Remove(new Models.Employee());
        }

        //public IEnumerable<Employee> GetEmployees()
        //{
        //    //return Context.Employees;
        //    //AUTOMAPPER???
        //}
    }
}
