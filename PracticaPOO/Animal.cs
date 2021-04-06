using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaPOO
{
    class Animal : Familia
    {
        private string nombre { get; set; }
        private string tipo { get; set; }



        public Animal(string clase, string dieta, string nombre, string tipo) : base(clase, dieta)
        {
            this.nombre = nombre;
            this.tipo = tipo;

        }

        public override string ToString()
        {
            return Environment.NewLine + "Nombre: " + nombre + Environment.NewLine + "Tipo: "+ tipo;

        }
    }


    class Domestico : Animal
    {
        private int edad  { get; set; }


        public Domestico(string clase, string dieta, string nombre, string tipo, int edad) : base(clase, dieta, nombre, tipo){
            this.edad = edad;
        }


        public override string ToString()
        {
            return base.ToString()+ Environment.NewLine + "Edad: " + edad;

        }

    }

    class Salvaje : Animal 
    { 
        private string origen { get; set; }

        public Salvaje(string clase, string dieta, string nombre, string tipo, string origen) : base(clase, dieta, nombre, tipo)
        {
            this.origen = origen;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Origen: " + origen;

        }



    }
}
