using MediatR;
using SM.Domain.DTOs;

namespace SM.Domain.Bills.Commands.UpdateBill
{
    public class UpdateBillCommand : IRequest<BillRepresentation>
    {
        public int BillNumber { get; set; }
        public double Price { get; set; }
    }
}
