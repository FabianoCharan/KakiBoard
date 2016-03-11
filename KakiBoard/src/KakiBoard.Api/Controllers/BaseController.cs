using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace KakiBoard.Api.Controllers
{
    public class BaseController : ApiController
    {
        public HttpResponseMessage ResponseMessage;

        public BaseController()
        {
            ResponseMessage = new HttpResponseMessage();
        }

        public Task<HttpResponseMessage> CreateResponse(HttpStatusCode code, object result)
        {
            //if (Notifications.HasNotifications())
            //    ResponseMessage = Request.CreateResponse(HttpStatusCode.BadRequest, new { errors = Notifications.Notify() });
            //else
                ResponseMessage = Request.CreateResponse(HttpStatusCode.OK, result);

            return Task.FromResult(ResponseMessage);
        }
    }
}
