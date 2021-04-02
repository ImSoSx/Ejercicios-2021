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
            try
            {
                Principal miEmpleado = new Principal(txtNombre.Text, Int32.Parse(txtCantHoras.Text));
                MessageBox.Show("Nombre: " + miEmpleado.nombre + "\nHoras: " + miEmpleado.horas + "\nTotal a pagar: " + miEmpleado.calcularPagoHoras().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el programa \nPorfavor verifique los datos ingresados");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = false;
                if (e.KeyChar == (char)Keys.Enter)
                {
                    txtCantHoras.Focus();
                }
            }
        }

        private void txtCantHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    btCalcular.Focus();
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
    }
}