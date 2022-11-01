using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia.ModelsBase
{
    public abstract class Aereo:Vehiculo
    {
        public int AlturaMaxima { get; set; }
        public int DistanciaMaxima { get; set; }
        public string TipoCombustible { get; set; }
    }
}
