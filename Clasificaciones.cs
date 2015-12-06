using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Clasificaciones : Form
    {
        public Clasificaciones()
        {
            InitializeComponent();
        }

        ConexionBD conn = new ConexionBD("Clasificaciones");

        private void Clasificaciones_Load(object sender, EventArgs e)
        {
            conn.ActualizarGrid(this.dataGridView1, "select * from Clasificaciones");
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.ActualizarGrid(this.dataGridView1, "select * from Clasificaciones");
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Close();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            conn.ActualizarGrid(this.dataGridView1, "select * from Clasificaciones");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            conn.EjecutarSQL(string.Format("insert into Clasificaciones values('{0}', '{1}')", txtName.Text, txtDesc.Text));
            conn.ActualizarGrid(this.dataGridView1, "select * from Clasificaciones");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int idClas = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            conn.EjecutarSQL(string.Format("delete from Clasificaciones where idCat={0}", idClas));
            conn.ActualizarGrid(this.dataGridView1, "select * from Clasificaciones");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtConsulta.Text = txtConsulta.Text.ToUpper();
            conn.ActualizarGrid(this.dataGridView1, string.Format("select * from Clasificaciones where Nombre like '{0}'", txtConsulta.Text));

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnGuardar.Cursor = Cursors.Hand;
            txtName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDesc.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idCat = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            conn.EjecutarSQL(string.Format("update Clasificaciones set Nombre='{0}', Descr='{1}' where idCat={2}", txtName.Text, txtDesc.Text, idCat));
            conn.ActualizarGrid(this.dataGridView1, string.Format("select * from Clasificaciones"));
            btnNew.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnGuardar.Cursor = Cursors.Default;
        }
    }
}
