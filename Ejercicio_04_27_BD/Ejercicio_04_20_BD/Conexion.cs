using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Ejercicio_04_20_BD
{
    class Conexion
    {
        private SqlCommand comando;
        private SqlConnection conx;
        private SqlDataReader dread;

        public void Conectar(String Serv, String Bd)
        {
            try
            {
                conx = new SqlConnection(@"Data Source ="+ Serv +"; Initial Catalog=" +Bd+ "; Integrated Security=True");
                conx.Open();
            }
            catch(System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("Error al realizar la conexion");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error al realizar la conexion");
            }
        }

        public DataTable llenar_grid(String Tabla)
        {
            DataTable dt = new DataTable();
            try
            {

                comando = new SqlCommand();
                comando.Connection = this.conx;
                comando.CommandText = "SELECT * FROM " + Tabla;
                dread = comando.ExecuteReader();
                dt.Load(dread);
               
            }
            catch(System.InvalidOperationException e)
            {
                MessageBox.Show("Error al realizar la conexion");
            }
            return dt;
        }
        public void agregar(String rut, String nombre,int edad)
        {
            comando = new SqlCommand();
            comando.Connection = this.conx;
            comando.CommandText="INSERT INTO alumnos (rut,nombre,edad) VALUES ('"+rut+"','"+nombre+"','"+edad+"')";
            comando.ExecuteNonQuery();
        }
        public DataTable BuscarParaMostrar(String Rut)
        {
            DataTable dt = new DataTable();
            try
            {

                comando = new SqlCommand();
                comando.Connection = this.conx;
                comando.CommandText = "SELECT * FROM alumnos WHERE rut='"+Rut+"'";
                dread = comando.ExecuteReader();
                dt.Load(dread);

            }
            catch (System.InvalidOperationException e)
            {
                MessageBox.Show("Error al realizar la conexion");
            }
            return dt;
        }
    }
}
