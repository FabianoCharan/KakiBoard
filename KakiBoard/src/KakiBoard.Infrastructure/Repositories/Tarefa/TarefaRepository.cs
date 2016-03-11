using KakiBoard.Domain.Tarefa.Repositories;
using KakiBoard.Infrastructure.Context;

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
    }
}
