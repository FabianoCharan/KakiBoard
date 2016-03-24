using System.Collections.Generic;
using System.Linq;
using KakiBoard.Domain.Usuario.Scope;
using KakiBoard.Domain.Usuario.Specs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KakiBoard.Domain.Tests.Usuario
{
    [TestClass]
    public class UsuarioTests
    {

        private IQueryable<Domain.Usuario.Models.Usuario> _usuarios;

        public UsuarioTests()
        {
            var list = new List<Domain.Usuario.Models.Usuario>();
            list.Add(new Domain.Usuario.Models.Usuario("Nome", "usuario@usuario.com.br", "1q2w3e4r", "DEV"));

            _usuarios = list.AsQueryable();
        }

        [TestMethod]
        [TestCategory("Usuario")]
        public void DeveRegistrar()
        {
            var usuario = new Domain.Usuario.Models.Usuario("Usuario", "usuario@usuario.com.br", "1q2w3e4rASDF*", "DEV");
            Assert.AreEqual(true, usuario.RegistrarUsuarioEscopoValido());
        }

        [TestMethod]
        [TestCategory("Usuario")]
        public void NaoDeveRegistrarFaltaEmail()
        {
            var usuario = new Domain.Usuario.Models.Usuario("Usuario", "", "1q2w3e4r", "DEV");
            Assert.AreEqual(false, usuario.RegistrarUsuarioEscopoValido());
        }

        [TestMethod]
        [TestCategory("Usuario")]
        public void NaoDeveRegistrarFaltaNome()
        {
            var usuario = new Domain.Usuario.Models.Usuario("", "usuario@usuario.com.br", "1q2w3e4r", "DEV");
            Assert.AreEqual(false, usuario.RegistrarUsuarioEscopoValido());
        }

        [TestMethod]
        [TestCategory("Usuario")]
        public void NaoDeveRegistrarFaltaSenha()
        {
            var usuario = new Domain.Usuario.Models.Usuario("Usuario", "usuario@usuario.com.br", "", "DEV");
            Assert.AreEqual(false, usuario.RegistrarUsuarioEscopoValido());
        }

        [TestMethod]
        [TestCategory("Usuario")]
        public void NaoDeveRegistrarSenhaFraca()
        {
            var usuario = new Domain.Usuario.Models.Usuario("Usuario", "usuario@usuario.com.br", "1234", "DEV");
            Assert.AreEqual(false, usuario.RegistrarUsuarioEscopoValido());
        }

        [TestMethod]
        [TestCategory("Usuario")]
        public void NaoDeveRegistrarFaltaPerfil()
        {
            var usuario = new Domain.Usuario.Models.Usuario("Usuario", "usuario@usuario.com.br", "1q2w3e4r", "");
            Assert.AreEqual(false, usuario.RegistrarUsuarioEscopoValido());
        }

        [TestMethod]
        [TestCategory("Usuario")]
        public void NaoDeveRegistrarEmailJaExiste()
        {
            var query = UsuarioEspecificacao.EmailJaExiste("usuario@usuario.com.br");
            var count = _usuarios.Where(query).Count();


            Assert.AreEqual(count, 1);
        }

    }
}
