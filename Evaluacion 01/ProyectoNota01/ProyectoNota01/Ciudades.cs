using System;

namespace ProyectoNota01
{
    class Ciudades
    {
        int precio=0;
        public Ciudades(){
            //Constructor vacio
        }
        public String Origen { get; set; }
        public String Destino { get; set; }
        public int CalculoDestino(String Origen, String Destino)
        {
            //ARICA
            if (Origen == "Arica" && Destino == "Santiago")
            {
                precio = 95500;
            }
            else if (Origen == "Arica" && Destino == "Concepcion")
            {
                precio = 125400;
            }
            //SANTIAGO
            else if (Origen == "Santiago" && Destino == "Concepcion")
            {
                precio = 8500;
            }
            else if (Origen == "Santiago" && Destino == "Pto. Montt")
            {
                precio = 35300;
            } 
            else if (Origen == "Santiago" && Destino == "Arica")
            {
                precio = 95500;
            }
            //CONCEPCION
            else if (Origen == "Concepcion" && Destino == "Pto. Montt")
            {
                precio = 22000;
            }
            else if (Origen == "Concepcion" && Destino == "Arica")
            {
                precio = 125400;
            }
            else if (Origen == "Concepcion" && Destino == "Santiago")
            {
                precio = 8500;
            }
            //Puerto Montt
            else if (Origen == "Pto. Montt" && Destino == "Concepcion")
            {
                precio = 22000;
            }
            else if (Origen == "Pto. Montt" && Destino == "Santiago")
            {
                precio = 35300;
            }
            return precio;
        }
    }
}
