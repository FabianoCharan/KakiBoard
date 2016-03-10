using System;
using System.Collections.Generic;
using KakiBoard.Domain.Interfaces;
using KakiBoard.Infrastructure.Context;
using MongoDB.Driver;
using MongoDB.Bson;

namespace KakiBoard.Infrastructure.Repositories
{
    public class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : class
    {
        private readonly IMongoCollection<T> _dbSet;
        protected KakiBoardContext Db = new KakiBoardContext();

        public RepositoryBase()
        {
            _dbSet = Db.DataBase.GetCollection<T>(typeof(T).Name);
        }

        public void Add(T entity)
        {
            _dbSet.InsertOneAsync(entity);
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
