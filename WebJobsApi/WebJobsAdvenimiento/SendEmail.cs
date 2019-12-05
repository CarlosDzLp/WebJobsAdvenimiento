using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WebJobsAdvenimiento
{
    public class SendEmail
    {
        #region Singleton
        private static SendEmail _instance = null;
        public static SendEmail Instance
        {
            get 
            { 
                if (_instance == null) {  _instance = new SendEmail(); }
                return _instance;
            }
        }
        #endregion
        public void Email()
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add("xxxxxxxxxxxxxxxxxxx@hotmail.com");
            msg.From = new MailAddress("xxxxxxxxxxxxxxxxxx@hotmail.com", "xxxxxxxxxxxxxx", System.Text.Encoding.UTF8);
            msg.Subject = "envio de correo desde un Webjobs";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = "Este es un envio de correo desde un web jobs en azure #AdvenimientoXamarin";
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = false;
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("xxxxxxxxxxxxxxxxxxx@hotmail.com", "xxxxxxxxxxxxxxxxxxxxxxxx");
            client.Port = 587;
            client.Host = "smtp.live.com";                                          
            client.EnableSsl = true;
            try
            {
                client.Send(msg);
            }
            catch (System.Net.Mail.SmtpException)
            {              
            }
        }
    }
}
