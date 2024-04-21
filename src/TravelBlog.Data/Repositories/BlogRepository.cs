using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelBlog.Core.Entities;
using TravelBlog.Core.Repositories;
using TravelBlog.Data.Contexts;

namespace TravelBlog.Data.Repositories;

public class BlogRepository : GenericRepository<Blog>, IBlogRepository
{
    public BlogRepository(BlogDbContext Context) : base(Context)
    {
    }
}
