using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Individual_Salinas
{
    class Programa
    {
        static void Main(string[] args)
        {
            {
                bool continuar = true;

                while (continuar)
                {
                    Console.WriteLine("Seleccione una opción:");
                    Console.WriteLine("1. Jugar");
                    Console.WriteLine("2. Crear jugador");
                    Console.WriteLine("3. Crear enemigos");
                    Console.WriteLine("4. Salir");
                    string opcion = Console.ReadLine();

                    if (opcion == "4")
                    {
                        break;
                    }

                    switch (opcion)
                    {
                        case "1":
                            Jugar();
                            break;
                        case "2":
                            CrearJugador();
                            break;
                        case "3":
                            CrearEnemigo();
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Por favor, seleccione una opción correcta.");
                            break;
                    }

                    Console.WriteLine("¿Desea continuar? (s/n)");
                    string respuesta = Console.ReadLine().ToLower();

                    if (respuesta != "s")
                    {
                        break;
                    }
                }
            }
        }

        static void Jugar()
        {
            
        }
    }
}
