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
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand command)
        {
            var values = await _repository.GetByIdAsync(command.CarID);
            values.BrandID = command.BrandID;
            values.Transmission = command.Transmission;
            values.BigImageUrl = command.BigImageUrl;
            values.CoverImageUrl= command.CoverImageUrl;
            values.Seat = command.Seat;
            values.Km = command.Km;
            values.Luggage = command.Luggage;
            values.Model = command.Model;
            values.CarID = command.CarID;
            values.Fuel = command.Fuel;
            await _repository.UpdateAsync(values);
        }
    }
}
