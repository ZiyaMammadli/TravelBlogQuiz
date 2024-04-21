using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelBlog.Business.DTOs.BlogDtos;

public class BlogGetDto
{
    public int Id { get; set; } 
    public string Title { get; set; }
    public string Desc { get; set; }


}

public class BlogGetValidator : AbstractValidator<BlogGetDto>
{
    public BlogGetValidator()
    {
        RuleFor(b => b.Id)
            .NotNull()
            .GreaterThan(0)
            .WithMessage("Id must be up than 0");

        RuleFor(b => b.Title)
            .NotNull()
            .MaximumLength(500)
            .MinimumLength(5)
            .WithMessage("title must be up 500 and must be down than 5");
        RuleFor(b => b.Desc)
            .NotNull()
            .MaximumLength(1000)
            .MinimumLength(20)
            .WithMessage("desc must be up 1000 and must be down than 20");
    }
}
