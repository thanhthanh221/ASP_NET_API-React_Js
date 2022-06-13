using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Domain_Layer.Base;

namespace Domain_Layer.Interfaces
{
    public interface IAsyncRepository<T> where T : BaseEntity
    {
        Task CreateAsync(T entity);
        Task DeleteAsync(Guid Id);
        Task<IReadOnlyCollection<T>> GetAllAsync();
        Task<IReadOnlyCollection<T>> GetAllAsync(Expression<Func<T, bool>> filter);
        Task<T> GetAsync(Guid Id);
        Task<T> GetAsync(Expression<Func<T,bool>> filter);

        Task UpdateAsync(T entity);
    }
}