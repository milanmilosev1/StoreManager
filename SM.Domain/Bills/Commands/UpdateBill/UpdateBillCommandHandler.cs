using MediatR;
using SM.Domain.DTOs;
using SM.Infrastructure.Context;
using SM.Infrastructure.Interfaces.IRepository;

namespace SM.Domain.Bills.Commands.UpdateBill
{
    public class UpdateBillCommandHandler(StoreDbContext context, IBillRepository billRepository) : IRequestHandler<UpdateBillCommand, BillRepresentation>
    {
        private readonly StoreDbContext _context = context;
        private readonly IBillRepository _billRepository = billRepository;
        public async Task<BillRepresentation> Handle(UpdateBillCommand request, CancellationToken cancellationToken)
        {
            var bill = await _context.Bills.FindAsync(request.BillNumber);
            await _billRepository.UpdateBill(bill);
            return new BillRepresentation { BillNumber = request.BillNumber };
        }
    }
}
