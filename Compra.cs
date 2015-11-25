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
    public partial class Compra : Form
    {
        public int Comprado { get; protected set; }
        public bool CompraRealizada { get; protected set; }
        public Compra()
        {
            InitializeComponent();
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            label1.Text = "¿Cuántos desea comprar?";
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            Comprado = int.Parse(txtCompra.Text);
            CompraRealizada = true;

            Medicamentos medi = new Medicamentos();
            Medicamento med = new Medicamento();
            int idMed = int.Parse(medi.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int cantAct = int.Parse(medi.dataGridView1.CurrentRow.Cells[2].Value.ToString());
            if (CompraRealizada == true)
            {
                if (Comprado < cantAct)
                {
                    cantAct = cantAct - Comprado;
                    med.EjecutarSQL("update Medicamentos set Cant = " + cantAct.ToString() + "where idMed = " + idMed);
                    MessageBox.Show("Compra realizada con éxito", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    med.EjecutarSQL("select * from Medicamentos");
                    Close();
                }
                else
                    MessageBox.Show("La compra no puede ser mayor a la cantidad de medicamento actual", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Algo ocurrió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
