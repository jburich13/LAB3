using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaPOO
{
    class Ambiente
    {
        private string nombre { get; set; }

        private int tamañoLargo { get; set; }

        private int tamañoAncho { get; set; }

        private List<Mueble> muebles { get; set; }

        public Ambiente(string nombre, int tamañoLargo, int tamañoAncho, List<Mueble> muebles)
        {
            this.nombre = nombre;
            this.tamañoAncho = tamañoAncho;
            this.tamañoLargo = tamañoLargo;
            this.muebles = muebles;
        }


        public void mostrarMuebles() {

            Console.WriteLine("Los muebles son: ");
            foreach (Mueble mueble in muebles) {
                Console.WriteLine(mueble.ToString());
            }
        
        }


        public override string ToString()
        {
            return Environment.NewLine + "Nombre: " + nombre + Environment.NewLine + "Ancho: " + tamañoAncho + Environment.NewLine + "Largo: " + tamañoLargo;
        }


    }

    class Baño : Ambiente
    {
        private string tipoDeDucha { get; set; }

        public Baño(string nombre, int tamañoLargo, int tamañoAncho, List<Mueble> muebles, string tipoDeDucha) : base(nombre, tamañoLargo, tamañoAncho, muebles) {
            this.tipoDeDucha = tipoDeDucha;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Tipo de ducha: " + tipoDeDucha;

        }
    }
    class Patio : Ambiente
    {
        private string materialDelPiso { get; set; }
        private bool tienePileta { get; set; }


        public Patio(string nombre, int tamañoLargo, int tamañoAncho, List<Mueble> muebles, string materialDelPiso, bool tienePileta) : base(nombre, tamañoLargo, tamañoAncho, muebles)
        {
            this.materialDelPiso = materialDelPiso;
            this.tienePileta = tienePileta;
        }
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Material del piso: " + materialDelPiso + Environment.NewLine + "Tiene pileta:  " + tienePileta;

        }
    }

    class Cocina : Ambiente
    {
        private string tipoDeCocina { get; set; }

        public Cocina(string nombre, int tamañoLargo, int tamañoAncho, List<Mueble> muebles, string tipoDeCocina) : base(nombre, tamañoLargo, tamañoAncho, muebles)
        {
            this.tipoDeCocina = tipoDeCocina;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Tipo de cocina: " + tipoDeCocina;

        }
    }

    class Terraza : Ambiente
    {
        private string tipoDeVista { get; set; }

        public Terraza(string nombre, int tamañoLargo, int tamañoAncho, List<Mueble> muebles, string tipoDeVista) : base(nombre, tamañoLargo, tamañoAncho, muebles)
        {
            this.tipoDeVista = tipoDeVista;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Tipo de vista: " + tipoDeVista;

        }
    }

    class Dormitorio : Ambiente
    {
        private string tipoDeCamas { get; set; }

        public Dormitorio(string nombre, int tamañoLargo, int tamañoAncho, List<Mueble> muebles, string tipoDeCamas) : base(nombre, tamañoLargo, tamañoAncho, muebles)
        {
            this.tipoDeCamas = tipoDeCamas;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Tipo de camas: " + tipoDeCamas;

        }
    }
}
