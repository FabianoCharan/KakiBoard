using KakiBoard.SharedKernel.Events;
using KakiBoard.SharedKernel.Helpers.Contracts;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace KakiBoard.Api.Controllers
{
    public class BaseController : ApiController
    {
        IHandler<DomainNotification> Notifications;
        public HttpResponseMessage ResponseMessage;

        public BaseController()
        {
            Notifications = DomainEvent.Container.GetService<IHandler<DomainNotification>>();
            ResponseMessage = new HttpResponseMessage();
        }

        public Task<HttpResponseMessage> CreateResponse(HttpStatusCode code, object result)
        {
            if (Notifications.HasNotifications())
                ResponseMessage = Request.CreateResponse(HttpStatusCode.BadRequest, new { erros = Notifications.Notify() });
            else
                ResponseMessage = Request.CreateResponse(HttpStatusCode.OK, result);

            return Task.FromResult(ResponseMessage);
        }

        protected override void Dispose(bool disposing)
        {
            Notifications.Dispose();
        }
    }
}
