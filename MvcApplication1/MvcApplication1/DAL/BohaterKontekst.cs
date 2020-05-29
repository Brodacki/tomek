using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcApplication1.Models;

namespace MvcApplication1.DAL
{
    public class BohaterKontekst
    {
      
        public DbSet<Bohater> bohater { get; set; }
       

    }
}