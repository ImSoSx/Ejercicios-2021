using System;

namespace ProyectoNota01
{
    class Buses
    {
        int precioBus = 0;
        public Buses()
        {
            //Constructor vacio
        }
        public String Tipo { get; set; }
        public int PrecioPasaje { get; set; }
        public int CalculoBus(String Tipo,int PrecioPasaje)
        {
            if (Tipo == "Clasico")
            {
                precioBus = PrecioPasaje;
            }
            if (Tipo == "SemiCama")
            {
                precioBus = (int)(PrecioPasaje * 1.15);
            }
            if (Tipo == "Cama")
            {
                precioBus = (int)(PrecioPasaje * 1.25);
            }
            return precioBus;
        }
    }
}
