using KakiBoard.Domain.Usuario;
using KakiBoard.Domain.Usuario.Services;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace KakiBoard.Api.Controllers
{
    public class ValuesController : BaseController
    {
        private readonly IUsuarioApplicationService _service;
               

        public ValuesController(IUsuarioApplicationService service)
        {
            _service = service;
        }

        // GET api/values
        public Task<HttpResponseMessage> Get()
        {
            return CreateResponse(HttpStatusCode.OK, _service.ListarTodosUsuarios());
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public Task<HttpResponseMessage> Post(Domain.Usuario.Commands.RegistrarUsuarioCommand command)
        {
            _service.Registrar(command);

            return CreateResponse(HttpStatusCode.OK, command);
        }

        // PUT api/values/5
        public Task<HttpResponseMessage> Put(Domain.Usuario.Commands.RegistrarUsuarioCommand command)
        {
            _service.Atualizar(command);

            return CreateResponse(HttpStatusCode.OK, command);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
