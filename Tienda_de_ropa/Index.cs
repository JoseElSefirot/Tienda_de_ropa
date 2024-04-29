using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;
using Tienda_de_ropa.Modales;
using FontAwesome.Sharp;

namespace Tienda_de_ropa
{
    public partial class Index : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Index(Usuario objusuario = null)
        {
            if (objusuario == null)
                usuarioActual = new Usuario() { NombreCompleto = "ADMIN PREDEFINIDO", IdUsuario = 1 };
            else
                usuarioActual = objusuario;

            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);

            foreach (IconMenuItem iconmenu in MenuSeleccion.Items)
            {

                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconmenu.Name);

                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }

            }



            LblUsuario.Text = usuarioActual.NombreCompleto;
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {

            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            PnlContenedor.Controls.Add(formulario);
            formulario.Show();


        }

        private void MenuUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void SubMenuCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuInventario, new frmCategoria());
        }

        private void SubMenuProdcto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuInventario, new frmProducto());
        }

        private void SubMenuNegocio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuInventario, new frmNegocio());
        }

        private void SubMenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new frmVentas(usuarioActual));
        }

        private void SubMenuVerDetalleVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new frmDetalleVenta());
        }

        private void SubMenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuCompras, new frmCompras(usuarioActual));
        }

        private void SubMenuVerDetallesCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuCompras, new frmDetalleCompra());
        }

        private void MenuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());
        }

        private void SubMenuReporteCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuReportes, new frmReporteCompras());
        }

        private void SubMenuReporteVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuReportes, new frmReporteVentas());
        }
    }
}
