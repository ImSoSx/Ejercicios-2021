using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_04_20_BD
{
    public partial class Form2 : Form
    {
        String servidor;
        String basedatos;
        public Form2(String servidor, String basedatos)
        {
            InitializeComponent();
            this.servidor = servidor;
            this.basedatos = basedatos;
        }

        private void Guardar_btn_Click(object sender, EventArgs e)
        {
            Conexion GuardarDato = new Conexion();
            GuardarDato.Conectar(servidor, basedatos);
            GuardarDato.agregar(rut_txt.Text, nombre_txt.Text, Int32.Parse(edad_txt.Text));
            MessageBox.Show("Alumno guardado");
            rut_txt.Text = "";
            nombre_txt.Text = "";
            edad_txt.Text = "";
            rut_txt.Focus();
        }

        private void Buscar_btn_Click(object sender, EventArgs e)
        {
            Conexion Cadato = new Conexion();
            Cadato.Conectar(servidor, basedatos);
            dataGridView1.Visible = true;
            dataGridView1.DataSource = Cadato.BuscarParaMostrar(rut_txt.Text);
        }
    }
}
