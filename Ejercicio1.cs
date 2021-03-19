using System;

namespace LAB_3
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;

            Console.WriteLine("Bienvenido a TuCalculadora! Que operación desea realizar?");
            Console.WriteLine("1-Tabla de multiplicar de un valor");
            Console.WriteLine("2-Sumar dos valores");
            Console.WriteLine("3-Restar dos valores");
            Console.WriteLine("4-Dividir dos valores");
            Console.WriteLine("5-Multiplicar dos valores");


            int usuario = Convert.ToInt32(Console.ReadLine());


            switch (usuario)
            {
                case 1:
                    tablaMultiplicar();
                    break;
                case 2:
                    sum();
                    break;
                case 3:
                    res();
                    break;
                case 4:
                    div();
                    break;
                case 5:
                    mul();
                    break;
                default:
                    Console.WriteLine("Ninguna de las opciones fue seleccionada");
                    break;


            }


            static void tablaMultiplicar()
            {
                Console.WriteLine("Ingrese el numero del que desea la tabla: ");
                int a = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i <= 10; i++)
                {
                    int resultado = a * i;
                    Console.WriteLine(a + "x" + i + "=" + resultado);
                }
            }

            static void sum()
            {
                Console.WriteLine("Ingrese el primer valor que desea sumar: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el primer valor que desea sumar: ");
                int b = Convert.ToInt32(Console.ReadLine());

                int resultado = a + b;
                Console.WriteLine("El resultado es: " + resultado);

            }

            static void res()
            {
                Console.WriteLine("Ingrese el primer valor que desea sumar: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el primer valor que desea sumar: ");
                int b = Convert.ToInt32(Console.ReadLine());

                int resultado = a - b;
                Console.WriteLine("El resultado es: " + resultado);
            }
            static void div()
            {
                Console.WriteLine("Ingrese el primer valor que desea sumar: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el primer valor que desea sumar: ");
                int b = Convert.ToInt32(Console.ReadLine());

                if (b == 0) {
                    Console.WriteLine("No se puede dividir por 0, intente de nuevo");
                    Environment.Exit(0);
                }
                int resultado = a / b;
                Console.WriteLine("El resultado es: " + resultado);

            }

            static void mul()
            {
                Console.WriteLine("Ingrese el primer valor que desea sumar: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el primer valor que desea sumar: ");
                int b = Convert.ToInt32(Console.ReadLine());

                int resultado = a * b;
                Console.WriteLine("El resultado es: " + resultado);

            }
        }
    }
}
