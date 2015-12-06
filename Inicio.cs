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

        public static string User;
        public static bool Iniciado = false;

        public void iniciar()
        {
            User = this.txtUser.Text;
            if (UsuariosDAL.Autentificar(txtUser.Text, txtPass.Text) > 0)
            {
                Iniciado = true;
                Form1 main = new Form1();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error al iniciar seción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Text = null;
                txtPass.Text = null;
                txtUser.Focus();
            }
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            iniciar();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
