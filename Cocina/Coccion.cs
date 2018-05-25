using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina
{
    public class Coccion:Electrodomestico
    {
        public void Cocer(Alimento alimento)
        {
            if(Encendido == true)
            {
                Console.WriteLine("Tu Alimento se ha cocinado ");
                alimento = new Alimento();
            }
            

        }
    }
}
