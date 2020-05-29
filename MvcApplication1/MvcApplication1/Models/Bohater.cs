using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication1.DAL;


namespace MvcApplication1.Models
{
    public class Bohater
    {

      public PotworyKontekst pkb; 
      public  Bohater()
        {
            r = new Random();
            pkb =((PotworyKontekst)System.Web.HttpContext.Current.Application["BazaPotworow"]); 
        }

        public void UstawOstatniPunkt(){
            PunktStartowyLeft = PunktStartowyLeftTemp;
            PunktStartowyTop = PunktStartowyTopTemp;

        }
        Random r;
        public string Nazwa { get; set; }
        public int PunktyZycia { get; set; }
        public int PunktyMagii { get; set; }
        public int PunktStartowyLeft { get; set; }
        public int PunktStartowyTop { get; set; }
        public int PunktStartowyLeftTemp { get; set; }
        public int PunktStartowyTopTemp { get; set; }
        public int Atak { get; set; }
        public int Obrona { get; set; }
        public int AtakBohatera(Potwor IDPotwora)
        {

          //  pkb = new PotworyKontekst();
          // Potwor p =  pkb.potwory.Where(a => a.id == IDPotwora).First();
           // IDPotwora.punktyzycia--;
            //pkb.SaveChanges();
            int pp3 = r.Next(Atak);

            if (pp3 > IDPotwora.Obrona)
            {
                IDPotwora.punktyzycia--;
                if (IDPotwora.punktyzycia ==0)
                {
                    return 1;
                }

                
            }
            return 0;

        }


    }
}