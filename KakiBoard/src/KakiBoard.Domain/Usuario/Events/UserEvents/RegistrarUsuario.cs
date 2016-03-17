using KakiBoard.SharedKernel.Events.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KakiBoard.Domain.Usuario.Events.UserEvents
{
    public class RegistrarUsuario : IDomainEvent
    {
        public DateTime DataOcorrencia { get; private set; }
        public Models.Usuario usuarioRegistrado { get; private set; }

        public RegistrarUsuario(Models.Usuario usuario, DateTime dataOcorrencia)
        {
            usuarioRegistrado = usuario;
            DataOcorrencia = dataOcorrencia;
        }

        public RegistrarUsuario(Models.Usuario usuario) : this(usuario, DateTime.Now) { }
    }
}
