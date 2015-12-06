using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventario
{
    public partial class prueba : Form
    {
        public prueba()
        {
            InitializeComponent();
        }

        private void prueba_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            CN = new SqlConnection(cadenaconexion);
            CMD = new SqlCommand("SELECT * FROM Prueba", CN);
            CMD.CommandType = CommandType.Text;

            try
            {
                CN.Open();
                RDR = CMD.ExecuteReader();
                while (RDR.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = (string)RDR["id"].ToString();
                    lvi.SubItems.Add((string)RDR["nombre"]);
                    listView1.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CN.Close();
            }
        }
        private string cadenaconexion = Properties.Settings.Default.conexion;
        private SqlConnection CN;
        private SqlCommand CMD;
        private SqlDataReader RDR;
    
    }
}
