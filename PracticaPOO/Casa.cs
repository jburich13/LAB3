using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaPOO
{
    class Casa
    {

        public List<Animal> mascotas;
        public List<Persona> familia;



        public Casa(List<Animal> mascotas, List<Persona> familia) {

            this.mascotas = mascotas;
            this.familia = familia;
        
        }


        public void mostrarHabitantes() {


            Console.WriteLine("Las mascotas son: ");
            foreach (Animal mascota in mascotas) {
                Console.WriteLine(mascota.ToString());
            }
            
            Console.WriteLine(Environment.NewLine +"Las personas de la familia  son: ");
            foreach (Persona persona in familia)
            {
                Console.WriteLine(persona.ToString());
            }
        }

    }
}
