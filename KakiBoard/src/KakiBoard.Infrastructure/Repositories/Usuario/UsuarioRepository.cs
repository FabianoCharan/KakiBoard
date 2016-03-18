using System;
using System.Collections.Generic;
using KakiBoard.Domain.Usuario.Repositories;
using KakiBoard.Infrastructure.Context;
using System.Threading.Tasks;
using KakiBoard.Domain.Usuario.Specs;
using MongoDB.Bson;
using MongoDB.Driver;

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

        public bool UsuarioJaExiste(Domain.Usuario.Models.Usuario usuario)
        {
            //UsuarioEspecificacao.EmailJaExiste(usuario.Email)
            var projection = Builders<BsonDocument>.Projection.Exclude("_id");
            var build = Builders<BsonDocument>.Filter;
            var filter = build.Eq("email",usuario.Email).ToBsonDocument();// new BsonDocument();

            var result = _context.Usuarios.Find(UsuarioEspecificacao.EmailJaExiste(usuario.Email)).FirstOrDefaultAsync().Result;
            //var result = _context.Usuarios.Find(UsuarioEspecificacao.EmailJaExiste(usuario.Email)).Project(projection).FirstOrDefaultAsync().Result;
            bool retorno = result != null;
            return retorno;
        }
    }
}
