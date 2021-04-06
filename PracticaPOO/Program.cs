using System;
using System.Collections.Generic;

namespace PracticaPOO
{
    class Program
    {
        static void Main(string[] args)
        {









            Persona persona1 = new Persona("Juan", "Masculino", 22, "11/12/1998");
            //Console.WriteLine(persona1.ToString());

            Padre papa1 = new Padre("Pedro", "Masculino", 22, "11/12/1998", "Que te importa salame");
            //Console.WriteLine(papa1.ToString());

            Hijo hijo1 = new Hijo("Luis", "Masculino", 22, "11/12/1998", "Que te importa salame te dice el hijo");
            // Console.WriteLine(hijo1.ToString());


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

            Casa casa1 = new Casa(mascotas1, familia1);


            casa1.mostrarHabitantes();

            


        }
    }
}
