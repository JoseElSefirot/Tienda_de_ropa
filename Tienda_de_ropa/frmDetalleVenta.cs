using CapaEntidad;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_de_ropa
{
    public partial class frmDetalleVenta : Form
    {
        public frmDetalleVenta()
        {
            InitializeComponent();
        }

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            TbxIdVenta.Select();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Venta oVenta = new CN_Venta().ObtenerVenta(TbxIdVenta.Text);

            if (oVenta.IdVenta != 0)
            {

                TbxNumeroDocumento.Text = oVenta.NumeroDocumento;

                TbxFecha.Text = oVenta.FechaRegistro;
                TbxTipoDocumento.Text = oVenta.TipoDocumento;
                TbxUsuario.Text = oVenta.oUsuario.NombreCompleto;


                DvgData.Rows.Clear();
                foreach (Detalle_Venta dv in oVenta.oDetalle_Venta)
                {
                    DvgData.Rows.Add(new object[] { dv.oProducto.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal });
                }

                TbxMontoTotal.Text = oVenta.MontoTotal.ToString("0.00");
                TbxMontoPago.Text = oVenta.MontoPago.ToString("0.00");
                TbxMontoCambio.Text = oVenta.MontoCambio.ToString("0.00");


            }
        }

        private void BtnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            TbxFecha.Text = "";
            TbxTipoDocumento.Text = "";
            TbxUsuario.Text = "";

            DvgData.Rows.Clear();
            TbxMontoTotal.Text = "0.00";
            TbxMontoPago.Text = "0.00";
            TbxMontoCambio.Text = "0.00";
        }

        private void BtnDescargar_Click(object sender, EventArgs e)
        {
            if (TbxTipoDocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaVenta.ToString();
            Negocio odatos = new CN_Negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.RUC);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

            Texto_Html = Texto_Html.Replace("@tipodocumento", TbxTipoDocumento.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", TbxNumeroDocumento.Text);


            Texto_Html = Texto_Html.Replace("@fecharegistro", TbxFecha.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", TbxUsuario.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in DvgData.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", TbxMontoTotal.Text);
            Texto_Html = Texto_Html.Replace("@pagocon", TbxMontoPago.Text);
            Texto_Html = Texto_Html.Replace("@cambio", TbxMontoCambio.Text);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Venta_{0}.pdf", TbxNumeroDocumento.Text);
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {

                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteImage = new CN_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
