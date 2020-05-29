using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
   // public delegate void ZmienPotwory(string idPotwora);
    public class Plansza1
    {
        public int numerPlanszy;
      //  public ZmienPotwory zp;
        public List<Potwor> potwory;
        public MvcApplication1.DAL.PotworyKontekst pk;
        public void OdejmijPunktyZycia(string potworID)
        {
            Potwor p = potwory.Where(a => a.id == potworID).First();
            p.punktyzycia--;
            potwory.Remove(potwory.Where(a => a.id == potworID).First());
            potwory.Add(p);
        }


        public void OdswiezPotwory()
        {
            pk = new DAL.PotworyKontekst();
            potwory = pk.potwory.ToList();
            int u = 6;
        }
        //public void ZmienPotw(string potworID)
        //{


        //}

        public List<Potwor> UzupelnijListePotw() {

            return potwory;
        }
        public Plansza1()
        {
           // System.Web.HttpContext.Current.Application["BazaPotworow"] = pk;
            
            pk = new DAL.PotworyKontekst();



            foreach (var item in pk.potwory)
            {
                item.punktyzycia = 3;
            }

            pk.SaveChanges();

            potwory = pk.potwory.ToList();

            //pk.potwory.Add(new Potwor()
            //{
            //    id ="fname2",
            //    rodzaj ="Siepacz",
            //    sciezka = "../../Images/Potwor12bb.gif",
            //    sciezkaBack = "../../Images/Potwor12bbBack.gif",
            //    plansza =1,
            //    zakladka =1,
            //    punktStartowyLeft = 400,
            //    punktStartowyTop = 383,
            //    width =74,
            //    height=94,
            //    szybkosc =7, 
            //    margin=10,
            //    punktymagi =0,
            //    punktyzycia =3,
            //    ostatniruch = 2

            //});


            //pk.potwory.Add(new Potwor()
            //{
            //    id = "fname3",
            //    rodzaj = "Młociarz",
            //    sciezka = "../../Images/MlotPotwor_.gif",
            //    sciezkaBack = "../../Images/MlotPotworBack_.gif",
            //    plansza = 1,
            //    zakladka = 1,
            //    punktStartowyLeft = 400,
            //    punktStartowyTop = 340,
            //    width = 90,
            //    height = 120,
            //    szybkosc = 4,
            //    margin = 0,
            //    punktymagi = 0,
            //    punktyzycia = 3,
            //    ostatniruch = 2

            //});

          //  pk.SaveChanges();
          //  potwory = pk.potwory.ToList();//new List<Potwor>();
            //potwory = new List<Potwor>();
         
            //potwory.Add(new Potwor()
            //{
            //    id ="fname2",
            //    rodzaj ="Siepacz",
            //    sciezka = "../../Images/Potwor12bb.gif",
            //    sciezkaBack = "../../Images/Potwor12bbBack.gif",
            //    plansza =1,
            //    zakladka =1,
            //    punktStartowyLeft = 400,
            //    punktStartowyTop = 383,
            //    width =74,
            //    height=94,
            //    szybkosc =7, 
            //    margin=10,
            //    punktymagi =0,
            //    punktyzycia =3

            //});

            //potwory.Add(new Potwor()
            //{
            //    id = "fname3",
            //    rodzaj = "Młociarz",
            //    sciezka = "../../Images/MlotPotwor_.gif",
            //    sciezkaBack = "../../Images/MlotPotworBack_.gif",
            //    plansza = 1,
            //    zakladka = 1,
            //    punktStartowyLeft = 400,
            //    punktStartowyTop = 340,
            //    width = 90,
            //    height = 120,
            //    szybkosc = 4,
            //    margin=0,
            //    punktymagi = 0,
            //    punktyzycia = 3
            //});




          
        }

    }
}