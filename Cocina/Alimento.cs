using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina
{
    public class Alimento
    {
        private int cantidad;
        private bool perecible;
        private string nombre;

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public bool Perecible { get => perecible; set => perecible = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public virtual void PreguntarVencido()
        {
            if(perecible == true)
            {
                Console.WriteLine("el producto esta vencido");
            }
            else
            {
                Console.WriteLine("el producto se encuentra en optimas condiciones");
            }
        }
    }
}
