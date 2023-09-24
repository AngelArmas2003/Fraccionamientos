using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace BibliotecaClases.Entidades
{
   public  class cUtilerias
    {
        public int Enviar_Mail_Attachments(string MailDestino, String Asunto, string Body, string adj)

        {

            try
            {
                int Resp = 0;

                Emails oemail = new Emails();

                var omail = oemail.Consulta_Emails();


                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();

                mail.To.Add(MailDestino);

                //mail.To.Add("angelarmas2003@hotmail.com");
                mail.Subject = Asunto;
                mail.SubjectEncoding = System.Text.Encoding.UTF8;

                // mail.Bcc.Add("angelarmas2003@gmail.com");

                mail.Body = Body;

                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = true;
                mail.From = new System.Net.Mail.MailAddress(omail.Email);


                mail.Attachments.Add(new Attachment(adj, System.Net.Mime.MediaTypeNames.Application.Pdf));


                System.Net.Mail.SmtpClient oclente = new System.Net.Mail.SmtpClient();
                oclente.DeliveryMethod = SmtpDeliveryMethod.Network;

                oclente.UseDefaultCredentials = false;
                oclente.Credentials = new System.Net.NetworkCredential(omail.Email, omail.Contraseña);
                oclente.Port = Convert.ToInt32(omail.Port);
                oclente.EnableSsl = true;
                oclente.Host = omail.smtp;
                oclente.EnableSsl = true;






                try
                {

                    oclente.Send(mail);

                    Resp = 1;

                }
                catch (Exception e)

                {
                    Resp = 2;


                }


                return Resp;
            }
            catch (Exception e)
            {
                return 0;
            }

        }
    }
}
