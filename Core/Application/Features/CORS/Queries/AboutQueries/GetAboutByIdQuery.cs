using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CORS.Queries.AboutQueries
{
    public class GetAboutByIdQuery
    {
        public GetAboutByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        //bir nesne örneği üzerinden Id çağıracağım için ctor oluşturdum.


    }
}
