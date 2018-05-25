using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina
{
    public class Cubierto
    {
        private string nombre;

        public string Nombre { get => nombre; set => nombre = value; }

        public virtual void Usar()
        {

        }
    }
}
