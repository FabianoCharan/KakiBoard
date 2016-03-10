using System;
using System.Collections.Generic;
using KakiBoard.Domain.Usuario.Models;
using KakiBoard.Domain.Usuario.Repositories;
using KakiBoard.Infrastructure.Context;

namespace KakiBoard.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private KakiBoardContext _context;

        public UsuarioRepository(KakiBoardContext context)
        {
            _context = context;
        }

        public List<Usuario> ListarUsuarios()
        {
            //_context.Usuarios.FindAsync();
            return null;
        }
    }
}
