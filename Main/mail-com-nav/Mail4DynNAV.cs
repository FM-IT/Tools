using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Net.Mail;

namespace Mail4DynNAV
{
    [ComVisible(true)]
    [Guid("4b4c8c30-7e4b-414b-9c1e-ca25dcc403a1")]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("Mail4DynNAV")]
    public class Mail4DynNAV
    {
        MailMessage mail;
        SmtpClient SmtpServer;
        string LastMsg;

        [ComVisible(true)]
        public void Init(string MailServer, int MailPort, string UserName, string PassWord, string UserDomain, bool EnableSSL)
        {
            SmtpServer = new SmtpClient(MailServer); //smtp.gmail.com
            SmtpServer.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            if (MailPort != 0)
            {
                SmtpServer.Port = MailPort; //587;
            }
            
            if (UserName != "")
            {
                SmtpServer.UseDefaultCredentials = false;
                if (UserDomain != "")
                {
                    SmtpServer.Credentials = new System.Net.NetworkCredential(UserName, PassWord, UserDomain);
                }
                else
                {
                    SmtpServer.Credentials = new System.Net.NetworkCredential(UserName, PassWord);
                }
            }
            else
            {
                SmtpServer.UseDefaultCredentials = false; 
                SmtpServer.Credentials = new System.Net.NetworkCredential();
            }
            SmtpServer.EnableSsl = EnableSSL;
        }
        
        [ComVisible(true)]
        public void NewMessage(string SenderName, string SenderAddress, string Recipiant, string Subject, string Body)
        {
            mail = new MailMessage();

            mail.From = new MailAddress(SenderAddress);
            mail.To.Add(new MailAddress(Recipiant));
            mail.Subject = Subject;
            mail.Body = Body;
        }

        [ComVisible(true)]
        public void AddAttachment(string FileName)
        {
            mail.Attachments.Add(new Attachment(FileName));
        }

        [ComVisible(true)]
        public void AddAttachmentStream(System.IO.Stream AttachmentStream, string AttachmentName, string AttachmentMediaType)
        {
            mail.Attachments.Add(new Attachment(AttachmentStream, AttachmentName, AttachmentMediaType));
        }
        [ComVisible(true)]
        
        public bool Send()
        {
            try
            {
                SmtpServer.Send(mail);
                return (true);
            }
            catch (Exception e)
            {
                LastMsg = e.ToString();
                return (false);
            }
        }

        [ComVisible(true)]
        public string GetLastMessage()
        {
            return (LastMsg);
        }
    }
}