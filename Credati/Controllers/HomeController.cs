using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Credati.Controllers
{
    [RoutePrefix("Credati")]
    public class HomeController : Controller
    {
        // GET: Home
        [Route("~/")]
        [Route("anasayfa")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("iletisim")]
        public ActionResult Contact()
        {
            return View();
        }
        [Route("hakkimizda")]
        public ActionResult About()
        {
            return View();
        }
        [Route("yazilim")]
        public ActionResult Software()
        {
            return View();
        }
        [Route("outsourcing")]
        public ActionResult Outsourcing()
        {
            return View();
        }
        [Route("bt-cozümleri")]
        public ActionResult It()
        {
            return View();
        }
        [Route("danismanlik")]
        public ActionResult Constult()
        {
            return View();
        }

        [Route("iletisim")]
        [HttpPost]
        public ActionResult Contact(string Name,string Body,string Email)
        {
            string smtpAddress = "smtp.gmail.com";
            int portNumber = 587;
            bool enableSSL = true;
            string emailFromAddress = "yesilmenomer47@gmail.com"; //Sender Email Address  
            string password = "2128292152120081035"; //Sender Password  
            string emailToAddress = "omer.yesilmen@bilgeadam.com"; //Receiver Email Address  
            string subject = " Contact formdan gelen mail";
            string body ="mail from :"+Email+"  gönderici adı  :"+Name+ "<br>"+"<br>"+ Body;

            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFromAddress);
                mail.To.Add(emailToAddress);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);

                }
            }


                    return View();
        }
    }
}