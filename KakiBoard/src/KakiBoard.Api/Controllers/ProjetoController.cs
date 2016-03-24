using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using KakiBoard.Domain.Tarefa.Services;

namespace KakiBoard.Api.Controllers
{
    public class ProjetoController : BaseController
    {

        private readonly IProjetoApplicationService _service;

        public ProjetoController(IProjetoApplicationService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<HttpResponseMessage> Get()
        {
            return CreateResponse(HttpStatusCode.OK, _service.Listar());
        }

        [HttpPost]
        public Task<HttpResponseMessage> Post([FromBody] dynamic body)
        {
            var retorno = _service.Registrar((string)body.nome);

            return CreateResponse(HttpStatusCode.OK, retorno);
        }

    }
}