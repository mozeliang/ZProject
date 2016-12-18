using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Z.Core.Common
{
    public class Class1
    {
        public void SendMailLocalhost()
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add("307096439@qq.com");
            mailMessage.CC.Add("2465076979@qq.com");

            mailMessage.From = new MailAddress("mozelianglzy1123@163.com", "xiaomo", System.Text.Encoding.UTF8);
            mailMessage.Subject = "这是测试邮件";
            mailMessage.Body = "水水水水";
            mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
            mailMessage.IsBodyHtml = false;
            mailMessage.Priority = MailPriority.High;

            SmtpClient client = new SmtpClient();
            client.Host = "localhost";

            object userState = mailMessage;
            try
            {
                client.SendAsync(mailMessage, userState);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
