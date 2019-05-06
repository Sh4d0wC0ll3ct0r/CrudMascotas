using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppMascotas.Models
{
    public class CrudContext: DbContext 
    {
        public CrudContext() : base("CrudContextDemo")
        {

        }
        public DbSet<Mascota> Mascotas { get; set; }
    }
}