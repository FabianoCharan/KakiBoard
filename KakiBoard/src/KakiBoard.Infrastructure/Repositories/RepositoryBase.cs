using System;
using System.Collections.Generic;
using KakiBoard.Infrastructure.Context;
using MongoDB.Driver;
using MongoDB.Bson;
using KakiBoard.SharedKernel.Repositories;
using System.Linq.Expressions;

namespace KakiBoard.Infrastructure.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly IMongoCollection<T> _dbSet;
        protected KakiBoardContext Db = new KakiBoardContext();

        public RepositoryBase()
        {
            _dbSet = Db.DataBase.GetCollection<T>(typeof(T).Name);
        }

        public void Create(T entity)
        {
            _dbSet.InsertOneAsync(entity);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.Find(new BsonDocument()).ToList();
        }

        public T GetById(string id)
        {
            return null;
        }

        public void Update(T entity)
        {

        }

        public void Dispose()
        {
        }
    }
}
