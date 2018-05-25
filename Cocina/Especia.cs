using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina
{
    public class Especia:Alimento
    {
        public void Condimentar(Carne carne)
        {
            carne = new Carne();
            Console.WriteLine("Carne Condimentada");
        }
    }
}
