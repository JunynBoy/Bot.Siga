using System;
using System.Configuration;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace Bot.Core.src.Service.Http
{
    public class WhatsapMessageHttpService
    {
        private readonly string _baseUri;

        public WhatsapMessageHttpService()
        {
            _baseUri = ConfigurationManager.AppSettings["urlWhatsappAPI"]!;
        }

        public bool EnviarMensagem(string number, string message)
        {
            try
            {
                var payload = new
                {
                    number = number,
                    message = message
                };

                string jsonContent = JsonConvert.SerializeObject(payload);
                string path = "/sendMessage";

                var requisicaoWeb = WebRequest.CreateHttp(_baseUri + path);
                requisicaoWeb.Method = "POST";
                requisicaoWeb.ContentType = "application/json";
                requisicaoWeb.UserAgent = "RequisicaoWebDemo";

                using (var streamWriter = new StreamWriter(requisicaoWeb.GetRequestStream()))
                {
                    streamWriter.Write(jsonContent);
                    streamWriter.Flush();
                }

                using (var resposta = requisicaoWeb.GetResponse())
                {
                    return true;
                }
            }
            catch (WebException we)
            {
                string responseText;

                if (we.Response != null)
                {
                    using (var stream = we.Response.GetResponseStream())
                    {
                        using (var reader = new StreamReader(stream))
                        {
                            responseText = reader.ReadToEnd();
                        }
                    }
                    Console.WriteLine("Erro ao enviar mensagem - " + responseText);
                }
                else
                {
                    Console.WriteLine("Erro ao enviar mensagem - O servidor não está disponível.");
                }

                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado - " + e.Message);
                return false;
            }
        }
    }

    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
