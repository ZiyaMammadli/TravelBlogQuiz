using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelBlog.Business.DTOs.BlogDtos;
using TravelBlog.Business.Mapper;
using TravelBlog.Business.Services.Interfaces;
using TravelBlog.Core.Entities;
using TravelBlog.Core.Repositories;
using TravelBlog.Data.Repositories;

namespace TravelBlog.Business.Services.Implementations;

public class BlogService : IBlogService
{
    private readonly IBlogRepository _blogRepository;
    private readonly BlogMapProfile _mapper;
    public BlogService(IBlogRepository blogRepository,BlogMapProfile mapper)
    {
        _blogRepository = blogRepository;
        _mapper = mapper;
    }
    public Task CreateAsync(BlogPostDto blogPostDto)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id, BlogDeleteDto blogDeleteDto)
    {
        throw new NotImplementedException();
    }

    public Task<List<Blog>> GetAllAsync(int id, BlogGetDto blogGetDto)
    {
        throw new NotImplementedException();
    }

    public Task<Blog> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(int id, BlogPutDto blogPutDto)
    {
        throw new NotImplementedException();
    }
}
