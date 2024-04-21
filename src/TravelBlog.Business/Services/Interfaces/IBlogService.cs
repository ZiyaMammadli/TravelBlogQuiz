using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelBlog.Business.DTOs.BlogDtos;
using TravelBlog.Core.Entities;

namespace TravelBlog.Business.Services.Interfaces;

public interface IBlogService
{
    public Task<Blog> GetByIdAsync(int id);
    public Task<List<Blog>> GetAllAsync(int id,BlogGetDto blogGetDto);
    public Task CreateAsync(BlogPostDto blogPostDto);
    public Task Delete(int id,BlogDeleteDto blogDeleteDto);
    public Task UpdateAsync(int id,BlogPutDto blogPutDto);
}
