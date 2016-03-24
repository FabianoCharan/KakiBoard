using System.Collections.Generic;
using KakiBoard.Domain.Tarefa.Models;
using KakiBoard.Domain.Tarefa.Repositories;
using KakiBoard.Infrastructure.Context;
using MongoDB.Bson;
using MongoDB.Driver;

namespace KakiBoard.Infrastructure.Repositories.Tarefa
{
    public class TipoRepository : RepositoryBase<Tipo>, ITipoRepository
    {

        public TipoRepository(KakiBoardContext context) : base(context)
        {
        }

        public void Adicionar(Tipo tipo)
        {
            Add(tipo);
        }

        public IEnumerable<Tipo> Listar()
        {
            return DbSet.Find(new BsonDocument()).ToEnumerable();
        }

    }
}