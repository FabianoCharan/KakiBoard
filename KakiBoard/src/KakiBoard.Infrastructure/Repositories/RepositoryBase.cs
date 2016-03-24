using System;
using System.Collections.Generic;
using KakiBoard.Infrastructure.Context;
using MongoDB.Driver;
using KakiBoard.SharedKernel.Repositories;

namespace KakiBoard.Infrastructure.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly IMongoCollection<T> DbSet;
        //private readonly KakiBoardContext _context;

        public RepositoryBase(KakiBoardContext context)
        {
            //_context = context;
            DbSet = context.DataBase.GetCollection<T>(typeof(T).Name);
        }

        public void Add(T entity)
        {
            DbSet.InsertOneAsync(entity);
        }

        public void Update(T entity)
        {
            var filter = Builders<T>.Filter.Eq("Id", ((dynamic)entity).Id);

            DbSet.ReplaceOneAsync(filter, entity);
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        //public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        //{
        //    throw new NotImplementedException();
        //}

        public void Dispose()
        {
            //_context.Dispose();
        }

    }
}
