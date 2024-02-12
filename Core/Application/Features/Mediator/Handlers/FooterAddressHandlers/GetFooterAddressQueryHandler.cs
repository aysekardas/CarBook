using Application.Features.Mediator.Queries.FooterAddressQueries;
using Application.Features.Mediator.Results.FooterAddress;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAddressQuery, List<GetFooterAddressQueryResult>>
    {
        private readonly IRepository<FooterAdress> _repository;

        public GetFooterAddressQueryHandler(IRepository<FooterAdress> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFooterAddressQueryResult>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetFooterAddressQueryResult
            {
                Adress = x.Adress,
                Description = x.Description,
                Email = x.Email,
                FooterAdressID = x.FooterAdressID,
                Phone = x.Phone
            }).ToList();
        }
    }
}
