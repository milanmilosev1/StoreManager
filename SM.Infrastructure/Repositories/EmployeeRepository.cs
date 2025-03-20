using SM.Domain.Interfaces.IRepository;
using SM.Domain.Models;
using SM.Infrastructure.Context;

namespace SM.Infrastructure.Repositories
{
    public class EmployeeRepository() : IEmployeeRepository
    {
        private readonly StoreDbContext Context;
        public void AddEmployee()
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee()
        {
            throw new NotImplementedException();
        }

        //public IEnumerable<Employee> GetEmployees()
        //{
        //    //return Context.Employees;
        //    //AUTOMAPPER???
        //}
    }
}
