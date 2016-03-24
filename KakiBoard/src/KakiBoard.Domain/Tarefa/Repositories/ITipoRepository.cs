using System.Collections.Generic;
using KakiBoard.Domain.Tarefa.Models;
using KakiBoard.SharedKernel.Repositories;

namespace KakiBoard.Domain.Tarefa.Repositories
{
    public interface ITipoRepository : IRepositoryBase<Tipo>
    {

        IEnumerable<Tipo> Listar();

    }
}