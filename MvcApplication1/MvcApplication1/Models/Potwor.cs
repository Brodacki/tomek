using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Potwor
    {

        [Key]
        public string id { get; set; }
        public string sciezka { get; set; }
        public string sciezkaBack { get; set; }
        public string rodzaj { get; set; }
        public int plansza { get; set; }
        public int zakladka { get; set; }
        public int punktStartowyLeft { get; set; }
        public int punktStartowyTop { get; set; }
        public int punktStartowyLeftTemp; 
        public int punktStartowyTopTemp;
        public int width { get; set; }
        public int height { get; set; }
        public int szybkosc { get; set; }
        public int punktyzycia { get; set; }
        public int punktymagi { get; set; }
        public int Atak { get; set; }
        public int Obrona { get; set; }
        public int ostatniruch  {get; set; }
        public int margin  {get; set; }

        public Potwor()
        {
            r = new Random();

        }
        public void UstawOstatniPunkt()
        {
            punktStartowyLeft = punktStartowyLeftTemp != 0 ? punktStartowyLeftTemp : punktStartowyLeft;
            punktStartowyTop = punktStartowyTopTemp != 0 ? punktStartowyTopTemp : punktStartowyTop;

        }

        Random r;
        public int AtakPotwora(Bohater b)
        {
           if (r.Next(Atak) > b.Obrona)
           {
               b.PunktyZycia--;
               if (b.PunktyZycia == 0)
               {
                   return 1;
               }
              
           }
           return 0;

        }


    }
}