using KakiBoard.Domain.Tarefa.Services;
using System;
using KakiBoard.Domain.Tarefa.Commands;
using KakiBoard.Domain.Tarefa.Repositories;
using KakiBoard.SharedKernel.Repositories;

namespace KakiBoard.ApplicationService.Tarefa
{
    public class TarefaApplicationService : ApplicationService, ITarefaApplicationService
    {
        private ITarefaRepository _repository;

        public TarefaApplicationService(ITarefaRepository repository, IUnitOfWork unitOfWork)
            :base(unitOfWork)
        {
            _repository = repository;
        }

        public Domain.Tarefa.Models.Tarefa AdicionarTarefa(TarefaCommand command)
        {
            var tarefa = new Domain.Tarefa.Models.Tarefa(command.Titulo, command.Tipo, command.Projeto, command.QuemCadastrou, command.Status);

            var ok = "";

            tarefa.AdicionarTarefa();

            if (Commit())
            {
                return tarefa;
            }

            return null;
        }

        public Domain.Tarefa.Models.Tarefa AtribuirTarefa(TarefaCommand command)
        {
            throw new NotImplementedException();
        }

        public Domain.Tarefa.Models.Tarefa EntregarTarefa(TarefaCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
