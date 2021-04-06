using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaPOO
{
    class Persona
    {
        private string nombre { get; set; }
        private string sexo { get; set; }
        private int edad { get; set; }
        private string fechaNac { get; set; }



        public Persona(string nombre, string sexo, int edad, string fechaNac) {
            this.nombre = nombre;
            this.sexo = sexo;
            this.edad = edad;
            this.fechaNac = fechaNac;
        }

        public override string ToString()
        {
            return Environment.NewLine + "Nombre: " + nombre + Environment.NewLine + "Sexo: " + sexo + Environment.NewLine + "Edad: " + edad + Environment.NewLine + "Fecha de nacimiento: " + fechaNac;

        }
    }


    class Padre : Persona {


        private string trabajo { get; set; }
        public Padre(string nombre, string sexo, int edad, string fechaNac, string trabajo) : base(nombre,sexo,edad,fechaNac) {
            this.trabajo = trabajo;
        
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Trabajo: " + trabajo;

        }

    }

    class Hijo : Persona {
        private string escuelaGrado { get; set; }

        public Hijo(string nombre, string sexo, int edad, string fechaNac, string escuelaGrado) : base(nombre, sexo, edad, fechaNac)
        {
            this.escuelaGrado = escuelaGrado;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Grado en la escuela: " + escuelaGrado;

        }
    }
    
}

