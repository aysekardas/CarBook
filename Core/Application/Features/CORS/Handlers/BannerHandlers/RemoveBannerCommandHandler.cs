using Application.Features.CORS.Commands.AboutComands;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CORS.Handlers.BannerHandlers
{
    public class RemoveBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public RemoveBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveAboutCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
