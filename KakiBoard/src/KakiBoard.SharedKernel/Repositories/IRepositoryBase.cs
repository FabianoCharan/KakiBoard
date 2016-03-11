using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace KakiBoard.SharedKernel.Repositories
{
    public interface IRepositoryBase<T> : IDisposable where T : class
    {
        void Create(T entity);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void Update(T entity);
        void Delete(T entity);
    }
}
