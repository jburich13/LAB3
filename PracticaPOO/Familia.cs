using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaPOO
{
    class Familia
    {
        private string clase { get; set; }
        private string dieta { get; set; }

        public Familia(string clase, string dieta) {
            this.clase = clase;

            this.dieta = dieta;
        
        }
    }
}
