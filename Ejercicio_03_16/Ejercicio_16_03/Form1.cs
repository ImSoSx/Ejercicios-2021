using System;
using System.Windows.Forms;

namespace Ejercicio1Clase1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_txt_Click(object sender, EventArgs e)
        {
            if (lbl_txt.Visible)
            {
                lbl_txt.Visible = false;
            }
            else
            {
                lbl_txt.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculo nuevoForm = new Calculo();
            nuevoForm.Show();
            this.Hide();
        }
    }
}