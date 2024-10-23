using Bot.Core.Model;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Bot.Core.Service
{
    public class EmailService
    {

        private string _provedor;
        private string _password;
        private string _username;
        private int _port;


        public EmailService(string provedor, string username, string password, int port = 587)
        {
            this._provedor = provedor ?? throw new ArgumentNullException(nameof(provedor));
            this._username = username ?? throw new ArgumentNullException(nameof(username));
            this._password = password ?? throw new ArgumentNullException(nameof(password));
            this._port = port;
        }

        public EmailService(int port = 587)
        {
            this._provedor = ConfigurationManager.AppSettings["emailHost"]!;
            this._username = ConfigurationManager.AppSettings["email"]!;
            this._password = ConfigurationManager.AppSettings["emailSenha"]!;
            this._port = port;
        }

        public void sendEmail(List<string> emailsTo, string subject, string body, List<string> attachments)
        {

            var message = PreparateMessage(emailsTo, subject, body, attachments);

            SendEmailBySmtp(message);

        }

        public MailMessage PreparateMessage(List<string> emailsTo, string subject, string body, List<string> attachments)
        {
            var mail = new MailMessage();
            mail.From = new MailAddress(this._username ,"Robozinho Do Siga");

            foreach (var email in emailsTo)
            {
                if (ValidateEmail(email))
                    mail.To.Add(email);
            }

            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.Normal;

            foreach (var file in attachments)
            {
                var data = new Attachment(file, MediaTypeNames.Application.Octet);
                ContentDisposition disposition = data.ContentDisposition!;
                disposition.CreationDate = System.IO.File.GetCreationTime(file);
                disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
                disposition.CreationDate = System.IO.File.GetLastAccessTime(file);

                mail.Attachments.Add(data);
            }


            return mail;
        }

        public bool ValidateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private void SendEmailBySmtp(MailMessage message)
        {
            SmtpClient smtpCliente = new SmtpClient(this._provedor, this._port);
            smtpCliente.EnableSsl = true;
            smtpCliente.Timeout = 50000;
            smtpCliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpCliente.UseDefaultCredentials = false;
            smtpCliente.Credentials = new NetworkCredential(this._username, this._password);
            smtpCliente.Send(message);
            smtpCliente.Dispose();
        }

        //EM ANDAMENTO
        //public void EnviarEmailBoasVindas()
        //{
        //    EmailService emailService = new EmailService("smtp.office365.com", "chaninho15@outlook.com.br", "xaninho15");
        //    List<string> emailsTo = new List<string> { "marcos.gasparini13@gmail.com" };
        //    string subject = "Teste de Envio de E-mail";
        //    string body = "<h1>Olá, este é um teste de envio de e-mail!</h1><p>Este é um exemplo de corpo de e-mail.</p>";

        //    try
        //    {
        //        emailService.sendEmail(emailsTo, subject, body, new List<string>());
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Erro ao enviar o e-mail: " + ex.Message);
        //    }

        //}

        public Dictionary<string, string> BuildarEnvioDeAutalizacaoDeNotas(Estudante estudante, List<Materia> materias)
        {
            string subject = "Suas notas foram publicadas no SIGA!";

            StringBuilder bodyBuilder = new StringBuilder();
            bodyBuilder.Append("<!DOCTYPE html><html lang=\"pt-BR\"><head><meta charset=\"UTF-8\"><meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\"><title>Atualização de Notas</title>");
            bodyBuilder.Append("<style>body { font-family: Arial, sans-serif; background-color: #f4f4f4; margin: 0; padding: 20px; }");
            bodyBuilder.Append(".container { background-color: #ffffff; padding: 20px; border-radius: 10px; box-shadow: 0 0 10px rgba(0, 0, 0, 0.1); max-width: 600px; margin: 0 auto; }");
            bodyBuilder.Append(".header { text-align: center; margin-bottom: 20px; } .header h1 { margin: 0; color: #333333; } .content { font-size: 16px; color: #555555; }");
            bodyBuilder.Append(".content p { margin-bottom: 20px; } .table-container { margin-top: 20px; } table { width: 100%; border-collapse: collapse; }");
            bodyBuilder.Append("table, th, td { border: 1px solid #dddddd; } th, td { padding: 12px; text-align: left; } th { background-color: #f8f8f8; color: #333333; }");
            bodyBuilder.Append(".footer { text-align: center; margin-top: 20px; font-size: 14px; color: #999999; } </style></head><body>");
            bodyBuilder.Append("<div class=\"container\"><div class=\"header\"><h1>Atualização de Notas</h1></div>");
            bodyBuilder.AppendFormat("<div class=\"content\"><p>Olá, {0},</p><p>Gostaríamos de informar que suas notas foram atualizadas. Confira os detalhes abaixo:</p></div>", estudante.Nome);
            bodyBuilder.Append("<div class=\"table-container\"><table><thead><tr><th>Disciplina</th><th>P1</th><th>P2</th><th>P3</th><th>Média Final</th></tr></thead><tbody>");

            foreach (var materia in materias)
            {
                bodyBuilder.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td></tr>",
                    materia.Nome,
                    materia.Notas!.P1,
                    materia.Notas!.P2,
                    materia.Notas!.P3,
                    materia.Notas!.MediaFinal);
            }

            bodyBuilder.Append("</tbody></table></div>");
            bodyBuilder.Append("<div class=\"content\"><p>Caso tenha alguma dúvida ou precise de mais informações, sinta-se à vontade para nos contatar.</p>");
            bodyBuilder.Append("<p>Atenciosamente,<br>FATEC Botucatu</p></div>");
            bodyBuilder.AppendFormat("<div class=\"footer\"><p>Este email faz parte de um Trabalho de Conclusão de Curso (TCC) desenvolvido por Marcos Gasparini Junior, aluno da FATEC Botucatu.</p>");
            bodyBuilder.AppendFormat("<p>© {0} FATEC Botucatu.</p></div></div></body></html>", DateTime.Now.Year);

            string body = bodyBuilder.ToString();


            Dictionary<string, string> email = new Dictionary<string, string>()
            {
                { "subject", subject },
                { "body", body }
            };

            return email; 

        }



    }
}
