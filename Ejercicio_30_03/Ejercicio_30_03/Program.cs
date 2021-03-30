using System;

namespace Ejercicio_30_03
{
    internal class Empleado
    {
        private string nombre_;
        private int sueldoBase_;
        protected float cantHoras;

        private static void Main(string[] args)
        {
            Console.WriteLine("Uso de la clase!");
            Empleado miEmpleado = new Empleado("Jose", 300000, 40);
            Console.WriteLine("Su sueldo es: " + miEmpleado.calcularSueldo());
            Console.WriteLine("Su Sueldo base es: " + miEmpleado.sueldoBase);
            Console.WriteLine("Sueldo extra:" + (miEmpleado.cantHoras * 7500));
            do
            {
                try
                {
                    Console.WriteLine("Ingrese nuevo Empleado");
                    miEmpleado.nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese nuevo sueldo base");
                    miEmpleado.sueldoBase = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese cantidad de horas trabajadas");
                    miEmpleado.cantHoras = Int32.Parse(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    miEmpleado.sueldoBase = 0;
                }
            } while (miEmpleado.sueldoBase <= 0);
            Console.WriteLine("Su sueldo es " + miEmpleado.nombre);
            Console.WriteLine("Su sueldo es " + miEmpleado.calcularSueldo());
            Console.WriteLine("Su Sueldo base es: " + miEmpleado.sueldoBase);
            Console.WriteLine("Sueldo extra:" + (miEmpleado.cantHoras * 7500));
            Console.ReadLine();
        }

        public Empleado(string nombre, int sueldoBase, float cantHoras)
        {
            this.nombre = nombre;
            this.sueldoBase = sueldoBase;
            this.cantHoras = cantHoras;
        }

        public int sueldoBase
        {
            get
            {
                return this.sueldoBase_;
            }

            set
            {
                if (value > 0)
                {
                    this.sueldoBase_ = value;
                }
                else
                {
                    Console.WriteLine("Error Ingrese un valor");

                    this.sueldoBase_ = 0;
                }
            }
        }
        public string nombre
        {
            get
            {
                return this.nombre_;
            }

            set
            {
                if (value.Length>0)
                {
                    this.nombre_ = value;
                }
                else
                {
                    Console.WriteLine("Error Ingrese un Nombre");

                    this.nombre_ = "";
                }
            }
        }

        public double calcularSueldo()
        {
            double sueldoLiquido;
            sueldoLiquido = sueldoBase + cantHoras * 7500;
            return sueldoLiquido;
        }

    }
}
