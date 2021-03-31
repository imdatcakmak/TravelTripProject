using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Sınıflar;
namespace TravelTripProject.Controllers
{
    public class IletisimController : Controller
    {
        Context c = new Context();
        // GET: Iletisim
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(Iletisim p)
        {
            c.Iletisims.Add(p);
            c.SaveChanges();
            return View();
        }
    }
}