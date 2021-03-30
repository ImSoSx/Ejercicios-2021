using System;
using System.Windows.Forms;

namespace Ejercicio_25_03
{
    public partial class Form2 : Form
    {
        public Form2(int valor)
        {
            InitializeComponent();
            this.valorSuma_txt.Text = valor.ToString();
            valorSuma_txt.Focus();
        }

        private void salir_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}