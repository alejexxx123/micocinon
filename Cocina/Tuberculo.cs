using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina
{
    public class Tuberculo:Alimento
    {
        public virtual void Cortar(Cubierto cubierto)
        {

        }

        public override void PreguntarVencido()
        {
            if(Perecible == true)
            {
                Console.WriteLine("Cuidado! un tuberculo vencido es muy toxico");
                Console.WriteLine("seguro que desea continuar? /n " +
                    "presione cualquier tecla para continuar");
                Console.ReadKey();
                Console.WriteLine("uy te has envenenado, has muerto");
                
            }
        }

    }
}
