using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppMascotas.Models
{
    public class Mascota
    {
        public int MascotaId { get; set; }
        public string Name { get; set; }
        public string Raza { get; set; }
        public string Dueño { get; set; }
        public int Edad { get; set; }
        public string ColorPelo { get; set;}
    }
}