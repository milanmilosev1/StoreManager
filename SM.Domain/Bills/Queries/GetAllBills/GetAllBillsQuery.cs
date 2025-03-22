using MediatR;
using SM.Domain.DTOs;

namespace SM.Domain.Bills.Queries.GetAllBills
{
    public class GetAllBillsQuery : IRequest<List<BillRepresentation>>
    {
    }
}
