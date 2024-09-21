using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Individual_Salinas
{
    class Jugador : Personaje
    {
        private int mana;

        public Jugador(string nombre, int vida, int fuerza, int mana) : base(nombre, vida, fuerza)
        {
            this.mana = mana;
        }

        public int ObtenerMana()
        {
            return mana;
        }

        public void AumentarMana(int valor)
        {
            mana += valor;
            if (mana <= 0)
            {
                Console.WriteLine($"{ObtenerNombre()} recupera {valor} puntos de mana.");
            }
        }

        public override void Atacar(Personaje objetivo)
        {
            Console.WriteLine($"{ObtenerNombre()} ataca a {objetivo.ObtenerNombre()} con {ObtenerFuerza()} de fuerza.");
            objetivo.RecibirDaño(ObtenerFuerza());
        }

        public void UsarPoder()
        {
            if (mana > 0)
            {
                Console.WriteLine($"{ObtenerNombre()} usa un ataque mágico.");
                mana--;
            }
            else
            {
                Console.WriteLine($"{ObtenerNombre()} no tiene suficiente mana.");
            }
        }

    }
}
