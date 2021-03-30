using System;

namespace Ejercicio_30_03_02
{
    internal class Principal
    {
        public string nombre;
        private int horas_;

        public Principal(String nombre, int horas)
        {
            this.nombre = nombre;
            this.horas_ = horas;
        }

        public int horas
        {
            get
            {
                return this.horas_;
            }
            set
            {
                this.horas_ = value;
            }
        }

        public int calcularPagoHoras()
        {
            int pagoHoras;
            pagoHoras = horas * 5000;
            return (pagoHoras);
        }
    }
}