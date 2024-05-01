using CapaNegocio;
using CapaEntidad;
using System;
using System.Collections.Generic;
using ClosedXML.Excel;
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
    public partial class frmReporteVentas : Form
    {
        public frmReporteVentas()
        {
            InitializeComponent();
        }

        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in DvgData.Columns)
            {
                CbxBusqueda.Items.Add(new ObcionComboBox() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            CbxBusqueda.DisplayMember = "Texto";
            CbxBusqueda.ValueMember = "Valor";
            CbxBusqueda.SelectedIndex = 0;
        }

        private void BtnBuscarReporte_Click(object sender, EventArgs e)
        {
            List<ReporteVenta> lista = new List<ReporteVenta>();

            lista = new CN_Reporte().Venta(CbxFechaInicio.Value.ToString(), CbxFechaFin.Value.ToString());

            DvgData.Rows.Clear();

            foreach (ReporteVenta rv in lista)
            {
                DvgData.Rows.Add(new object[] {
                    rv.FechaRegistro,
                    rv.TipoDocumento,
                    rv.NumeroDocumento,
                    rv.MontoTotal,
                    rv.UsuarioRegistro,
                    rv.CodigoProducto,
                    rv.NombreProducto,
                    rv.Categoria,
                    rv.PrecioVenta,
                    rv.Cantidad,
                    rv.SubTotal
                });
            }
        }

        private void BtnBusqueda_Click(object sender, EventArgs e)
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

        private void BtnExportarReporte_Click(object sender, EventArgs e)
        {
            if (DvgData.Rows.Count < 1)
            {

                MessageBox.Show("No hay registros para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in DvgData.Columns)
                {
                    dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in DvgData.Rows)
                {
                    if (row.Visible)
                        dt.Rows.Add(new object[] {
                            row.Cells[0].Value.ToString(),
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString()
                        });
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteVentas_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void DvgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
