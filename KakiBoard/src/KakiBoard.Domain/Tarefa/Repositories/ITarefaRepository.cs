using System.Collections.Generic;
using KakiBoard.SharedKernel.Repositories;

namespace KakiBoard.Domain.Tarefa.Repositories
{
    public interface ITarefaRepository : IRepositoryBase<Models.Tarefa>
    {
        void Atualizar(Models.Tarefa tarefa);
        List<Models.Tarefa> Listar();
    }
}