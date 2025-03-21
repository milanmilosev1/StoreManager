using SM.Infrastructure.Context;
using SM.Infrastructure.Interfaces.IRepository;

namespace SM.Infrastructure.Repositories
{
    public class EmployeeRepository(StoreDbContext context) : IEmployeeRepository
    {
        private readonly StoreDbContext Context = context;
        public void AddEmployee()
        {
            Context.Employees.Add(new Models.Employee());
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
