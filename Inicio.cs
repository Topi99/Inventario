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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if(UsuariosDAL.Autentificar(txtUser.Text, txtPass.Text) > 0)
            {
                Form1 main = new Form1();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error al iniciar seción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
