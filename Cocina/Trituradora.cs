using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina
{
    public class Trituradora:Electrodomestico
    {
        public void Triturar(Alimento alimento)
        {
            Console.WriteLine("tu {0} se esta triturando", alimento);
            alimento = new Alimento();

        }
    }
}
