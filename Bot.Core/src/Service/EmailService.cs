using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text.RegularExpressions;

namespace Bot.Core.Service
{
    public class EmailService
    {
        //robozinhoDoSigaTcc@2024
        //robozinhoDoSiga@gmail.com
        private string _provedor;
        private string _password;
        private string _username;


        public EmailService(string provedor, string username, string password)
        {
            this._provedor = provedor ?? throw new ArgumentNullException(nameof(provedor));
            this._username = username ?? throw new ArgumentNullException(nameof(username));
            this._password = password ?? throw new ArgumentNullException(nameof(password));
        }

        public void sendEmail(List<string> emailsTo, string subject, string body, List<string> attachments)
        {

            var message = PreparateMessage(emailsTo, subject, body, attachments);

            SendEmailBySmtp(message);

        }

        public MailMessage PreparateMessage(List<string> emailsTo, string subject, string body, List<string> attachments)
        {
            var mail = new MailMessage();
            mail.From = new MailAddress(this._username);

            foreach (var email in emailsTo)
            {
                if (ValidateEmail(email))
                    mail.To.Add(email);
            }

            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

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
            SmtpClient smtpCliente = new SmtpClient(this._provedor, 587);
            smtpCliente.EnableSsl = true;
            smtpCliente.Timeout = 50000;
            smtpCliente.UseDefaultCredentials = true;
            smtpCliente.Credentials = new NetworkCredential(this._username, this._password);
            smtpCliente.Send(message);
            smtpCliente.Dispose();
        }



    }
}
