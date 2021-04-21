using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioNota_01
{
    class Tacos
    {
        private int precio_;

        public Tacos()
        {
            //Constructor vacio
        }
        public String Tipo { get; set; }
        public String Relleno { get; set; }
        public String Extras { get; set; }
        public int ValorExtras { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }

        public int Precios(String Relleno)
        {
            if (Relleno.Equals("Mixto"))
            {
                precio_ = 3000;
            }
            if (Relleno.Equals("Pollo"))
            {
                precio_ = 3000;
            }
            if (Relleno.Equals("Atun"))
            {
                precio_ = 3000;
            }
            //Retornar precio
            return precio_;
        }
    }
}
