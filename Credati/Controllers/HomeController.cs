using System;
using System.Collections.Generic;
using System.Linq;
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
            SmtpClient smtpClient = new SmtpClient("domain.a2hosted.com", 25);

            smtpClient.Credentials = new System.Net.NetworkCredential("contact@credati.com", "7k!9agT5");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

            MailMessage mailMessage = new MailMessage(txtFrom.Text, txtTo.Text);
            mailMessage.Subject = txtSubject.Text;
            mailMessage.Body = txtBody.Text;

            
                smtpClient.Send(mailMessage);
                Label1.Text = "Message sent";
          
            return View();
        }
    }
}