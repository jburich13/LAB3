using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaPOO
{
    class Barrio
    {
        private string nombre { get; set; }
        private bool tieneAlumbrado { get; set; }
        private bool tieneAsfalto { get; set; }
        private string zona { get; set; }
        private List<Casa> casas { get; set; }



        public Barrio(string nombre, bool tieneAlumbrado, bool tieneAsfalto, string zona, List<Casa> casas ) {
            this.nombre = nombre;
            this.tieneAlumbrado = tieneAlumbrado;
            this.tieneAsfalto = tieneAsfalto;
            this.zona = zona;
            this.casas = casas;
        }

        public void mostrarCasas()
        {
            foreach (Casa casa in casas) {
                Console.WriteLine(casa.ToString());
            }
        }
            

    }
}
