using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ejercicio_04_20_BD
{
    public partial class Form2 : Form
    {
        private String servidor;
        private String basedatos;
        private SqlDataReader dread;

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

        private void BuscarModificar_btn_Click(object sender, EventArgs e)
        {
            Conexion Cadato = new Conexion();
            Cadato.Conectar(servidor, basedatos);
            dread = Cadato.buscarParaModificar(rut_txt.Text);
            if (dread.Read())
            {
                nombre_txt.Text = dread["nombre"].ToString();
                edad_txt.Text = dread["edad"].ToString();
            }
            dread.Close();
        }

        private void Modificar_btn_Click(object sender, EventArgs e)
        {
            Conexion Cadato = new Conexion();
            Cadato.Conectar(servidor, basedatos);
            Cadato.modificar(rut_txt.Text, nombre_txt.Text, Convert.ToInt32(edad_txt.Text));
            dataGridView1.DataSource = Cadato.llenar_grid("alumnos");

        }

        private void Eliminar_btn_Click(object sender, EventArgs e)
        {
            Conexion Cadato = new Conexion();
            Cadato.Conectar(servidor, basedatos);
            Cadato.eliminar(rut_txt.Text);
            MessageBox.Show("Dato eliminado");
            dataGridView1.DataSource = Cadato.llenar_grid("alumnos");
        }
    }
}