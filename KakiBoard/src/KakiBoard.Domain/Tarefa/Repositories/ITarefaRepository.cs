using KakiBoard.SharedKernel.Repositories;
using System.Collections.Generic;

namespace KakiBoard.Domain.Tarefa.Repositories
{
    public interface ITarefaRepository : IRepositoryBase<Models.Tarefa>
    {
        void AdicionarTarefa(Models.Tarefa tarefa);
        void AtualizarTarefa(Models.Tarefa tarefa);
        List<Models.Tarefa> ListarTarefas();
    }
}