using System.Collections.Generic;
using KakiBoard.Domain.Tarefa.Models;
using KakiBoard.Domain.Tarefa.Repositories;
using KakiBoard.Domain.Tarefa.Services;
using KakiBoard.SharedKernel.Repositories;

namespace KakiBoard.ApplicationService.Tarefa
{
    public class StatusApplicationService : ApplicationService, IStatusApplicationService
    {

        private readonly IStatusRepository _repository;

        public StatusApplicationService(IStatusRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _repository = repository;
        }

        public Status Registrar(string nome)
        {
            var status = new Status(nome);

            status.Registrar();

            if (Commit())
            {
                _repository.Add(status);

                return status;
            }

            return null;
        }

        public IEnumerable<Status> Listar()
        {
            return _repository.Listar();
        }

    }
}