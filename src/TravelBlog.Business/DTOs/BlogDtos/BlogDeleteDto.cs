using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelBlog.Business.DTOs.BlogDtos;

public class BlogDeleteDto
{
    public int Id { get; set; }
}

public class BlogDeleteValidator : AbstractValidator<BlogDeleteDto>
{
    public BlogDeleteValidator()
    {
        RuleFor(b => b.Id)
            .NotNull()
            .GreaterThan(0)
            .WithMessage("Id must be up than 0");

    }
}