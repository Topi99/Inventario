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
    public partial class Productos : Form
    {
        bool editar = false;
        ConexionBD conn = new ConexionBD("ProdVarios");
        
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            conn.ActualizarGrid(dataGridView1, "select * from ProdVarios");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.EjecutarSQL(string.Format("insert into ProdVarios values('{0}', {1}, {2}, '{3}')", txtNombre.Text, txtCant.Text, txtPrecio.Text, txtFechCad.Text));
            conn.ActualizarGrid(dataGridView1, "select * from ProdVarios");
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 main = new Form1();
            main.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar = true;
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            txtNombre.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtCant.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPrecio.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtFechCad.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnNew.Enabled = true;
            string id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            conn.EjecutarSQL(string.Format("update ProdVarios set Name='{0}', Cantidad={1}, Precio={2}, fechCad='{3}' where idProd = {4}", txtNombre.Text, txtCant.Text, txtPrecio.Text, txtFechCad.Text, id));
            conn.ActualizarGrid(dataGridView1, "select * from ProdVarios");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.ActualizarGrid(this.dataGridView1, string.Format("select * from ProdVarios where Name='{0}'", txtConsulta.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.ActualizarGrid(this.dataGridView1, "select * from ProdVarios");
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.ActualizarGrid(this.dataGridView1, "select * from ProdVarios");
        }
    }
}
