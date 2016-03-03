using Microsoft.AspNet.WebHooks;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KakiHooks.WebHookHandlers
{
    public class GitHubWebHookHandler : WebHookHandler
    {
        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context)
        {
			// make sure we're only processing the intended type of hook
			if("GitHub".Equals(receiver, System.StringComparison.CurrentCultureIgnoreCase))
			{
				// todo: replace this placeholder functionality with your own code
				string action = context.Actions.First();
				JObject incoming = context.GetDataOrDefault<JObject>();

                EnviarEmail(incoming,action);
            }
            
            return Task.FromResult(true);
        }

        /// <summary>
        /// Enviar email para os colaboradores do projeto
        /// </summary>
        /// <returns></returns>
        public void EnviarEmail(JObject incoming, string action)
        {
            var sb = new StringBuilder();

            var messageGit = incoming["message"];

            sb.Append("<p>Dai  Galera!</p>");
            
            //para testar o webhooks crie e envie o email aqui.
        }
    }
}
