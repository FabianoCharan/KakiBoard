using System;
using System.Collections.Generic;
using KakiBoard.Domain.Tarefa.Repositories;
using KakiBoard.Infrastructure.Context;
using MongoDB.Driver;
using MongoDB.Bson;

namespace KakiBoard.Infrastructure.Repositories.Tarefa
{
    public class TarefaRepository : RepositoryBase<Domain.Tarefa.Models.Tarefa>, ITarefaRepository
    {
        private readonly KakiBoardContext _context;

        public TarefaRepository(KakiBoardContext context)
        {
            _context = context;
        }

        public void AdicionarTarefa(Domain.Tarefa.Models.Tarefa tarefa)
        {
            _context.Tarefas.InsertOne(tarefa);
        }

        public void AtualizarTarefa(Domain.Tarefa.Models.Tarefa tarefa)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Tarefa.Models.Tarefa> ListarTarefas()
        {
            return _context.Tarefas.Find(new BsonDocument()).ToList();
        }
    }
}
