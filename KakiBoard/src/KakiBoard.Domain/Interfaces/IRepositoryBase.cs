using System.Collections.Generic;

namespace KakiBoard.Domain.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T entity);
        T GetById(string id);
        IEnumerable<T> GetAll();
        void Update(T entity);
        void Delete(T entity);
        void Dispose();
    }
}
