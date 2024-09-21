using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Individual_Salinas
{
    class Poder
    {
        private string nombre;
        private int daño;
        private int costoMana;

        public Poder(string nombre, int daño, int costoMana)
        {
            this.nombre = nombre;
            this.daño = daño;
            this.costoMana = costoMana;
        }

        public string ObtenerNombre()
        {
            return nombre;
        }

        public int ObtenerDaño()
        {
            return daño;
        }

        public int ObtenerCostoMana()
        {
            return costoMana;
        }
    }
}
}
