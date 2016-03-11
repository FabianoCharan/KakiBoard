using KakiBoard.SharedKernel.Repositories;

namespace KakiBoard.Domain.Tarefa.Repositories
{
    public interface ITarefaRepository : IRepositoryBase<Models.Tarefa>
    {
        void AdicionarTarefa(Models.Tarefa tarefa);
    }
}
