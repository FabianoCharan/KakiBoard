using System.Collections.Generic;
using KakiBoard.Domain.Tarefa.Models;
using KakiBoard.Domain.Tarefa.Repositories;
using KakiBoard.Infrastructure.Context;
using MongoDB.Bson;
using MongoDB.Driver;

namespace KakiBoard.Infrastructure.Repositories.Tarefa
{
    public class ProjetoRepository : RepositoryBase<Projeto>, IProjetoRepository
    {

        public ProjetoRepository(KakiBoardContext context) : base(context)
        {
        }

        public void Adicionar(Projeto projeto)
        {
            Add(projeto);
        }

        public IEnumerable<Projeto> Listar()
        {
            return DbSet.Find(new BsonDocument()).ToEnumerable();
        }

    }
}