using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelBlog.Core.Repositories;
using TravelBlog.Data.Repositories;

namespace TravelBlog.Data;

public class ServiceRegistiration
{
    public static void AddRepository(IServiceCollection services)
    {
        services.AddScoped<IBlogRepository, BlogRepository>();
    }
}
