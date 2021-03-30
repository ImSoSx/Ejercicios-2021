using System;
using System.Windows.Forms;

namespace Ejercicio_30_03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            Principal miEmpleado = new Principal(txtNombre.Text, Int32.Parse(txtCantHoras.Text));
            MessageBox.Show("Nombre: " + miEmpleado.nombre + "\nHoras: " + miEmpleado.horas + "\nTotal a pagar: " + miEmpleado.calcularPagoHoras().ToString());
        }
    }
}