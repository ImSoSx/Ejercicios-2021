using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_06_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbx_Origen.Items.Add("Temuco");
            cbx_Origen.Items.Add("Concepcion");
            cbx_Origen.Items.Add("Talcahuano");
            cbx_Asiento.Items.Add("Clasico");
            cbx_Asiento.Items.Add("Semi-Cama");
            cbx_Asiento.Items.Add("Cama");
            txt_Total.Enabled = false;
            txt_ValorAsiento.Enabled = false;
            txt_ValorDestino.Enabled = false;
            pictureBox2.Image = Properties.Resources.logo;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cbx_Origen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbx_Origen.SelectedItem.Equals("Temuco")){
                cbx_Destino.Items.Clear();
                cbx_Destino.Text = "";
                txt_ValorDestino.Text = "";
                cbx_Asiento.Text = "";
                txt_Total.Text = "";
                cbx_Destino.Items.Add("Valdivia");
            }
            else if (cbx_Origen.SelectedItem.Equals("Concepcion"))
            {
                cbx_Destino.Items.Clear();
                cbx_Destino.Text = "";
                txt_ValorDestino.Text = "";
                cbx_Asiento.Text = "";
                txt_Total.Text = "";
                cbx_Destino.Items.Add("Santiago");
            }
            else if (cbx_Origen.SelectedItem.Equals("Talcahuano"))
            {
                cbx_Destino.Items.Clear();
                cbx_Destino.Text = "";
                txt_ValorDestino.Text = "";
                cbx_Asiento.Text = "";
                txt_Total.Text = "";
                cbx_Destino.Items.Add("Pto. Montt");
            }

            
            
        }

        private void cbx_Destino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Origen.SelectedItem.Equals("Temuco") && cbx_Destino.SelectedItem.Equals("Valdivia"))
            {
                txt_Total.Text = "";
                txt_ValorDestino.Text = "12000";
            }else if (cbx_Origen.SelectedItem.Equals("Concepcion") && cbx_Destino.SelectedItem.Equals("Santiago"))
            {
                txt_Total.Text = "";
                txt_ValorDestino.Text = "8600";
            }else if (cbx_Origen.SelectedItem.Equals("Talcahuano") && cbx_Destino.SelectedItem.Equals("Pto. Montt"))
            {
                txt_Total.Text = "";
                txt_ValorDestino.Text = "25000";
            }
        }

        private void cbx_Asiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Asiento.SelectedItem.Equals("Clasico"))
            {
                txt_ValorAsiento.Text = "4000";
                pic_Asiento.Image = Properties.Resources.clasico;
                try
                {
                txt_Total.Text = (Int32.Parse(txt_ValorDestino.Text) + Int32.Parse(txt_ValorAsiento.Text)).ToString();
                }
                catch (Exception ex)
                {

                }
            }
            else if (cbx_Asiento.SelectedItem.Equals("Semi-Cama"))
            {
                txt_ValorAsiento.Text = "6000";
                pic_Asiento.Image = Properties.Resources.semicama;
                try
                {
                    txt_Total.Text = (Int32.Parse(txt_ValorDestino.Text) + Int32.Parse(txt_ValorAsiento.Text)).ToString();
                }
                catch (Exception ex)
                {

                }

            } 
            else if (cbx_Asiento.SelectedItem.Equals("Cama"))
            {
                
                txt_ValorAsiento.Text = "10000";
                pic_Asiento.Image = Properties.Resources.cama;

                try
                {
                    txt_Total.Text = (Int32.Parse(txt_ValorDestino.Text) + Int32.Parse(txt_ValorAsiento.Text)).ToString();
                }
                catch (Exception ex)
                {

                }

            }
        }
    }
}
