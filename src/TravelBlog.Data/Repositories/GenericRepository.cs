using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TravelBlog.Core.Entities;
using TravelBlog.Core.Repositories;
using TravelBlog.Data.Contexts;

namespace TravelBlog.Data.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity, new()
{
    private readonly BlogDbContext _Context;
    public GenericRepository(BlogDbContext Context)
    {
        _Context = Context;
    }
    public DbSet<TEntity> Table => _Context.Set<TEntity>();

    public async Task AddAysnc(TEntity entity)
    {
        await _Context.AddAsync(entity);
    }

    public void Delete(TEntity entity)
    {
        Table.Remove(entity);
        _Context.SaveChanges();
    }

    public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression = null, params string[] Includes)
    {
        var query=Table.AsQueryable();
        foreach (var include in Includes)
        {
            query = query.Include(include);
        }

        if(expression is not null)
        {
            return await query.Where(expression).ToListAsync();
        }
        else
        {
            return await query.ToListAsync();
        }
            

    }

    public async Task<TEntity> GetByIdAsync(int id)
    {
        return await Table.FindAsync(id);
    }

    public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> expression = null, params string[] Includes)
    {
        var query =Table.AsQueryable();
        foreach (var include in Includes)
        {
            query = query.Include(include);
        }

        if (expression is not null)
        {
            return await query.Where(expression).FirstOrDefaultAsync();
        }
        else
        {
            return await query.FirstOrDefaultAsync();
        }

    }

    public async Task SaveChangeAsync()
    {
        await _Context.SaveChangesAsync();
    }
}
