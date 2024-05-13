using CapaEntidad;
using CapaNegocio;
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
    public partial class frmCompras : Form
    {
        private Usuario _Usuario;
        public frmCompras(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            CbxTipoDocumento.Items.Add(new ObcionComboBox() { Valor = "Boleta", Texto = "Boleta" });
            CbxTipoDocumento.Items.Add(new ObcionComboBox() { Valor = "Factura", Texto = "Factura" });
            CbxTipoDocumento.DisplayMember = "Texto";
            CbxTipoDocumento.ValueMember = "Valor";
            CbxTipoDocumento.SelectedIndex = 0;

            TbxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            TxtIdProveedor2.Text = "0";
            TbxIdProducto.Text = "0";
        }

        private void BtnBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtIdProveedor2.Text = modal._Proveedor.IdProveedor.ToString();
                    TbxIdProveedor.Text = modal._Proveedor.Documento;
                    TbxNombreProveedor.Text = modal._Proveedor.RazonSocial;
                }
                else
                {
                    TbxIdProveedor.Select();
                }

            }
        }

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TbxIdProducto.Text = modal._Producto.IdProducto.ToString();
                    TbxCodigoProducto.Text = modal._Producto.Codigo;
                    TbxProducto.Text = modal._Producto.Nombre;
                    TbxPrecioCompra.Select();
                }
                else
                {
                    TbxCodigoProducto.Select();
                }

            }
        }

        private void TbxCodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == TbxCodigoProducto.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    TbxCodigoProducto.BackColor = Color.Honeydew;
                    TbxIdProducto.Text = oProducto.IdProducto.ToString();
                    TbxProducto.Text = oProducto.Nombre;
                    TbxPrecioCompra.Select();
                }
                else
                {
                    TbxCodigoProducto.BackColor = Color.MistyRose;
                    TbxIdProducto.Text = "0";
                    TbxProducto.Text = "";
                }


            }
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            decimal preciocompra = 0;
            decimal precioventa = 0;
            bool producto_existe = false;

            if (int.Parse(TbxIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(TbxPrecioCompra.Text, out preciocompra))
            {
                MessageBox.Show("Precio Compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TbxPrecioCompra.Select();
                return;
            }

            if (!decimal.TryParse(TbxPrecioVenta.Text, out precioventa))
            {
                MessageBox.Show("Precio Venta - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TbxPrecioVenta.Select();
                return;
            }

            foreach (DataGridViewRow fila in DvgData.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == TbxIdProducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {

                DvgData.Rows.Add(new object[] {
                    TbxIdProducto.Text,
                    TbxProducto.Text,
                    preciocompra.ToString("0.00"),
                    precioventa.ToString("0.00"),
                    TxtCantidad.Value.ToString(),
                    (TxtCantidad.Value * preciocompra).ToString("0.00")

                });

                calcularTotal();
                limpiarProducto();
                TbxProducto.Select();


            }
        }

        private void limpiarProducto()
        {
            TbxIdProducto.Text = "0";
            TbxCodigoProducto.Text = "";
            TbxCodigoProducto.BackColor = Color.White;
            TbxProducto.Text = "";
            TbxPrecioCompra.Text = "";
            TbxPrecioVenta.Text = "";
            TxtCantidad.Value = 1;
        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (DvgData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DvgData.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            TbxTotalAPagar.Text = total.ToString("0.00");
        }

        private void DvgData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 6)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.delete25.Width;
                var h = Properties.Resources.delete25.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete25, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void DvgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DvgData.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    DvgData.Rows.RemoveAt(indice);
                    calcularTotal();
                }
            }
        }

        private void TbxPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TbxPrecioCompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void TbxPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TbxPrecioVenta.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (TbxIdProveedor.Text == "")
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (DvgData.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            DataTable detalle_compra = new DataTable();

            detalle_compra.Columns.Add("IdProducto", typeof(int));
            detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
            detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_compra.Columns.Add("Cantidad", typeof(int));
            detalle_compra.Columns.Add("MontoTotal", typeof(decimal));

            foreach (DataGridViewRow row in DvgData.Rows)
            {
                detalle_compra.Rows.Add(
                    new object[] {
                       Convert.ToInt32(row.Cells["IdProducto"].Value.ToString()),
                       row.Cells["PrecioCompra"].Value.ToString(),
                       row.Cells["PrecioVenta"].Value.ToString(),
                       row.Cells["Cantidad"].Value.ToString(),
                       row.Cells["SubTotal"].Value.ToString()
                    });

            }

            int idcorrelativo = new CN_Compra().ObtenerCorrelativo();
            string numerodocumento = string.Format("{0:00000}", idcorrelativo);

            Compra oCompra = new Compra()
            {
                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(TbxIdProveedor.Text) },
                TipoDocumento = ((ObcionComboBox)CbxTipoDocumento.SelectedItem).Texto,
                NumeroDocumento = numerodocumento,
                MontoTotal = Convert.ToDecimal(TbxTotalAPagar.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Compra().Registrar(oCompra, detalle_compra, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de compra generada:\n" + numerodocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numerodocumento);

                TxtIdProveedor2.Text = "0";
                TbxIdProveedor.Text = "";
                TbxNombreProveedor.Text = "";
                DvgData.Rows.Clear();
                calcularTotal();

            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
