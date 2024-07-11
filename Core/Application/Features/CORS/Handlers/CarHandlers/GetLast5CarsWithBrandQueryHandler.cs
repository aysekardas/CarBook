using Application.Features.CORS.Results.CarResults;
using Application.Interfaces.CarInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CORS.Handlers.CarHandlers
{
    public class GetLast5CarsWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetLast5CarsWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public List<GetLast5CarsWithBrandQueryResult> Handle()
        {
            var values = _repository.GetLast5CarsWithBrands();
            return values.Select(x => new GetLast5CarsWithBrandQueryResult
            {
                BrandName = x.Brand.Name,
                BrandID = x.BrandID,
                BigImageUrl = x.BigImageUrl,
                CarID = x.CarID,
                CoverImageUrl = x.CoverImageUrl,
                Fuel = x.Fuel,
                Km = x.Km,
                Luggage = x.Luggage,
                Model = x.Model,
                Seat = x.Seat,
                Transmission = x.Transmission
            }).ToList();
        }
    }
}
}
