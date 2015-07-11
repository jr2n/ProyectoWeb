using PublicacionApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PublicacionApp.Context
{
    public class PublicacionContext : DbContext
    {
        public DbSet<Publicacion> Publicaciones { get; set; }
    }
}