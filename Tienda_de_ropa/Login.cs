using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace Tienda_de_ropa
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == TbxIdUsuario.Text && u.Clave == TbxContrasena.Text).FirstOrDefault();
            if (ousuario != null)
            {

                Index form = new Index(ousuario);

                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;

            }
            else
            {
                MessageBox.Show("no se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {

            TbxIdUsuario.Text = "";
            TbxContrasena.Text = "";
            this.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
