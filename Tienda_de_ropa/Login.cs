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
using Microsoft.IdentityModel.Tokens;
using Tienda_de_ropa.Utilidades;
using iTextSharp.xmp.impl;
using static Tienda_de_ropa.Utilidades.ValidacionDeCampos;


namespace Tienda_de_ropa
{
    public partial class Login : Form
    {
        private ValidacionDeCampos validador = new ValidacionDeCampos();

        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == TbxIdUsuario.Text && u.Clave == Encriptar(TbxContrasena.Text)).FirstOrDefault();
            
            if (ousuario != null)
            {
                if (ousuario.Estado)
                {
                    Index form = new Index(ousuario);
                    form.Show();
                    this.Hide();
                    form.FormClosing += frm_closing;
                }
                else
                {
                    MessageBox.Show("Tu cuenta está inactiva. Por favor, contacta al administrador.", "Cuenta inactiva", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No se encontró el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public string Encriptar(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
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

        private void TbxIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

            
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbxContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }
    }
}
