using MortageDataSwitch.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace MortageDataSwitch.Services
{
    /// <summary>
    /// 
    /// </summary>
    public static class EmailProvider
    {
        /// <summary>
        /// Send email message
        /// </summary>
        /// <param name="recipients">multiple receipients comma point sepperated</param>
        /// <param name="subject">Mail subject</param>
        /// <param name="body">Body of the mail</param>
        public static void SendEmail(string subject, string body, string recipients)
        {
            try
            {
                string host = ConfigurationManager.AppSettings["Email.Smtp.Host"];
                string userName = ConfigurationManager.AppSettings["Email.Smtp.Username"];
                string password = ConfigurationManager.AppSettings["Email.Smtp.Password"];

                int.TryParse(ConfigurationManager.AppSettings["Email.Smtp.Port"], out var port);
                bool.TryParse(ConfigurationManager.AppSettings["Email.Smtp.EnableSsl"], out var enableSsl);

                if(string.IsNullOrEmpty(recipients))
                {
                    recipients = ConfigurationManager.AppSettings["Recipients"];
                }

                var arrRecipients = recipients.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                SmtpClient client = new SmtpClient();
                client.Port = port;
                client.Host = host;
                client.EnableSsl = enableSsl;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(userName, password);

                //var mailMessage = new MailMessage(userName, recipients, subject, body);
                var mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(userName);

                foreach(var recipient in arrRecipients)
                {
                    mailMessage.To.Add(new MailAddress(recipient));
                }

                mailMessage.Subject = $"Generated Mail - {subject}";
                mailMessage.Body = body;
                mailMessage.IsBodyHtml = false;
                mailMessage.BodyEncoding = UTF8Encoding.UTF8;
                mailMessage.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.Send(mailMessage);
            }
            catch { }
            
        }
    }
}