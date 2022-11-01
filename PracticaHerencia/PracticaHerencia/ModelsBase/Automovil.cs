using PracticaHerencia.ModelsBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia.Models
{
    public abstract class Automovil:Terrestre
    {
        public string Tipo { get; set; }
        public int CantPuertas { get; set; }
    }
}
