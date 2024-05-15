using CapaDatos;
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

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TbxidProducto.Text = modal._Producto.IdProducto.ToString();
                    TbxCodigoProducto.Text = modal._Producto.Codigo;
                    TbxProducto.Text = modal._Producto.Nombre;
                    TbxPrecio.Text = modal._Producto.PrecioVenta.ToString("0.00");
                    TbxStock.Text = modal._Producto.Stock.ToString();
                    TextCantidad.Select();
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
                    TbxidProducto.Text = oProducto.IdProducto.ToString();
                    TbxProducto.Text = oProducto.Nombre;
                    TbxPrecio.Text = oProducto.PrecioVenta.ToString("0.00");
                    TbxStock.Text = oProducto.Stock.ToString();
                    TextCantidad.Select();
                }
                else
                {
                    TbxCodigoProducto.BackColor = Color.MistyRose;
                    TbxidProducto.Text = "0";
                    TbxProducto.Text = "";
                    TbxPrecio.Text = "";
                    TbxStock.Text = "";
                    TextCantidad.Value = 1;
                }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existe = false;

            if (int.Parse(TbxidProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TbxidProducto.Focus();
                return;
            }

            if (!decimal.TryParse(TbxPrecio.Text, out precio))
            {
                MessageBox.Show("Precio - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TbxPrecio.Select();
                return;
            }

            if (Convert.ToInt32(TbxStock.Text) < Convert.ToInt32(TextCantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }




            foreach (DataGridViewRow fila in DvgData.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == TbxidProducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {

                bool respuesta = new CN_Venta().RestarStock(
                    Convert.ToInt32(TbxidProducto.Text),
                    Convert.ToInt32(TextCantidad.Value.ToString())
                    );

                if (respuesta)
                {
                    DvgData.Rows.Add(new object[] {
                        TbxidProducto.Text,
                        TbxProducto.Text,
                        precio.ToString("0.00"),
                        TextCantidad.Value.ToString(),
                        (TextCantidad.Value * precio).ToString("0.00")
                    });

                    calcularTotal();
                    limpiarProducto();
                    TbxCodigoProducto.Select();
                }
            }
        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (DvgData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DvgData.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            TbxTotalaPagar.Text = total.ToString("0.00");
        }

        private void limpiarProducto()
        {
            TbxidProducto.Text = "0";
            TbxCodigoProducto.Text = "";
            TbxProducto.Text = "";
            TbxPrecio.Text = "";
            TbxStock.Text = "";


        }

        private void DvgData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
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
                int index = e.RowIndex;
                if (index >= 0)
                {
                    bool respuesta = new CN_Venta().SumarStock(
                        Convert.ToInt32(DvgData.Rows[index].Cells["IdProducto"].Value.ToString()),
                        Convert.ToInt32(DvgData.Rows[index].Cells["Cantidad"].Value.ToString()));

                    if (respuesta)
                    {
                        DvgData.Rows.RemoveAt(index);
                        calcularTotal();
                    }

                }
            }
        }

        private void TbxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TbxPrecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void TbxPagaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TbxPagaCon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void calcularcambio()
        {

            if (TbxTotalaPagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            decimal pagacon;
            decimal total = Convert.ToDecimal(TbxTotalaPagar.Text);

            if (TbxPagaCon.Text.Trim() == "")
            {
                TbxPagaCon.Text = "0";
            }

            if (decimal.TryParse(TbxPagaCon.Text.Trim(), out pagacon))
            {

                if (pagacon < total)
                {
                    MessageBox.Show("El pago no puede ser menor al total", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    decimal cambio = pagacon - total;
                    TbxCambio.Text = cambio.ToString("0.00");

                }
            }

        }

        private void TbxPagaCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularcambio();
            }
        }

        private void BtnCrearVenta_Click(object sender, EventArgs e)
        {
            

            if (DvgData.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (TbxPagaCon.Text == "")
            {
                MessageBox.Show("Ingrese el monto de pago", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TbxPagaCon.Focus();
                return;
            }

            /*decimal pagaco = Convert.ToDecimal(TbxPagaCon.Text.Trim());
            decimal total = Convert.ToDecimal(TbxTotalaPagar.Text);*/
            if (Convert.ToDecimal(TbxPagaCon.Text.Trim()) < Convert.ToDecimal(TbxTotalaPagar.Text))
            {
                MessageBox.Show("El pago no puede ser menor al total a pagar ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TbxPagaCon.Focus();
                return;
            }

            DataTable detalle_venta = new DataTable();

            detalle_venta.Columns.Add("IdProducto", typeof(int));
            detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_venta.Columns.Add("Cantidad", typeof(int));
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));


            foreach (DataGridViewRow row in DvgData.Rows)
            {
                detalle_venta.Rows.Add(new object[] {
                    row.Cells["IdProducto"].Value.ToString(),
                    row.Cells["Precio"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString()
                });
            }


            int idcorrelativo = new CN_Venta().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idcorrelativo);
            calcularcambio();

            Venta oVenta = new Venta()
            {

                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                TipoDocumento = ((ObcionComboBox)CbxTipoDocumento.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                MontoPago = Convert.ToDecimal(TbxPagaCon.Text),
                MontoCambio = Convert.ToDecimal(TbxCambio.Text),
                MontoTotal = Convert.ToDecimal(TbxTotalaPagar.Text)
            };


            string mensaje = string.Empty;
            bool respuesta = new CN_Venta().Registrar(oVenta, detalle_venta, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de venta generada:\n" + numeroDocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numeroDocumento);

                DvgData.Rows.Clear();
                calcularTotal();
                TbxPagaCon.Text = "";
                TbxCambio.Text = "";
            }
            else
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
