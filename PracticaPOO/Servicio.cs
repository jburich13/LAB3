using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaPOO
{
    class Servicio
    {
        private string nombre { get; set; }
        private string empresa { get; set; }
        private int precio { get; set; }
        public Servicio(string nombre, string empresa, int precio) {
            this.nombre = nombre;
            this.empresa = empresa;
            this.precio = precio;
        }


        public override string ToString()
        {
            return Environment.NewLine + "Nombre: "+ nombre + Environment.NewLine + "Empresa: "+ empresa + Environment.NewLine + "Precio: "+ precio;

        }
    }

    class Internet : Servicio {
    
        private string anchoDeBanda { get; set; }
        public Internet(string nombre, string empresa, int precio, string anchoDeBanda) : base(nombre, empresa,precio) {
            this.anchoDeBanda = anchoDeBanda;
        }


        public override string ToString()
        {
            return Environment.NewLine + base.ToString() + Environment.NewLine +"Ancho de banda: " + anchoDeBanda;

        }
    }
    class Luz : Servicio
    {

        private string tipoDeLuz { get; set; }
        public Luz(string nombre, string empresa, int precio, string tipoDeLuz) : base(nombre, empresa, precio)
        {
            this.tipoDeLuz = tipoDeLuz;
        }


        public override string ToString()
        {
            return Environment.NewLine + base.ToString() + Environment.NewLine + "Tipo de luz: " + tipoDeLuz;

        }
    }

    class TV : Servicio
    {

        private string tipoDeTV { get; set; }
        public TV(string nombre, string empresa, int precio, string tipoDeTV) : base(nombre, empresa, precio)
        {
            this.tipoDeTV = tipoDeTV;
        }


        public override string ToString()
        {
            return Environment.NewLine + base.ToString() + Environment.NewLine + "Tipo de TV: " + tipoDeTV;

        }
    }
}
