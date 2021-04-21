using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioNota_01
{
    class Extras
    {
        private int precio_;
        private int cant_;
        public Extras()
        {
            //Constructor Vacio
        }
        public String Tipo { get; set; }
        public String Nombre { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }

        public int Precios(String Nombre)
        {
            if (Nombre.Equals("Pollo"))
            {
                precio_ = 600;
            }
            if (Nombre.Equals("Atun"))
            {
                precio_ = 500;
            }
            if (Nombre.Equals("Vacuno"))
            {
                precio_ = 1000;
            }
            if (Nombre.Equals("Lata de Bebida"))
            {
                precio_ = 1500;
            }
            if (Nombre.Equals("Camarones"))
            {
                precio_ = 1000;
            }
            if (Nombre.Equals("Queso"))
            {
                precio_ = 700;
            }
            if (Nombre.Equals("Jamon"))
            {
                precio_ = 500;
            }
            return precio_;
        }
        public int CalcularSubtotal()
        {
            int subtotal;
            subtotal = precio_ * Cantidad;
            return subtotal;
        }
    }
}
