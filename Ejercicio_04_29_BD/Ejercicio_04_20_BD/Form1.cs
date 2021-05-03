using System;
using System.Windows.Forms;

namespace Ejercicio_04_20_BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Servidor_txt.Text = @"DESKTOP-FERGADJ\SQLEXPRESS";
            Bd_txt.Text = "Programacion";
        }

        private void Conectar_btn_Click(object sender, EventArgs e)
        {
            if (Servidor_txt.Text == "" && Bd_txt.Text == "")
            {
                MessageBox.Show("Rellene y revise los campos para la conexion");
                Servidor_txt.Text = "";
                Bd_txt.Text = "";
            }
            else
            {
                Conexion cx = new Conexion();
                cx.Conectar(Servidor_txt.Text, Bd_txt.Text);
                dataGridView1.DataSource = cx.llenar_grid("alumnos");
            }
        }

        private void Siguiente_btn_Click(object sender, EventArgs e)
        {
            Form2 miform2 = new Form2(Servidor_txt.Text, Bd_txt.Text);
            miform2.Show();
        }
    }
}
