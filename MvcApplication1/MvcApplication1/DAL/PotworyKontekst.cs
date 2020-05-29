using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcApplication1.Models;

namespace MvcApplication1.DAL
{
    public class PotworyKontekst: DbContext
    {
        public PotworyKontekst() : base("DefaultConnection") { }

        public DbSet<Potwor> potwory{get; set;}
    }
}