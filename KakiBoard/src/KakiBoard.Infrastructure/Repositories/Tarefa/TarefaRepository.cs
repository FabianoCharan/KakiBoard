using System;
using System.Collections.Generic;
using System.Linq;
using KakiBoard.Domain.Tarefa.Models;
using KakiBoard.Domain.Tarefa.Repositories;
using KakiBoard.Infrastructure.Context;
using MongoDB.Bson;

namespace KakiBoard.Infrastructure.Repositories.Tarefa
{
    public class TarefaRepository : RepositoryBase<Domain.Tarefa.Models.Tarefa>, ITarefaRepository
    {
        public TarefaRepository(KakiBoardContext context) : base(context)
        {
        }

        public void Adicionar(Domain.Tarefa.Models.Tarefa tarefa)
        {
           Add(tarefa);
        }

        public void Atualizar(Domain.Tarefa.Models.Tarefa tarefa)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Tarefa.Models.Tarefa> Listar()
        {
            throw new NotImplementedException();

            //return Find(new BsonDocument()).ToList();
        }
    }
}
