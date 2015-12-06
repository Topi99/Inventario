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

    public partial class Medicamentos : Form
    {

        Medicamento med = new Medicamento();
        int classi;
        bool editar;

        public Medicamentos()
        {
            InitializeComponent();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Form1 main = new Form1();
            main.Show();
        }

        private void nombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblCons.Text = "Nombre";
        }

        private void idToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblCons.Text = "Id";
        }

        private void clasificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblCons.Text = "Clasificación";
        }

        private void Medicamentos_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            int margenDias = fecha.Day - 15;
            //DateTime margenFecha = DateTime.Parse(string.Format("{0}/{1}/{2} {3}:{4}:{5}", margenDias, fecha.Month, fecha.Year, fecha.Hour, fecha.Minute, fecha.Second)); 
            DateTime margenFecha = new DateTime(fecha.Year, fecha.Month-1, fecha.Day);
            editar = false;
            if(Inicio.User!="Admin")
            {
                btnNew.Enabled = false;
                btnDelete.Enabled = false;
                btnEditar.Enabled = false;
            }
            med.ActualizarGrid(this.dataGridView1, "select * from Medicamentos");
            ConexionBD conn = new ConexionBD("Medicamentos");
            conn.Conectar();
            conn.Comparacion(string.Format("select * from Medicamentos where FechCad <= '{0}'", margenFecha));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            btnGuardar.Enabled = false;
            try
            {
                switch (cbClass.Text)
                {
                    case "NEUROLOGÍA":
                        classi = 5;
                        break;
                    case "ANTIMICROBIANOS":
                        classi = 2;
                        break;
                    case "CARDIOVASCULAR":
                        classi = 3;
                        break;
                }
                int idMed = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                if (editar == false)
                {

                    med.EjecutarSQL("insert into Medicamentos values('" + txtNombre.Text + "', " + txtCant.Text + ", " + classi.ToString() + ", " + txtPrecio.Text + ", '" + txtFechCad.Text + "', '" + cbTipo.Text + "')");

                }
                else
                {
                    med.EjecutarSQL("update Medicamentos set Nombre = '" + txtNombre.Text + "', Cant = " + txtCant.Text + ", Class = " + classi.ToString() + ", precio = " + txtPrecio.Text + ", FechCad = '" + txtFechCad.Text + "', tipo = '" + cbTipo.Text + "' where idMed = " + idMed);
                }
                med.ActualizarGrid(this.dataGridView1, "select * from Medicamentos");
                this.LimpiarCajas();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al realizar operación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            med.ActualizarGrid(this.dataGridView1, "select * from Medicamentos");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(lblCons.Text == "Nombre")
            {
                if(txtConsulta.Text == "RegUs")
                {
                    RegUsers reg = new RegUsers();
                    reg.Show();
                }
                else
                {
                    med.ActualizarGrid(this.dataGridView1, "select * from Medicamentos where Nombre like '" + txtConsulta.Text + "'");
                }
            }
            else if(lblCons.Text == "Id")
                med.ActualizarGrid(this.dataGridView1, "select * from Medicamentos where idMed like '" + txtConsulta.Text + "'");
            else if(lblCons.Text == "Clasificación")
                med.ActualizarGrid(this.dataGridView1, "select * from Medicamentos where Class like '" + txtConsulta.Text + "'");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            med.ActualizarGrid(this.dataGridView1, "select * from Medicamentos");
        }

        public void LimpiarCajas() {
            txtNombre.Text = null;
            txtCant.Text = null;
            txtFechCad.Text = null;
            cbClass.Text = null;
            cbTipo.Text = null;
            txtPrecio.Text = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            editar = true;
            btnGuardar.Enabled = true;
            btnGuardar.Cursor = Cursors.Hand;
            btnNew.Enabled = false;
            txtNombre.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            int classif = int.Parse(this.dataGridView1.CurrentRow.Cells[3].Value.ToString());
            string clas=null;
            switch (classif)
            {
                case 5:
                    clas = "NEUROLOGÍA";
                    break;

                case 3:
                    clas = "CARDIOVASCULAR";
                    break;
            }
            cbClass.Text = clas;
            txtFechCad.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtCant.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPrecio.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cbTipo.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int idMed = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            try
            {
                med.EjecutarSQL("delete from Medicamentos where idMed="+idMed.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Error al realizar operación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            med.EjecutarSQL("insert into Medicamentos values('" + txtNombre.Text + "', " + txtCant.Text + ", " + classi.ToString() + ", " + txtPrecio.Text + ", '" + txtFechCad.Text + "', '" + cbTipo.Text + "')");
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            int idMed = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            /*Compra comp = new Compra();
            comp.Show();*/
            int cantAct = int.Parse(this.dataGridView1.CurrentRow.Cells[2].Value.ToString());
            if (cantAct > 0)
            {
                int nuevaCant = cantAct - 1;
                med.EjecutarSQL("update Medicamentos set Cant = " + nuevaCant.ToString() + "where idMed = " + idMed);
                med.ActualizarGrid(this.dataGridView1, "select * from Medicamentos");
            }
        }
    }
}
