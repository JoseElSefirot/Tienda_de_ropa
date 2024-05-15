using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_de_ropa
{
    public partial class frmNegocio : Form
    {
        public frmNegocio()
        {
            InitializeComponent();
        }

        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);

            return image;
        }

        private void frmNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteimage = new CN_Negocio().ObtenerLogo(out obtenido);

            if (obtenido)
                PbxLogo.Image = ByteToImage(byteimage);

            Negocio datos = new CN_Negocio().ObtenerDatos();

            TbxNombre.Text = datos.Nombre;
            TbxRcu.Text = datos.RUC;
            TbxDireccion.Text = datos.Direccion;
        }

        private void BtnSubir_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.FileName = "Files|*.jpg;*.jpeg;*.png";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {

                byte[] byteimage = File.ReadAllBytes(oOpenFileDialog.FileName);
                bool respuesta = new CN_Negocio().ActualizarLogo(byteimage, out mensaje);

                if (respuesta)
                    PbxLogo.Image = ByteToImage(byteimage);
                else
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            
                // Expresión regular para validar RFC de persona física en México
            string rfcPattern = @"^[A-Z]{4}[0-9]{6}[A-Z0-9]{3}$";
            Regex regex = new Regex(rfcPattern);

            string rfc = TbxRcu.Text.Trim().ToUpper(); // Obtener RFC ingresado y convertir a mayúsculas
            if (regex.IsMatch(rfc))
            {
                Guardadr();
            }
            else
            {
                MessageBox.Show("RFC no válido", "Validación de RFC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        public void Guardadr()
        {
            string mensaje = string.Empty;

            Negocio obj = new Negocio()
            {
                Nombre = TbxNombre.Text,
                RUC = TbxRcu.Text,
                Direccion = TbxDireccion.Text
            };

            bool respuesta = new CN_Negocio().GuardarDatos(obj, out mensaje);

            if (respuesta)
                MessageBox.Show("Los cambios fueron guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (TbxNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TbxNombre.Focus();
                return;
            }
            if (TbxRcu.Text == "")
            {
                MessageBox.Show("Ingrese el RFC", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TbxRcu.Focus();
                return;
            }
            if (TbxDireccion.Text == "")
            {
                MessageBox.Show("Ingrese una direccion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TbxDireccion.Focus();
                return;
            }
        }

        private void TbxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
