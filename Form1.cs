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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medicamentos med = new Medicamentos();
            med.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {   
            //MessageBox.Show("¿Seguro que desea salir?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            Application.Exit();
        }

        private void contactarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            email em = new email();
            em.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productos prod = new Productos();
            prod.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clasificaciones clas = new Clasificaciones();
            clas.Show();
            this.Close();
        }

        private void cerrarSeciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            MessageBox.Show("Seción cerrada", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            inicio.Show();
            this.Close();
            Inicio.Iniciado = false;
        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicamentos med = new Medicamentos();
            med.Show();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
