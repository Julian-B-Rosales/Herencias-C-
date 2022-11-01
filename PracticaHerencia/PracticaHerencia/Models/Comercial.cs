using PracticaHerencia.ModelsBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia.Models
{
    public class Comercial:Avion
    {
        public int CantTripulantes { get; set; }
        public string Aerolinea { get; set; }
    }
}
