using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Individual_Salinas
{
    class Enemigo : Personaje
    {
        private string tipo;
        private List<Enemigo> enemigos;

        public Enemigo(string tipo, string nombre, int vida, int fuerza) : base(nombre, vida, fuerza)
        {
            this.tipo = tipo;
            this.enemigos = new List<Enemigo>();
        }

        public string ObtenerTipo()
        {
            return tipo;
        }

        public void AgregarEnemigo(Enemigo enemigo)
        {
            enemigos.Add(enemigo);
        }

        public override void Atacar(Personaje objetivo)
        {
            Console.WriteLine($"{ObtenerNombre()} ataca a {objetivo.ObtenerNombre()} con {ObtenerFuerza()} de fuerza.");
            objetivo.RecibirDaño(ObtenerFuerza());
        }
    }
}
