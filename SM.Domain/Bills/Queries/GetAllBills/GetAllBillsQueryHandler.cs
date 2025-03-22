using AutoMapper;
using MediatR;
using SM.Domain.DTOs;
using SM.Infrastructure.Interfaces.IRepository;
using SM.Infrastructure.Models;

namespace SM.Domain.Bills.Queries.GetAllBills
{
    public class GetAllBillsQueryHandler(IBillRepository billRepository, IMapper mapper) : IRequestHandler<GetAllBillsQuery, List<BillRepresentation>>
    {
        private readonly IBillRepository _billRepository = billRepository;
        private readonly IMapper _mapper = mapper;

        public async Task<List<BillRepresentation>> Handle(GetAllBillsQuery request, CancellationToken cancellationToken)
        {
            var bills = await _billRepository.GetAllBills();

            var result = _mapper.Map<List<Bill>, List<BillRepresentation>>(bills!);

            return result;
        }
    }
}
