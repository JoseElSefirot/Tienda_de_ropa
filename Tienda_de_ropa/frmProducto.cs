using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda_de_ropa.Utilidades;

namespace Tienda_de_ropa
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            CbxEstado.Items.Add(new ObcionComboBox() { Valor = 1, Texto = "Activo" });
            CbxEstado.Items.Add(new ObcionComboBox() { Valor = 0, Texto = "No Activo" });
            CbxEstado.DisplayMember = "Texto";
            CbxEstado.ValueMember = "Valor";
            CbxEstado.SelectedIndex = 0;
            

            List<Categoria> listacategoria = new CN_Categoria().Listar();

            foreach (Categoria item in listacategoria)
            {
                CbxCategoria.Items.Add(new ObcionComboBox() { Valor = item.IdCategoria, Texto = item.Descripcion });
            }
            CbxCategoria.DisplayMember = "Texto";
            CbxCategoria.ValueMember = "Valor";
            CbxCategoria.SelectedIndex = 0;


            foreach (DataGridViewColumn columna in DvgData.Columns)
            {

                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    CbxBusqueda.Items.Add(new ObcionComboBox() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            CbxBusqueda.DisplayMember = "Texto";
            CbxBusqueda.ValueMember = "Valor";
            CbxBusqueda.SelectedIndex = 0;



            //MOSTRAR TODOS LOS USUARIOS
            List<Producto> lista = new CN_Producto().Listar();

            foreach (Producto item in lista)
            {

                DvgData.Rows.Add(new object[] {
                    "",
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.Descripcion,
                    item.oCategoria.IdCategoria,
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta,
                    item.Estado == true ? 1 : 0 ,
                    item.Estado == true ? "Activo" : "No Activo"
                });
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;


            if (TbxNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre para el producto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TbxNombre.Focus();
                return;
            }

            if (TbxDescripcion.Text == "")
            {
                MessageBox.Show("Ingrese una descripcion para el producto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TbxDescripcion.Focus();
                return;
            }

            Producto obj = new Producto()
            {
                IdProducto = Convert.ToInt32(TbxId.Text),
                Codigo = TbxCodigo.Text,
                Nombre = TbxNombre.Text,
                Descripcion = TbxDescripcion.Text,
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((ObcionComboBox)CbxCategoria.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((ObcionComboBox)CbxCategoria.SelectedItem).Valor) == 1 ? true : false
            };

            if (obj.IdProducto == 0)
            {
                int idgenerado = new CN_Producto().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {

                    DvgData.Rows.Add(new object[] {
                        "",
                       idgenerado,
                       TbxCodigo.Text,
                        TbxNombre.Text,
                        TbxDescripcion.Text,
                        ((ObcionComboBox)CbxCategoria.SelectedItem).Valor.ToString(),
                       ((ObcionComboBox)CbxCategoria.SelectedItem).Texto.ToString(),
                       "0",
                       "0.00",
                       "0.00",
                       ((ObcionComboBox)CbxEstado.SelectedItem).Valor.ToString(),
                       ((ObcionComboBox)CbxEstado.SelectedItem).Texto.ToString()
                    });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }


            }
            else
            {
                bool resultado = new CN_Producto().Editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = DvgData.Rows[Convert.ToInt32(TbxIndice.Text)];
                    row.Cells["Id"].Value = TbxId.Text;
                    row.Cells["Codigo"].Value = TbxCodigo.Text;
                    row.Cells["Nombre"].Value = TbxNombre.Text;
                    row.Cells["Descripcion"].Value = TbxDescripcion.Text;
                    row.Cells["IdCategoria"].Value = ((ObcionComboBox)CbxCategoria.SelectedItem).Valor.ToString();
                    row.Cells["Categoria"].Value = ((ObcionComboBox)CbxCategoria.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((ObcionComboBox)CbxEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((ObcionComboBox)CbxEstado.SelectedItem).Texto.ToString();

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }

        private void Limpiar()
        {

            TbxIndice.Text = "-1";
            TbxId.Text = "0";
            TbxCodigo.Text = "";
            TbxNombre.Text = "";
            TbxDescripcion.Text = "";
            CbxCategoria.SelectedIndex = 0;
            CbxEstado.SelectedIndex = 0;

            TbxCodigo.Select();

        }

        private void DvgData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void DvgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DvgData.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {

                    TbxIndice.Text = indice.ToString();
                    TbxId.Text = DvgData.Rows[indice].Cells["Id"].Value.ToString();

                    TbxCodigo.Text = DvgData.Rows[indice].Cells["Codigo"].Value.ToString();
                    TbxNombre.Text = DvgData.Rows[indice].Cells["Nombre"].Value.ToString();
                    TbxDescripcion.Text = DvgData.Rows[indice].Cells["Descripcion"].Value.ToString();


                    foreach (ObcionComboBox oc in CbxCategoria.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DvgData.Rows[indice].Cells["IdCategoria"].Value))
                        {
                            int indice_combo = CbxCategoria.Items.IndexOf(oc);
                            CbxCategoria.SelectedIndex = indice_combo;
                            break;
                        }
                    }


                    foreach (ObcionComboBox oc in CbxEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DvgData.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = CbxEstado.Items.IndexOf(oc);
                            CbxEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnBusacar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((ObcionComboBox)CbxBusqueda.SelectedItem).Valor.ToString();

            if (DvgData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DvgData.Rows)
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(TbxBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void BtnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            TbxBusqueda.Text = "";
            foreach (DataGridViewRow row in DvgData.Rows)
            {
                row.Visible = true;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            /*if (Convert.ToInt32(TbxId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el producto", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Producto obj = new Producto()
                    {
                        IdProducto = Convert.ToInt32(TbxId.Text)
                    };

                    bool respuesta = new CN_Producto().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        DvgData.Rows.RemoveAt(Convert.ToInt32(TbxIndice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }*/



            if (Convert.ToInt32(TbxId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea cambiar el estado del producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Producto obj = new Producto()
                    {
                        IdProducto = Convert.ToInt32(TbxId.Text)
                    };

                    bool respuesta = new CN_Producto().CambiarEstado(obj, out mensaje);

                    if (respuesta)
                    {
                        DataGridViewRow row = DvgData.Rows[Convert.ToInt32(TbxIndice.Text)];
                        row.Cells["EstadoValor"].Value = 0; // Cambia el valor del estado a inactivo
                        row.Cells["Estado"].Value = "No Activo"; // Actualiza la visualización del estado
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void BtnExportarTabla_Click(object sender, EventArgs e)
        {
            if (DvgData.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in DvgData.Columns)
                {
                    if (columna.HeaderText != "" && columna.Visible)
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in DvgData.Rows)
                {
                    if (row.Visible)
                        dt.Rows.Add(new object[] {
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[11].Value.ToString(),

                        });
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteProducto_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }

            }
        }

        private void TbxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // código de barras EAN-13 (Son solo numeros)
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
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
