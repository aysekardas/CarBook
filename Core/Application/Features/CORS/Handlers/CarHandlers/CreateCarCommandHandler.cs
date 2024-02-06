using Application.Features.CORS.Commands.CarCommands;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CORS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
               Transmission = command.Transmission,
               Seat = command.Seat,
               Model = command.Model,
               Luggage = command.Luggage,
               CoverImageUrl = command.CoverImageUrl,
               Km = command.Km,
               Fuel = command.Fuel,
               BigImageUrl = command.BigImageUrl,
               BrandID = command.BrandID


            });
        }
    }
}
