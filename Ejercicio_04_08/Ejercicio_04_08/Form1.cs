using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_04_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cb_Asientos.Items.Add("Clasico");
            cb_Asientos.Items.Add("Semi-Cama");
            cb_Asientos.Items.Add("Cama");
        }

        private void cb_Asientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            imagen.Visible = true;
            if (cb_Asientos.SelectedItem.Equals("Clasico"))
            {
                imagen.Image = Properties.Resources.clasico;
            }
            if (cb_Asientos.SelectedItem.Equals("Semi-Cama"))
            {
                imagen.Image = Properties.Resources.semicama;
            }
            if (cb_Asientos.SelectedItem.Equals("Cama"))
            {
                imagen.Image = Properties.Resources.cama;
            }
        }

        private void ck_Clasico_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_Clasico.Checked == true)
            {
                imagen.Visible = true;
                imagen.Image = Properties.Resources.clasico;
                ck_SemiCama.Checked = false;
                ck_Cama.Checked = false;
            }
        }

        private void ck_SemiCama_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_SemiCama.Checked == true)
            {
                imagen.Visible = true;
                imagen.Image = Properties.Resources.semicama;
                ck_Cama.Checked = false;
                ck_Clasico.Checked = false;
            }
        }

        private void ck_Cama_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_Cama.Checked == true)
            {
                imagen.Visible = true;
                imagen.Image = Properties.Resources.cama;
                ck_SemiCama.Checked = false;
                ck_Clasico.Checked = false;
            }
        }

        private void n_Cantidad_ValueChanged(object sender, EventArgs e)
        {
            txt_Total.Text = (5000 * n_Cantidad.Value).ToString();
        }
    }
}
