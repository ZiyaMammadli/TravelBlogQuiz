using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelBlog.Business.DTOs.BlogDtos;

public class BlogPutDto
{
    public string Title { get; set; }
    public string Desc { get; set; }
    public bool IsDeleted { get; set; }
}
public class BlogPutValidator : AbstractValidator<BlogPutDto>
{
    public BlogPutValidator()
    {

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