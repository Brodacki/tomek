using MvcApplication1.DAL;
using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcApplication1
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

       internal Bohater b1;
       internal Plansza1 p1;
        internal PotworyKontekst pk;
        internal PotworyKontekst pk2;
        internal List<Potwor> potw;
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            // Use LocalDB for Entity Framework by default
            Database.DefaultConnectionFactory = new SqlConnectionFactory(@"Data Source=(localdb)\v11.0; Integrated Security=True; MultipleActiveResultSets=True");
             pk  = new PotworyKontekst();
             pk2 = new PotworyKontekst(); 
            System.Web.HttpContext.Current.Application["BazaPotworow"] = pk;
            System.Web.HttpContext.Current.Application["BazaPotworowOdczyt"] = pk2;
          
            b1= new Bohater()
            {
                Nazwa = "Robin",
                PunktyMagii = 3,
                PunktyZycia = 3,
                Atak = 3, 
                Obrona = 3,
                PunktStartowyLeft = 100,
                PunktStartowyTop = 383,
                PunktStartowyLeftTemp = 100,
                PunktStartowyTopTemp = 383

            };
            p1 = new Plansza1();
            System.Web.HttpContext.Current.Application["Bohater"] = b1;
            System.Web.HttpContext.Current.Application["ListaPotworow"] = p1.potwory;

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}