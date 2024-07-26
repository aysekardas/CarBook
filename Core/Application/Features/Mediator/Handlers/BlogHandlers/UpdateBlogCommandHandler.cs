using Application.Features.Mediator.Commands.BlogCommands;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.BlogHandlers
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public UpdateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
          var values = await _repository.GetByIdAsync(request.BlogID);
          values.AuthorID = request.AuthorID;
          values.CoverImageUrl = request.CoverImageUrl;
          values.Title = request.Title;
          values.CreatedDate = request.CreatedDate;   
          values.CategoryID = request.CategoryID;
        }
    }
}
