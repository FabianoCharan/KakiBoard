using System;
using System.Collections.Generic;
using KakiBoard.Domain.Usuario.Repositories;
using KakiBoard.Infrastructure.Context;
using KakiBoard.Domain.Usuario.Specs;
using MongoDB.Bson;
using MongoDB.Driver;
using KakiBoard.Domain.Usuario.Models;

namespace KakiBoard.Infrastructure.Repositories.Usuario
{
    public class UsuarioRepository : RepositoryBase<Domain.Usuario.Models.Usuario>, IUsuarioRepository
    {
        private KakiBoardContext _context;

        public UsuarioRepository(KakiBoardContext context)
        {
            _context = context;
        }

        public void AtualizarUsuario(Domain.Usuario.Models.Usuario usuario, string emailNovo)
        {
            var filter = Builders<Domain.Usuario.Models.Usuario>.Filter.Eq(u=> u.Email, usuario.Email);

            usuario.AtualizarEmail(emailNovo);

            var objUser = _context.Usuarios.ReplaceOne(filter, usuario);
        }

        public void Autenticar(Domain.Usuario.Models.Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Usuario.Models.Usuario> ListarUsuarios()
        {
            var projection = Builders<Domain.Usuario.Models.Usuario>.Projection.Exclude("_id").Exclude(x=>x.Senha);

            var result = _context.Usuarios
                .Find(new BsonDocument())
                .Project<Domain.Usuario.Models.Usuario>(projection)
                .ToListAsync().Result;

            return result;
        }

        public void Registrar(Domain.Usuario.Models.Usuario usuario)
        {
            _context.Usuarios.InsertOne(usuario);
        }

        public bool UsuarioJaExiste(string email)
        {
            var projection = Builders<Domain.Usuario.Models.Usuario>.Projection.Exclude("_id");

            var result = _context.Usuarios
                .Find(UsuarioEspecificacao.EmailJaExiste(email))
                .Project<Domain.Usuario.Models.Usuario>(projection)
                .FirstOrDefaultAsync().Result;

            return result != null;
        }
    }
}
