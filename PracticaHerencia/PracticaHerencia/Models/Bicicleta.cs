using PracticaHerencia.ModelsBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia.Models
{
    public class Bicicleta:Terrestre
    {
        public double Rodado { get; set; }
        public int CantRayos { get; set; }
    }
}
