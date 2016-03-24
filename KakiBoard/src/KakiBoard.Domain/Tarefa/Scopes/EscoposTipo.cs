using KakiBoard.Domain.Tarefa.Models;
using KakiBoard.SharedKernel.Validation;

namespace KakiBoard.Domain.Tarefa.Scopes
{
    public static class EscoposTipo
    {

        public static bool RegistrarTipoEscopoEstaValido(this Tipo tipo)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotEmpty(tipo.Nome, "O nome é obrigatório")
                );
        }

    }
}