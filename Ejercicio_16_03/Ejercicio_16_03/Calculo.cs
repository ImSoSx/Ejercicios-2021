using System;
using System.Windows.Forms;

namespace Ejercicio1Clase1
{
    public partial class Calculo : Form
    {
        public Calculo()
        {
            InitializeComponent();
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Int32.Parse(txtNumero1.Text);
                int num2 = Int32.Parse(txtNumero2.Text);
                int suma = num1 + num2;

                MessageBox.Show("La suma es: " + suma);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la operacion." + "\nVerifique que los datos ingresados sean numeros y vuelva a intentarlo");
                txtNumero1.Text = "";
                txtNumero2.Text = "";
            }
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Int32.Parse(txtNumero1.Text);
                int num2 = Int32.Parse(txtNumero2.Text);
                int resta = num1 - num2;

                MessageBox.Show("La resta es: " + resta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la operacion." + "\nVerifique que los datos ingresados sean numeros y vuelva a intentarlo");
                txtNumero1.Text = "";
                txtNumero2.Text = "";
            }
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Int32.Parse(txtNumero1.Text);
                int num2 = Int32.Parse(txtNumero2.Text);
                int multi = num1 * num2;

                MessageBox.Show("La multiplicación es: " + multi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la operacion." + "\nVerifique que los datos ingresados sean numeros y vuelva a intentarlo");
                txtNumero1.Text = "";
                txtNumero2.Text = "";
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Int32.Parse(txtNumero1.Text);
                int num2 = Int32.Parse(txtNumero2.Text);
                if (num2 == 0)
                {
                    MessageBox.Show("No se puede dividir por 0");
                    return;
                }
                else if (num1 < num2)
                {
                    MessageBox.Show("El primer número no puede ser menor que el segundo");
                    txtNumero1.Text = "";
                    txtNumero1.Focus();
                    return;
                }
                int div = num1 / num2;

                MessageBox.Show("La división es: " + div);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la operacion." + "\nVerifique que los datos ingresados sean numeros y vuelva a intentarlo");
                txtNumero1.Text = "";
                txtNumero2.Text = "";
            }
        }
    }
}