using Microsoft.EntityFrameworkCore;
using SM.Infrastructure.Context;
using SM.Infrastructure.Interfaces.IRepository;
using SM.Infrastructure.Models;

namespace SM.Infrastructure.Repositories
{
    public class BillRepository(StoreDbContext context) : IBillRepository
    {
        private readonly StoreDbContext Context = context;
        public async Task<Bill> AddBill(Bill bill)
        {
            var result = Context.Bills.Add(bill)!;

            await Context.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<Bill> DeleteBill(Bill bill)
        {
            var result = Context.Bills.Remove(bill)!;

            await Context.SaveChangesAsync();

            return result.Entity;
        }

        public Task<List<Bill>> GetAllBills()
        {
            return Task.Run(() => GetQueryable().ToList());
        }

        public async Task<Bill> GetBillById(Guid id)
        {
            var result = await Context.Bills.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<Bill> UpdateBill(Bill bill)
        {
            var result = Context.Bills.Update(bill)!;

            await Context.SaveChangesAsync();

            return result.Entity;
        }


        private IQueryable<Bill> GetQueryable()
        {
            var products = Context.Bills;
            return products;
        }
    }
}
