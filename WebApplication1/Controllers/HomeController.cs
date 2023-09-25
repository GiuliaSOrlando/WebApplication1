using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Fattura> listaFatture = new List<Fattura>();
            listaFatture.Add(new Fattura(new DateTime(2019, 02, 19),"Pinco", 300.00m));
            listaFatture.Add(new Fattura(new DateTime(2020, 05, 12), "Sempronio", 250.00m));
            listaFatture.Add(new Fattura(new DateTime(2022, 07, 23), "Caio", 1300.00m));
            return View(listaFatture);
        }

    }
}