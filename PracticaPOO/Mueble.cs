using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaPOO
{
    class Mueble
    {
        private string nombre { get; set; }
        public Mueble(string nombre) {
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return Environment.NewLine + "Mueble: " + nombre;

        }
    }
}
