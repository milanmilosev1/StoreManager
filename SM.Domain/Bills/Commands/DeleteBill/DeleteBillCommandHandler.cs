using MediatR;
using SM.Domain.DTOs;
using SM.Infrastructure.Context;
using SM.Infrastructure.Interfaces.IRepository;

namespace SM.Domain.Bills.Commands.DeleteBill
{
    public class DeleteBillCommandHandler(StoreDbContext context, IBillRepository billRepository) : IRequestHandler<DeleteBillCommand, BillRepresentation>
    {
        private readonly StoreDbContext Context = context;
        private readonly IBillRepository _billRepository = billRepository;
        public async Task<BillRepresentation> Handle(DeleteBillCommand request, CancellationToken cancellationToken)
        {
            var bill = await Context.Bills.FindAsync(request.BillNumber);
            await _billRepository.DeleteBill(bill);
            return new BillRepresentation();
        }
    }
}
