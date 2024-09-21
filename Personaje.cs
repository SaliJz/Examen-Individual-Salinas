using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Individual_Salinas
{
    class Personaje
    {
        private string nombre;
        private int vida;
        private int fuerza;

        public Personaje(string nombre, int vida, int fuerza)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.fuerza = fuerza;
        }

        public string ObtenerNombre()
        { 
            return nombre; 
        }

        public int ObtenerVida() 
        { 
            return vida; 
        }

        public int ObtenerFuerza()
        { 
            return fuerza;
        }

        public virtual void Atacar(Personaje objetivo)
        {
            Console.WriteLine($"{nombre} ataca a {objetivo.ObtenerNombre()} con {fuerza} de fuerza.");
            objetivo.RecibirDaño(fuerza);
        }

        public void RecibirDaño(int daño)
        {
            vida -= daño;
            if (vida <= 0)
            {
                Console.WriteLine($"{nombre} ha sido derrotado.");
            }
        }

        public void MostrarEstado()
        {
            Console.WriteLine($"{nombre}: Vida: {vida}, Fuerza: {fuerza}");
        }
    }
}
