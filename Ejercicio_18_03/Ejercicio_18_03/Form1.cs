using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_18_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Agregar objetos de manera programatica al combobox
            cbx_Carrera.Items.Add("Informatica");
            cbx_Carrera.Items.Add("Telecomunicaciones");
            cbx_Carrera.Items.Add("Administracion");
            //Extra: Seleccionar el primer index del combobox al iniciar el programa
            cbx_Carrera.SelectedIndex = 0;
            /*
             * Extra: Deshabilitar cajas de texto de arancel,descuento y total
             * ya que no es necesario modificar su valor
             */
            txt_Arancel.Enabled = false;
            txt_Descuento.Enabled = false;
            txt_Total.Enabled = false;
        }

        private void cbx_Carrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Carrera.SelectedItem.Equals("Administracion"))
            {
                txt_Arancel.Text = "1500000";
            }else if (cbx_Carrera.SelectedItem.Equals("Telecomunicaciones"))
            {
                txt_Arancel.Text = "1750000";
            }
            else if (cbx_Carrera.SelectedItem.Equals("Informatica"))
            {
                txt_Arancel.Text = "1550000";
            }

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            //Extra: agregado un try-catch para validar los datos y evitar que el programa crashee
            try
            {
                /* Promedios menores a 5.5 no tienen descuento y mostrar mensaje
                 * Promedio entre 5.5 y 6 tiene un 8% de descuento
                 * Promedio entre 6.1 y 6.6 tiene un 12% de descuento
                 * Promedio Mayores a 6.7 tiene un 20% de descuento
                 */
                if (Convert.ToDouble(txt_Promedio.Text) < 5.5)
                {
                    txt_Descuento.Text = "0";
                    txt_Total.Text = (Convert.ToDouble(txt_Arancel.Text) - Convert.ToDouble(txt_Descuento.Text)).ToString();
                }
                else if (Convert.ToDouble(txt_Promedio.Text) >= 5.5 && Convert.ToDouble(txt_Promedio.Text) <= 6.0)
                {
                    txt_Descuento.Text = (Convert.ToDouble(txt_Arancel.Text) * 0.08d).ToString();
                    txt_Total.Text = (Convert.ToDouble(txt_Arancel.Text) - Convert.ToDouble(txt_Descuento.Text)).ToString();
                }
                else if (Convert.ToDouble(txt_Promedio.Text) >= 6.1 && Convert.ToDouble(txt_Promedio.Text) <= 6.6)
                {
                    txt_Descuento.Text = (Convert.ToDouble(txt_Arancel.Text) * 0.12d).ToString();
                    txt_Total.Text = (Convert.ToDouble(txt_Arancel.Text) - Convert.ToDouble(txt_Descuento.Text)).ToString();
                }
                else if (Convert.ToDouble(txt_Promedio.Text) >= 6.7)
                {
                    txt_Descuento.Text = (Convert.ToDouble(txt_Arancel.Text) * 0.2d).ToString();
                    txt_Total.Text = (Convert.ToDouble(txt_Arancel.Text) - Convert.ToDouble(txt_Descuento.Text)).ToString();
                    
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Error al ejecutar el programa.\nPorfavor revise los datos ingresados");
               
            }
        }
        // Extra: Validar textbox solo numeros
        private void txt_Promedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)|| Char.IsPunctuation(e.KeyChar)||Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    btn_Calcular.Focus();
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
    }
}
