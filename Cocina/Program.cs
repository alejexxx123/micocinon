using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a la cocina");
            Console.WriteLine("que carne desea usar?");
            if (Convert.ToString(Console.ReadLine()) != "pollo")
            {
                Console.WriteLine("en el mercado no hay :( ");
                CerrarPrograma();
            }
            else
            {
                Carne pollo = new Carne();

                Console.WriteLine("Deseas usar verduras?");

                if (Convert.ToString(Console.ReadLine()) == "si")
                {
                    Console.WriteLine("que tipo de verdura?");

                    if (Convert.ToString(Console.ReadLine()) == "lechuga")
                    {
                        Verdura lechuga = new Verdura();

                        Console.WriteLine("deseas condimentar el pollo?");
                        if (Convert.ToString(Console.ReadLine()) == "si")
                        {
                            Console.WriteLine("deseas echarle sal?");
                            if (Convert.ToString(Console.ReadLine()) == "si")
                            {
                                Especia sal = new Especia();
                                Console.WriteLine("se le ha puesto sal a la carne");
                                Carne polloconsal = new Carne();
                                pollo = polloconsal;
                                Console.WriteLine("es hora de cocinar algo rico");
                                Console.WriteLine("deseas usar la estufa?");
                                if(Convert.ToString(Console.ReadLine()) == "si")
                                {
                                    Coccion estufa = new Coccion();
                                    estufa.Encendido = true;
                                    estufa.Cocer(polloconsal);
                                    Console.WriteLine("te ha salido un rico pollo frito");
                                    Console.WriteLine("deseas acompañarlo con arroz?");
                                    if (Convert.ToString(Console.ReadLine()) == "si")
                                    {
                                        Cereal arroz = new Cereal();
                                        Coccion olla_arrocera = new Coccion();
                                        olla_arrocera.Cocer(arroz);
                                        Console.WriteLine("El arroz esta bien graneadito");
                                        Console.WriteLine("deseas algo mas?");
                                        if (Convert.ToString(Console.ReadLine()) == "si")
                                        {
                                            Console.WriteLine("ya no seas goloso");
                                            CerrarPrograma();
                                        }else if (Convert.ToString(Console.ReadLine()) == "no")
                                        {
                                            CerrarPrograma();
                                        }

                                    }
                                    else if (Convert.ToString(Console.ReadLine()) == "no")
                                    {
                                        Console.WriteLine("no te preocupes, es bueno estar a dieta");
                                        Console.WriteLine("Ahora estas satisfecho");
                                        CerrarPrograma();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Deseas comerlo crudo?");
                                    Console.ReadLine();
                                    Console.WriteLine("no te entendi pero debes ser cavernicola para querer comerlo crudo");
                                    CerrarPrograma();
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("las carnes sin especias es feo, has fallado en la vida");
                            CerrarPrograma();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Solo hay lechuga :( ");
                        CerrarPrograma();
                    }
                }
            }
            

            


            Console.ReadKey();
            
        }
        public static void CerrarPrograma()
        {
            Console.WriteLine("*-----------------------------*");
            Console.WriteLine("Presiona ESC para salir del programa");
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            Console.WriteLine("*-----------------------------*");
        }
    }
}
