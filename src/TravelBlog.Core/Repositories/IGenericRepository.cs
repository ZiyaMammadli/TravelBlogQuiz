using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TravelBlog.Core.Entities;

namespace TravelBlog.Core.Repositories;

public interface IGenericRepository<TEntity> where TEntity:BaseEntity, new()
{
    DbSet<TEntity> Table { get; }
    Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> expression=null,params string[] Includes);
    Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression = null, params string[] Includes);
    Task<TEntity>GetByIdAsync(int id);
    Task SaveChangeAsync();
    Task AddAysnc(TEntity entity);
    void Delete(TEntity entity);
}
