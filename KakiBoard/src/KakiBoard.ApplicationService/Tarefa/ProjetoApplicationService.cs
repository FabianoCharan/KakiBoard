using System.Collections.Generic;
using KakiBoard.Domain.Tarefa.Models;
using KakiBoard.Domain.Tarefa.Repositories;
using KakiBoard.Domain.Tarefa.Services;
using KakiBoard.SharedKernel.Repositories;

namespace KakiBoard.ApplicationService.Tarefa
{
    public class ProjetoApplicationService : ApplicationService, IProjetoApplicationService
    {

        private readonly IProjetoRepository _repository;

        public ProjetoApplicationService(IProjetoRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _repository = repository;
        }

        public Projeto Registrar(string nome)
        {
            var projeto = new Projeto(nome);

            projeto.Registrar();

            if (Commit())
            {
                _repository.Add(projeto);

                return projeto;
            }

            return null;
        }

        public IEnumerable<Projeto> Listar()
        {
            return _repository.Listar();
        }

    }
}
