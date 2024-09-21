using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Individual_Salinas
{
    class Item
    {
        private string nombre;
        private string tipo;
        private int valor;

        public Item(string nombre, string tipo, int valor)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.valor = valor;
        }

        public string ObtenerNombre()
        {
            return nombre;
        }

        public string ObtenerTipo()
        {
            return tipo;
        }

        public int ObtenerValor()
        {
            return valor;
        }

        public void usar(Jugador jugador)
        {
            if (tipo == "Vida")
            {
                jugador.RecibirDaño(-valor);
                Console.WriteLine($"{nombre} usado. {jugador.ObtenerNombre()} recupera {valor} puntos de vida.");
            }
            else if (tipo == "Mana")
            {
                jugador.AumentarMana(valor);
                Console.WriteLine($"{nombre} usado. {jugador.ObtenerNombre()} recupera {valor} puntos de mana.");
            }
        }

    }
}
