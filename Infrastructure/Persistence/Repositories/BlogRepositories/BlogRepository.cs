using Application.Interfaces.BlogInterfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly CarBookContext _carBookContext;

        public BlogRepository(CarBookContext carBookContext)
        {
            _carBookContext = carBookContext;
        }

		public List<Blog> GetAllBlogsWithAuthors()
		{
			var values = _carBookContext.Blogs.Include(x=>x.Author).Include(y=>y.Category).ToList();
            return values;
		}

		public List<Blog> GetLast3BlogsWithAuthors()
        {
           var values = _carBookContext.Blogs.Include(x=>x.Author).OrderByDescending(x=>x.BlogID).Take(3).ToList();
            return values;
        }
    }
}
