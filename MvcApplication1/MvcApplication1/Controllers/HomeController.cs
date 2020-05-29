using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
using MvcApplication1.DAL;


namespace MvcApplication1.Controllers
{

   
    public class HomeController : Controller
    {
        // HttpContext.["LicenseFile"]
        Plansza1 p1;
        Potwor pp;
        public Bohater b1;
        public static int CzyTwojaTura = 0;
        PotworyKontekst pk;
        PotworyKontekst pk2;
        public void AtakBohatera(){

            int a = 6;

            }

        public HomeController()
        {

            p1 = new Plansza1();
            pk = ((PotworyKontekst)System.Web.HttpContext.Current.Application["BazaPotworow"]);
            pk2 = ((PotworyKontekst)System.Web.HttpContext.Current.Application["BazaPotworowOdczyt"]);
            var t = System.Web.HttpContext.Current.Application["Bohater"];


            //b1;
           // TempData["Bohater"] = b1;
        }
         [HttpGet]  
        public ActionResult Index()
        {
           
           // b1.PunktyZycia = 2;
            
             // TempData["doc"] = b1;
          
           
            ViewBag.Message = "Welcome to ASP.NET MVC!";
          

            return View((List<Potwor>)(System.Web.HttpContext.Current.Application["ListaPotworow"]));
         //   return View(pk.potwory.ToList());
           // return View(p1.potwory.ToList());
         }

          [HttpPost]  
         public ActionResult Index(string potworID1="1")
        {
         
          //  ViewData["doc"] = b1;
           // TempData["Bohater"] = b1;
           // b1.PunktyZycia = 2;
           // var t =  Request["plansza1"];
            var t = HttpContext.Request;
               ViewBag.Message = "Welcome to ASP.NET MVC!";

         //      return View("Walka", (p1.potwory.Where(a => a.id == potworID).First()));
               return RedirectToAction("Walka", "Home", new { potworID = potworID1 });
        }

         [HttpGet] 
        public ActionResult Walka(string potworID )
        {
           // b1 = (Bohater)TempData["Bohater"];
           // pk2.Entry<Potwor>().Reload();
           // pk2.Database.Connection.Open();
           // pk.Dispose();
           // pk = new PotworyKontekst();

           // pp = pk.potwory.Where(a => a.id == potworID).First();
            var p = Request.Form["labelAtakBohater"];

            if( ((List<Potwor>)(System.Web.HttpContext.Current.Application["ListaPotworow"])).Where(a => a.id == potworID).Count() != 0)
            pp = ((List<Potwor>)(System.Web.HttpContext.Current.Application["ListaPotworow"])).Where(a => a.id == potworID).First();
             //  p1.OdswiezPotwory(); 
             if(pp != null)
            return View(pp);
             else
                 return View(new Potwor() {rodzaj = "default", id ="default" });
           // return View((p1.potwory.Where(a => a.id == potworID).First()));
        }
        [HttpPost]
         public int Walka(string potworID, int par=0)
        {
            int wynikWalki=0;
           // b1 = (Bohater)TempData["Bohater"];
            if (par == 0)
            {

               // pk = new PotworyKontekst();
                pp = ((List<Potwor>)(System.Web.HttpContext.Current.Application["ListaPotworow"])).Where(a => a.id == potworID).First();
                wynikWalki =(pp).AtakPotwora((Bohater)System.Web.HttpContext.Current.Application["Bohater"]);

                //p1.potwory = pk.potwory.ToList();
           //     pp = pk.potwory.Where(a => a.id == potworID).First();

             //   int k = 0;
               // pk.SaveChanges();
            }
            else if (par == 1)
            {
             //   pk = new PotworyKontekst();
                pp = ((List<Potwor>)(System.Web.HttpContext.Current.Application["ListaPotworow"])).Where(a => a.id == potworID).First();
                wynikWalki =((Bohater)System.Web.HttpContext.Current.Application["Bohater"]).AtakBohatera(pp);

               if (wynikWalki == 1)
                {
                    ((List<Potwor>)(System.Web.HttpContext.Current.Application["ListaPotworow"])).Remove(pp);
                    ((List<Potwor>)(System.Web.HttpContext.Current.Application["ListaPotworow"])).ForEach(x => x.UstawOstatniPunkt());
                    ((Bohater)System.Web.HttpContext.Current.Application["Bohater"]).UstawOstatniPunkt();
                }

               // p1.potwory = pk.potwory.ToList();

               // pp = pk.potwory.Where(a => a.id == potworID).First();
               // pk.SaveChanges();
            }

           

           // Potwor p2 = p1.potwory.Where(a => a.id == potworID).First();

            //p2.punktyzycia--;

           //// return RedirectToAction("Walka", potworID);
           // pk.Database.Connection.Close();
           // pk.Database.Connection.Open();
           //return View(pp);
            return wynikWalki;
            //return View((p1.potwory(a => a.id == potworID).First()));
            
        }
        [HttpGet]
        public ActionResult GameOver()
        {
            return View();
        }
        public ActionResult Zamekironfirst()
        {

            int oo = 9;
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
