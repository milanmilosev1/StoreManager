using MediatR;
using SM.Domain.DTOs;
using SM.Infrastructure.Interfaces.IRepository;
using SM.Infrastructure.Models;

namespace SM.Domain.Bills.Commands.AddBill
{
    public class AddBillCommandHandler(IBillRepository billRepository) : IRequestHandler<AddBillCommand, BillRepresentation>
    {
        private readonly IBillRepository _billRepository = billRepository;

        public async Task<BillRepresentation> Handle(AddBillCommand request, CancellationToken cancellationToken)
        {
            var bill = new Bill
            {
                Price = request.Price
            };

            var result = await _billRepository.AddBill(bill);

            return new BillRepresentation();
        }
    }
}
