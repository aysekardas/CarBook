using Application.Features.CORS.Results.AboutResult;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CORS.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler
    {
        private readonly IRepository<About> _repository;

        public GetAboutQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        //Handle CORS'de CRUD işlemlerini gerçekleştirirken kullanılan method ismi
        public async Task< List<GetAboutByIdQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAboutByIdQueryResult
                {
                AboutID = x.AboutID,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                Title = x.Title
            }).ToList();
        }
    }
}
