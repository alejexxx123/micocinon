using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina
{
    public class Conservador:Electrodomestico
    {
        public void Refrigerar(Alimento alimento)
        {
            Cantidad_Max = 5;
            Console.WriteLine("La cantidad actual es {0}", Cantidad + "y la cantidad maxima es {0}",Cantidad_Max);
            if(Cantidad == Cantidad_Max)
            {
                Console.WriteLine("El Conservador esta Repleto");
            }
            else
            {
                Cantidad += 1;
            }

        }
    }
}
