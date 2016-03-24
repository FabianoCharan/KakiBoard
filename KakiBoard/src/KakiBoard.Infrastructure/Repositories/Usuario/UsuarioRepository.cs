using System;
using System.Collections.Generic;
using KakiBoard.Domain.Usuario.Repositories;
using KakiBoard.Infrastructure.Context;
using KakiBoard.Domain.Usuario.Specs;
using MongoDB.Bson;
using MongoDB.Driver;

namespace KakiBoard.Infrastructure.Repositories.Usuario
{
    public class UsuarioRepository : RepositoryBase<Domain.Usuario.Models.Usuario>, IUsuarioRepository
    {

        public UsuarioRepository(KakiBoardContext context) : base(context)
        {
        }

        public void Autenticar(Domain.Usuario.Models.Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Usuario.Models.Usuario> Listar()
        {
            var projection = Builders<Domain.Usuario.Models.Usuario>.Projection.Exclude(x => x.Senha);

            var result =
                DbSet
                .Find(new BsonDocument())
                .Project<Domain.Usuario.Models.Usuario>(projection)
                .ToListAsync().Result;

            return result;
        }

        public bool UsuarioJaExiste(string email)
        {
            var result =
                DbSet
                .Find(UsuarioEspecificacao.EmailJaExiste(email))
                .FirstOrDefaultAsync().Result;

            return result != null;
        }
    }
}
