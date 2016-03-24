using KakiBoard.Domain.Tarefa.Models;
using KakiBoard.SharedKernel.Validation;

namespace KakiBoard.Domain.Tarefa.Scopes
{
    public static class EscoposProjeto
    {

        public static bool RegistrarProjetoEscopoEstaValido(this Projeto projeto)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotEmpty(projeto.Nome, "O nome é obrigatório")
                );
        }

    }
}