using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelBlog.Core.Entities;
using TravelBlog.Data.Configurations;

namespace TravelBlog.Data.Contexts;

public class BlogDbContext:DbContext
{
    public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlogConfiguration).Assembly);
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Blog> Blogs { get; set; } 
}
