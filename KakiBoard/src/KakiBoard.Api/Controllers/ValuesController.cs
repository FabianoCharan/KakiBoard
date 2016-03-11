using KakiBoard.Domain.Usuario.Models;
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
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public Task<HttpResponseMessage> Post(Usuario usuario)
        {
            _service.Registrar(usuario);

            return CreateResponse(HttpStatusCode.OK, usuario);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
