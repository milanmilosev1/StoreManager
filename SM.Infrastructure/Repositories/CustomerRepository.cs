using SM.Domain.Interfaces.IRepository;
using SM.Infrastructure.Context;
using SM.Infrastructure.Models;

namespace SM.Infrastructure.Repositories
{
    public class CustomerRepository(StoreDbContext context) : ICustomerRepository
    {
        private readonly StoreDbContext Context = context;
        public void AddCustomer()
        {
            //implement
            Context.Customers.Add(new Customer());
        }

        public void DeleteCustomer()
        {
            //implement
            Context.Customers.Remove(new Customer());
        }
    }
}
