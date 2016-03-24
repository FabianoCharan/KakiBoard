using System;
using System.Collections.Generic;
using KakiBoard.Domain.Tarefa.Models;
using KakiBoard.Domain.Tarefa.Repositories;
using KakiBoard.Domain.Tarefa.Services;
using KakiBoard.SharedKernel.Repositories;

namespace KakiBoard.ApplicationService.Tarefa
{
    public class TipoApplicationService : ApplicationService, ITipoApplicationService
    {

        private readonly ITipoRepository _repository;

        public TipoApplicationService(ITipoRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _repository = repository;
        }

        public Tipo Registrar(string nome)
        {
            var tipo = new Tipo(nome);

            tipo.Registar();

            if (Commit())
            {
                _repository.Add(tipo);

                return tipo;
            }

            return null;
        }

        public IEnumerable<Tipo> Listar()
        {
            return _repository.Listar();
        }

    }
}