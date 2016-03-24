using KakiBoard.Domain.Tarefa.Models;
using KakiBoard.SharedKernel.Validation;

namespace KakiBoard.Domain.Tarefa.Scopes
{
    public static class EscoposStatus
    {

        public static bool RegistrarStatusEscopoEstaValido(this Status status)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotEmpty(status.Nome, "O nome é obrigatório")
                );
        }

    }
}