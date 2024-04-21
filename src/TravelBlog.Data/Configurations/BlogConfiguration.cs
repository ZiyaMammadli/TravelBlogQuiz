using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelBlog.Core.Entities;

namespace TravelBlog.Data.Configurations;

public class BlogConfiguration : IEntityTypeConfiguration<Blog>
{
    public void Configure(EntityTypeBuilder<Blog> builder)
    {
        builder.Property(b => b.Title).IsRequired().HasMaxLength(500);
        builder.Property(b=>b.Desc).IsRequired().HasMaxLength(1000);
        builder.Property(b=>b.ImageUrl).IsRequired().HasMaxLength(100);
    }
}
