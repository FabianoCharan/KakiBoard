using KakiBoard.SharedKernel.Validation;

namespace KakiBoard.Domain.Usuario.Scope
{
    public static class UsuarioEscopo
    {

        public static bool RegistrarUsuarioEscopoValido(this Models.Usuario usuario)
        {
            return AssertionConcern.IsSatisfiedBy(
                AssertionConcern.AssertNotEmpty(usuario.Nome, "O nome do usuário é obrigatório"),
                AssertionConcern.AssertNotEmpty(usuario.Senha, "A senha do usuário é obrigatória"),
                AssertionConcern.AssertNotEmpty(usuario.Email, "O email do usuário é obrigatório"),
                AssertionConcern.AssertNotEmpty(usuario.Perfil, "O perfil do usuário é obrigatório"),
                AssertionConcern.AssertEmailIsValid(usuario.Email, "O email do usuário é inválido"),
                AssertionConcern.AssertPasswordIsValid(usuario.Senha, "A senha é fraca")
                );
        }

        public static bool AtualizarUsuarioEscopoValido(this Models.Usuario usuario)
        {
            return AssertionConcern.IsSatisfiedBy(
                AssertionConcern.AssertNotEmpty(usuario.Nome, "O nome do usuário é obrigatório"),
                AssertionConcern.AssertNotEmpty(usuario.Senha, "A senha do usuário é obrigatória"),
                AssertionConcern.AssertNotEmpty(usuario.Email, "O email do usuário é obrigatório"),
                AssertionConcern.AssertNotEmpty(usuario.Perfil, "O perfil do usuário é obrigatório"),
                AssertionConcern.AssertEmailIsValid(usuario.Email, "O email do usuário é inválido"),
                AssertionConcern.AssertPasswordIsValid(usuario.Senha, "A senha é fraca")
                );
        }
    }
}
