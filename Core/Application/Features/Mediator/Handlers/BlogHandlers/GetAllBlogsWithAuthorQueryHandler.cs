using Application.Features.Mediator.Queries.BlogQueries;
using Application.Features.Mediator.Results.BlogResults;
using Application.Interfaces.BlogInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediator.Handlers.BlogHandlers
{
	public class GetAllBlogsWithAuthorQueryHandler : IRequestHandler<GetAllBlogsWithAuthorQuery, List<GetAllBlogsWithAuthorQueryResult>>
	{
		private readonly IBlogRepository _repository;

		public GetAllBlogsWithAuthorQueryHandler(IBlogRepository repository)
		{
			_repository = repository;
		}

		public async Task<List<GetAllBlogsWithAuthorQueryResult>> Handle(GetAllBlogsWithAuthorQuery request, CancellationToken cancellationToken)
		{
			var values = _repository.GetAllBlogsWithAuthors();
			return values.Select(x=> new GetAllBlogsWithAuthorQueryResult
			{
				AuthorID = x.AuthorID,
				BlogID = x.BlogID,
				AuthorName = x.Author.Name,
				CategoryID = x.CategoryID,
				CategoryName = x.Category.Name,
				CoverImageUrl = x.CoverImageUrl,
				CreatedDate = x.CreatedDate,
				Title = x.Title

			}).ToList();
			
		}
	}
}
