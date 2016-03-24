using System.Collections.Generic;
using KakiBoard.Domain.Tarefa.Models;

namespace KakiBoard.Domain.Tarefa.Services
{
    public interface IProjetoApplicationService
    {

        Projeto Registrar(string nome);
        IEnumerable<Projeto> Listar();

    }
}
