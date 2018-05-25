using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina
{
    public class Recipiente
    {
        private int cantidad;
        private int cantidad_max;

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Cantidad_max { get => cantidad_max; set => cantidad_max = value; }

        public virtual void Usar()
        {

        }
        public virtual void Preguntar_lleno()
        {

        }
    }
}
