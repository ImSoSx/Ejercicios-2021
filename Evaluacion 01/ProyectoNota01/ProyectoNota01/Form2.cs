using System;
using System.Windows.Forms;

namespace ProyectoNota01
{
     partial class Form2 : Form
    {
        private Resultados res;
        public Form2(Resultados res)
        {
            InitializeComponent();
            CenterToScreen();
            lbl_PasajeArica.Text = res.pasajeArica.ToString();
            lbl_PasajeConce.Text = res.pasajeConce.ToString();
            lbl_PasajeSantiago.Text = res.pasajeSantiago.ToString();
            lbl_PasajePtoMontt.Text = res.pasajePtoMontt.ToString();
            lbl_TotalArica.Text = "$"+res.totalArica.ToString();
            lbl_TotalConce.Text = "$"+res.totalConce.ToString();
            lbl_TotalSantiago.Text = "$"+res.totalSantiago.ToString();
            lbl_TotalPtoMontt.Text = "$"+res.totalPtoMontt.ToString();
            txt_TotalFinal.Text = "$"+(res.totalArica + res.totalConce + res.totalSantiago + res.totalPtoMontt).ToString();
            txt_totalPasajes.Text = "$"+(res.pasajeArica + res.pasajeConce + res.pasajeSantiago + res.pasajePtoMontt).ToString();
            this.res = res;
            
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
