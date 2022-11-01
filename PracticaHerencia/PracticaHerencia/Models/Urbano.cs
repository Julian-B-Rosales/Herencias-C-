using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia.Models
{
    internal class Urbano:Automovil
    {
        public string TipoCombustible { get; set; }
        public bool Baul { get; set; }
    }
}
