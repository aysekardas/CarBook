﻿using Application.Features.Mediator.Commands.AuthorCommands;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.AuthorHandler
{
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand>
    {
        private readonly IRepository<Author> _repository;

        public UpdateAuthorCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
           var values = await _repository.GetByIdAsync(request.AuthorID);
           values.Description = request.Description;   
           values.Name = request.Name;
           values.ImageUrl = request.ImageUrl;
           await _repository.UpdateAsync(values); 
        }
    }
}
