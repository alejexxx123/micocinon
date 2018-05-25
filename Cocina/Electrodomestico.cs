using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina
{
    public class Electrodomestico
    {
        private bool encendido;
        private int cantidad;
        private int cantidad_Max;

        public bool Encendido { get => encendido; set => encendido = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Cantidad_Max { get => cantidad_Max; set => cantidad_Max = value; }
    }
}
