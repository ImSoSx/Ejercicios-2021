using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_25_03
{
    public partial class Form1 : Form
    {
        int suma;
        public Form1()
        {
            InitializeComponent();
        }

        private void numeroUno_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if((int)e.KeyChar == (int)Keys.Enter)
                {
                    numeroDos_txt.Focus();
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void numeroDos_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    suma_btn.Focus();
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void suma_btn_Click(object sender, EventArgs e)
        {
            
            suma = Int32.Parse(numeroUno_txt.Text) + Int32.Parse(numeroDos_txt.Text);
            MessageBox.Show("La Suma Es: " + suma);
            siguiente_btn.Focus();
        }

        private void siguiente_btn_Click(object sender, EventArgs e)
        {
            Form2 miForm2 = new Form2(Convert.ToInt32(suma.ToString()));
            miForm2.Show();
            this.Hide();
        }
    }
}
