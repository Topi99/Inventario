using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Inventario
{
    public partial class email : Form
    {
        public email()
        {
            InitializeComponent();
        }
        private void email_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Correos Cr = new Correos();
                MailMessage mnsj = new MailMessage();

                mnsj.Subject = "Hola Mundo";

                mnsj.To.Add(new MailAddress("nokoayzack@gmail.com"));

                mnsj.From = new MailAddress("YO@MiDominio.com", "Nombre Apellido");

                /* Si deseamos Adjuntar algún archivo*/
                //mnsj.Attachments.Add(new Attachment("C:\\archivo.pdf"));

                mnsj.Body = "  Mensaje de Prueba \n\n Enviado desde C#\n\n *VER EL ARCHIVO ADJUNTO*";

                /* Enviar */
                Cr.MandarCorreo(mnsj);
                //Enviado = true;

                MessageBox.Show("El Mail se ha Enviado Correctamente", "Listo!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
