using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SendEmail.Services
{
    public class EmailService
    {
        public List<string> FileNames = new List<string>();

        public void GetAttachment()
        {
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.Multiselect = true;
                fileDialog.Filter = @"Todos os arquivos (*.*)|*.*";

                if (fileDialog.ShowDialog() != DialogResult.OK) return;

                foreach (var file in fileDialog.FileNames)
                    FileNames.Add(file);
            }
        }

        public void SendEmail(EmailParameters parameters)
        {
            var mail = new MailMessage();

            mail.Sender = new System.Net.Mail.MailAddress(parameters.EmailFrom, parameters.EmailTo);
            mail.From = new MailAddress(parameters.EmailFrom, parameters.UserNameFrom);
            mail.To.Add(new MailAddress(parameters.EmailTo));
            mail.Subject = parameters.Subject;
            mail.Body = $"<h4>{parameters.Message}</h4>";
            mail.Priority = MailPriority.Normal;
            mail.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                smtp.Host = !string.IsNullOrEmpty(parameters.Host) ? parameters.Host : "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(parameters.EmailFrom, parameters.Password);

                foreach (var fileName in FileNames)
                    mail.Attachments.Add(new Attachment(fileName));

                smtp.Send(mail);
            }
        }

        public bool ValidMail(string mail)
        {
            return Regex.IsMatch(mail,
                @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                RegexOptions.IgnoreCase);
        }
    }
}
