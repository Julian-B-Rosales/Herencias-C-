using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia.ModelsBase
{
    public abstract class Vehiculo
    {
        public int CantPasajeros { get; set; }
        public string Nombre { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public string IdVehiculo { get; set; }
    }
}
