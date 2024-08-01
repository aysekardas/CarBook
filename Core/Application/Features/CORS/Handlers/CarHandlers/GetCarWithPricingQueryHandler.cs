using Application.Features.CORS.Results.CarResults;
using Application.Interfaces.CarInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CORS.Handlers.CarHandlers
{
	public class GetCarWithPricingQueryHandler
	{
		private readonly ICarRepository _repository;

		public GetCarWithPricingQueryHandler(ICarRepository repository)
		{
			_repository = repository;
		}

		public List<GetCarWithPricingQueryResult> Handle()
		{
			var values = _repository.GetCarsWithPricings();
			return values.Select(x => new GetCarWithPricingQueryResult
			{
				Model = x.Car.Model,
				CoverImageUrl = x.Car.CoverImageUrl,
				BrandName = x.Car.Brand.Name,
				PricingAmount = x.Amount,
			}).ToList();
		}
	}
}