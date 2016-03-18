using System;
using System.Linq.Expressions;

namespace KakiBoard.Domain.Usuario.Specs
{
    public static class UsuarioEspecificacao
    {

        public static Expression<Func<Models.Usuario, bool>> EmailJaExiste(string email)
        {
            return x => x.Email == email;
        }
    }
}