using System;
using System.Collections.Generic;
using KakiBoard.Domain.Usuario.Models;
using KakiBoard.Domain.Usuario.Repositories;
using KakiBoard.Infrastructure.Context;

namespace KakiBoard.Infrastructure.Repositories.Usuario
{
    public class UsuarioRepository : RepositoryBase<Domain.Usuario.Models.Usuario>, IUsuarioRepository
    {
        private KakiBoardContext _context;

        public UsuarioRepository(KakiBoardContext context)
        {
            _context = context;
        }

        public void Autenticar(Domain.Usuario.Models.Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Usuario.Models.Usuario> ListarUsuarios()
        {
            //return _context.Usuarios.FindSync();
            return null;
        }

        public void Registrar(Domain.Usuario.Models.Usuario usuario)
        {
            _context.Usuarios.InsertOne(usuario);
        }
    }
}
