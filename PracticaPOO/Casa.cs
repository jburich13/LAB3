using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaPOO
{
    class Casa
    {

        private List<Animal> mascotas { get; set; }
        private List<Persona> familias { get; set; }
        private List<Ambiente> ambientes { get; set; }
        private List<Servicio> servicios { get; set; }



        public Casa(List<Animal> mascotas, List<Persona> familias, List<Ambiente> ambientes, List<Servicio> servicios) {
            this.mascotas = mascotas;
            this.familias = familias;
            this.ambientes = ambientes;
            this.servicios = servicios;
        }

        public Casa(List<Animal> mascotas, List<Persona> familias, List<Ambiente> ambientes)
        {
            this.mascotas = mascotas;
            this.familias = familias;
            this.ambientes = ambientes;
        }


        public void mostrarHabitantes() {


            Console.WriteLine("Las mascotas son: ");
            foreach (Animal mascota in mascotas) {
                Console.WriteLine(mascota.ToString());
            }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(Environment.NewLine +"Las personas de la familia  son: ");
            foreach (Persona persona in familias)
            {
                Console.WriteLine(persona.ToString());
            }
        }


        public void mostrarHabitaciones() {

            
            Console.WriteLine(Environment.NewLine+"Las habitaciones son: ");
            foreach (Ambiente ambiente in ambientes)
            {
                Console.WriteLine(ambiente.ToString());
            }

        }

        public void mostrarServicios()
        {
            Console.WriteLine("Los servicios son: ");
            foreach (Servicio servicio in servicios)
            {
                Console.WriteLine(servicio.ToString());
            }

        }


    }
}
