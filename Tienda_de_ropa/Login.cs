﻿using CapaEntidad;
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

            string nombreUsuario = TbxIdUsuario.Text;
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("El nombre de usuario solo puede contener letras y números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (TbxIdUsuario.Text.Length >= 30 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("El nombre de usuario no puede tener más de 30 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TbxContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int MAX_LONGITUD_CONTRASEÑA = 64;

            string contraseña = TbxContrasena.Text + e.KeyChar; // Agregar el carácter presionado al texto actual de la contraseña

            if (contraseña.Length > MAX_LONGITUD_CONTRASEÑA && !char.IsControl(e.KeyChar)) // Verificar si se excede la longitud máxima y si no es un carácter de control
            {
                e.Handled = true; // Bloquear el carácter presionado
                MessageBox.Show($"La contraseña no puede tener más de {MAX_LONGITUD_CONTRASEÑA} caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
