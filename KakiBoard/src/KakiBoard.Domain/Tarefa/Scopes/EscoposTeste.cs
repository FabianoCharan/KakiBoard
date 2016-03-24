using KakiBoard.Domain.Tarefa.Models;
using KakiBoard.SharedKernel.Validation;

namespace KakiBoard.Domain.Tarefa.Scopes
{
    public static class EscoposTeste
    {

        public static bool RegistrarTesteEscopoEstaValido(this Teste teste)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotEmpty(teste.Tester, "O tester é obrigatório"),
                    AssertionConcern.AssertNotEmpty(teste.Role, "O perfil é obrigatório")
                );
        }

    }
}