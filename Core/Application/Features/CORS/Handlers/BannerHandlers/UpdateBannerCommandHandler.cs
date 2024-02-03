using Application.Features.CORS.Commands.BannerCommands;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CORS.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBannerCommand command)
        {
            var values = await _repository.GetByIdAsync(command.BannerID);
            values.Description = command.Description;
            values.Title = command.Title;
            values.VideoUrl = command.VideoUrl;
            values.VideoDescription = command.VideoDescription;
            await _repository.UpdateAsync(values);  
        }
    }
}
