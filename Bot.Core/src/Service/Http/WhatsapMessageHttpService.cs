using Newtonsoft.Json;
using Sisc.Core.ServiceHttp;
using System.Configuration;

namespace Bot.Core.src.Service.Http
{
    public class WhatsapMessageHttpService: GenericHttpService
    {

        public WhatsapMessageHttpService(): base()
        {
            string uri = ConfigurationManager.AppSettings["urlWhatsappAPI"]!;
            this._client.BaseAddress = new Uri(uri);
        }

        public async Task<bool> EnviarMensagem(string number, string message)
        {
            HttpResponseMessage response;

            var payload = new
            {
                number = number,
                message = message
            };

            string jsonContent = JsonConvert.SerializeObject(payload);

            string path = "/sendMessage";

            response = await this.Post(path, jsonContent);

            return response.IsSuccessStatusCode;
        
        }

      


    }
}
