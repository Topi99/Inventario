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
    public partial class RegUsers : Form
    {
        public RegUsers()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == txtConfirm.Text)
            {
                if (UsuariosDAL.CrearCuentas(txtUser.Text, txtPass.Text) > 0)
                    MessageBox.Show("Cuenta Creada", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo crear la cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
