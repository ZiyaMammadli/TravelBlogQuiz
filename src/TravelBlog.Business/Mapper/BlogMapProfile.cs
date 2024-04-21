using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelBlog.Business.DTOs.BlogDtos;
using TravelBlog.Core.Entities;

namespace TravelBlog.Business.Mapper
{
    public class BlogMapProfile:Profile
    {
        public BlogMapProfile()
        {
            CreateMap<BlogGetDto,Blog>().ReverseMap();
            CreateMap<BlogPostDto,Blog>().ReverseMap();
            CreateMap<BlogPutDto,Blog>().ReverseMap();           
        }
    }
}
