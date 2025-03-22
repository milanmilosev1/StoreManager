using Microsoft.EntityFrameworkCore;
using SM.Infrastructure.Context;
using SM.Infrastructure.Interfaces.IRepository;
using SM.Infrastructure.Models;

namespace SM.Infrastructure.Repositories
{
    public class EmployeeRepository(StoreDbContext context) : IEmployeeRepository
    {
        private readonly StoreDbContext Context = context;

        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result = Context.Employees.Add(employee)!;
            await Context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Employee> DeleteEmployee(Employee employee)
        {
            var result = Context.Employees.Remove(employee)!;
            await Context.SaveChangesAsync();
            return result.Entity;
        }

        public Task<List<Employee>> GetAllEmployees()
        {
            return Task.Run(() => GetQueryable().ToList());
        }

        public async Task<Employee> GetEmployeeById(Guid id)
        {
            var result = await Context.Employees.FirstOrDefaultAsync(x => x!.Id == id);
            return result;
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var result = Context.Employees.Update(employee)!;
            await Context.SaveChangesAsync();
            return result.Entity;
        }

        private IQueryable<Employee> GetQueryable()
        {
            var employees = Context.Employees;
            return employees;
        }
    }
}
