using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Inventario.Properties;
using System.Configuration;

namespace Inventario
{
    class ConexionBD
    {
        string nomTable;

        /*public static SqlConnection obtenetConexion()
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.Conectar);
            conn.Open();
            return conn;
        }*/

        public static string ObtenerString()
        {
            return Settings.Default.InventarioConnectionString;
        }

        public ConexionBD(string nombTable)
        {
            nomTable = nombTable;
        }

        SqlConnection Conexion;

        public void Conectar()
        {
            Conexion = new SqlConnection(ObtenerString());
            Conexion.Open();
        }

        public void Desconectar()
        {
            Conexion.Close();
        }

        public void EjecutarSQL(String Query)
        {
            try
            {
                Conectar();
                SqlCommand Comando = new SqlCommand(Query, this.Conexion);

                //se ejecuta la query 
                int FilasAfectadas = Comando.ExecuteNonQuery();

                if (FilasAfectadas > 0)
                {
                    MessageBox.Show("Operación realizada exitosamente", "La base de datos a sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                    MessageBox.Show("No se pudo realizar la operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo realizar la operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Desconectar();
        }

        public void Comparacion(string Comando)
        {
            SqlCommand comm = new SqlCommand(Comando, Conexion);
            SqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                MessageBox.Show("Uno o varios medicamentos están por caducarse", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ActualizarGrid(DataGridView dg, String Query)
        {
            //crea DataSet
            System.Data.DataSet DataSet = new System.Data.DataSet();

            //conexion a BD
            this.Conectar();

            //crea adaptador de datos 
            SqlDataAdapter DataAdapter = new SqlDataAdapter(Query, Conexion);


            //llena el dataSet
            DataAdapter.Fill(DataSet, nomTable);

            //asigna valores adecuados a las propiedades del DataGrid
            dg.DataSource = DataSet;
            dg.DataMember = nomTable;

            //desconectamos
            this.Desconectar();
        }
    }
}
