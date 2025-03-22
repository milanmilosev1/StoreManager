using MediatR;
using SM.Domain.DTOs;

namespace SM.Domain.Bills.Commands.DeleteBill
{
    public class DeleteBillCommand : IRequest<BillRepresentation>
    {
        public int BillNumber { get; set; }
    }
}
