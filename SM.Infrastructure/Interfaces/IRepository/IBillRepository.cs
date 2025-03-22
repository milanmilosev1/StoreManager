using SM.Infrastructure.Models;

namespace SM.Infrastructure.Interfaces.IRepository
{
    public interface IBillRepository
    {
        Task<Bill> AddBill(Bill bill);
        Task<Bill> UpdateBill(Bill bill);
        Task<Bill> DeleteBill(Bill bill);
        Task<List<Bill>> GetAllBills();
        Task<Bill> GetBillById(Guid id);

    }
}
