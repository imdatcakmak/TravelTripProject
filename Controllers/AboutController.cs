﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Sınıflar;
namespace TravelTripProject.Controllers
{
    public class AboutController : Controller
    {
        
        Context c = new Context();
        // GET: About
        Hakkimizda snf = new Hakkimizda();
        
        public ActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}