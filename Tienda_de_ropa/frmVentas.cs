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
using Tienda_de_ropa.Modales;
using Tienda_de_ropa.Utilidades;

namespace Tienda_de_ropa
{
    public partial class frmVentas : Form
    {
        private Usuario _Usuario;
        public frmVentas(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            CbxTipoDocumento.Items.Add(new ObcionComboBox() { Valor = "Boleta", Texto = "Boleta" });
            CbxTipoDocumento.Items.Add(new ObcionComboBox() { Valor = "Factura", Texto = "Factura" });
            CbxTipoDocumento.DisplayMember = "Texto";
            CbxTipoDocumento.ValueMember = "Valor";
            CbxTipoDocumento.SelectedIndex = 0;

            TbxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            TbxidProducto.Text = "0";

            TbxPagaCon.Text = "";
            TbxCambio.Text = "";
            TbxTotalaPagar.Text = "0";
        }
    }
}
