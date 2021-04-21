using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioNota_01
{
    class Pizza
    {
        private int precio_;
        public Pizza()
        {
            //Constructor vacio
        }
        public String Tipo { get; set; }
        public String TipoMasa { get; set; }
        public String Size { get; set; }
        public String Extras { get; set; }
        public int ValorExtras { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }

        public int Precios(String Size)
        {
            if (Size.Equals("Individual"))
            {
                precio_ = 3000;
            }
            if (Size.Equals("Mediana"))
            {
                precio_ = (int)(3000 * 1.25);
            }
            if (Size.Equals("Familiar"))
            {
                precio_ = (int)(3000 * 1.4);
            }
            //Retornar precio
            return precio_;
        }
    }
}
