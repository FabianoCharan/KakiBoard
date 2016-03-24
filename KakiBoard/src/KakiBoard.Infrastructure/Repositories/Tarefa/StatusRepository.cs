using System.Collections.Generic;
using KakiBoard.Domain.Tarefa.Models;
using KakiBoard.Domain.Tarefa.Repositories;
using KakiBoard.Infrastructure.Context;
using MongoDB.Bson;
using MongoDB.Driver;

namespace KakiBoard.Infrastructure.Repositories.Tarefa
{
    public class StatusRepository : RepositoryBase<Status>, IStatusRepository
    {

        public StatusRepository(KakiBoardContext context) : base(context)
        {
        }

        public void Adicionar(Status status)
        {
            Add(status);
        }

        public IEnumerable<Status> Listar()
        {
            return DbSet.Find(new BsonDocument()).ToEnumerable();
        }

    }
}
