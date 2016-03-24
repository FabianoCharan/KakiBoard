using System.Collections.Generic;
using KakiBoard.Domain.Tarefa.Models;

namespace KakiBoard.Domain.Tarefa.Services
{
    public interface ITipoApplicationService
    {

        Tipo Registrar(string nome);
        IEnumerable<Tipo> Listar();

    }
}
