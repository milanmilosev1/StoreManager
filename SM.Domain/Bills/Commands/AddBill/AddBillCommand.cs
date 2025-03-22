using MediatR;
using SM.Domain.DTOs;

namespace SM.Domain.Bills.Commands.AddBill
{
    public class AddBillCommand : IRequest<BillRepresentation>
    {
        public double Price { get; set; }
    }
}
