using PracticaHerencia.ModelsBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia.Models
{
    public class Camion:Terrestre
    {
        public string TipoDeCarga { get; set; }
        public double PesoSoportado { get; set; }
    }
}
