using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia.ModelsBase
{
    public abstract class Terrestre:Vehiculo
    {
        public int CantRuedas { get; set; }
        public int Peso { get; set; }
        public int VelocidadMaxima { get; set; }
    }
}
