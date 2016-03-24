using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using KakiBoard.Domain.Tarefa.Services;

namespace KakiBoard.Api.Controllers
{
    public class TipoController : BaseController
    {

        private readonly ITipoApplicationService _service;

        public TipoController(ITipoApplicationService service)
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