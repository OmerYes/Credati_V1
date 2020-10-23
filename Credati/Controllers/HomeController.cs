using System;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult Contact(string name)
        {
            return View();
        }
    }
}