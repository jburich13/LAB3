using System;
using System.Collections.Generic;

namespace PracticaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Juan", "Masculino", 22, "11/12/1998");

            Padre papa1 = new Padre("Pedro", "Masculino", 22, "11/12/1998", "Que te importa salame");

            Hijo hijo1 = new Hijo("Luis", "Masculino", 22, "11/12/1998", "Que te importa salame te dice el hijo");


            Animal mascota1 = new Animal("Perro", "DogChow", "Panchito", "Labrador");
            Domestico mascota2 = new Domestico("Gato", "CatChow", "Mushu", "Callejero", 10);
            Salvaje mascota3 = new Salvaje("Puma", "Carne humana", "Sultan", "ES UN PUMA", "Desconocido");


            List<Persona> familia1 = new List<Persona>();
            List<Animal> mascotas1 = new List<Animal>();

            familia1.Add(persona1);
            familia1.Add(papa1);
            familia1.Add(hijo1);


            mascotas1.Add(mascota1);
            mascotas1.Add(mascota2);
            mascotas1.Add(mascota3);


            Mueble mesa = new Mueble("Mesa");
            Mueble silla = new Mueble("Silla");
            Mueble sofa = new Mueble("Sofa");

            List<Mueble> muebles = new List<Mueble>();
            muebles.Add(mesa);
            muebles.Add(silla);
            muebles.Add(sofa);



            Cocina cocina = new Cocina("Cocina", 10, 10, muebles, "Cocina de 3 hornallas");
            Baño baño = new Baño("Baño", 10, 10, muebles, "Ducha Electrica");



            List<Ambiente> habitaciones = new List<Ambiente>();
            habitaciones.Add(cocina);
            habitaciones.Add(baño);


            Internet wifi = new Internet("Wifi", "Fibertel", 1000, "100mb");
            Luz luz = new Luz("Luz", "SECHEEP", 10000, "Trifasica");
            TV television = new TV("Television", "Cablevision", 5000, "Por Cable");



            List<Servicio> servicios = new List<Servicio>();

            servicios.Add(wifi);
            servicios.Add(luz);
            servicios.Add(television);


            Casa casa1 = new Casa(mascotas1, familia1, habitaciones, servicios);

          
            casa1.mostrarHabitantes();
            Console.WriteLine("---------------------------------------------------");
            casa1.mostrarHabitaciones();
            Console.WriteLine("---------------------------------------------------");
            casa1.mostrarServicios();





        }
    }
}
