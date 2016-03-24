using KakiBoard.Domain.Tarefa.Models;
using KakiBoard.SharedKernel.Validation;

namespace KakiBoard.Domain.Tarefa.Scopes
{
    public static class EscoposInteracao
    {

        public static bool RegistrarInteracaoEscopoEstaValido(this Interacao interacao)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotNull(interacao.DataInicio, "A data é obrigatória")
            );
        }

    }
}
