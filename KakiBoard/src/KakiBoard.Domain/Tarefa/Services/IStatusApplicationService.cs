using System.Collections.Generic;
using KakiBoard.Domain.Tarefa.Models;

namespace KakiBoard.Domain.Tarefa.Services
{
    public interface IStatusApplicationService
    {

        Status Registrar(string nome);
        IEnumerable<Status> Listar();

    }
}
