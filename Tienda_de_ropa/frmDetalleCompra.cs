using CapaDatos;
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
    public partial class frmDetalleCompra : Form
    {
        public frmDetalleCompra()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Compra oCompra = new CN_Compra().ObtenerCompra(TbxBusqueda.Text);

            if (oCompra.IdCompra != 0)
            {

                TbxIdProveedor.Text = oCompra.NumeroDocumento;

                TxtFecha.Text = oCompra.FechaRegistro;
                TbxTipoDocumento.Text = oCompra.TipoDocumento;
                TbxUsuario.Text = oCompra.oUsuario.NombreCompleto;
                TbxIdProveedor.Text = oCompra.oProveedor.Documento;
                TbxRazonSocial.Text = oCompra.oProveedor.RazonSocial;

                DvgData.Rows.Clear();
                foreach (Detalle_Compra dc in oCompra.oDetalleCompra)
                {
                    DvgData.Rows.Add(new object[] { dc.oProducto.Nombre, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal });
                }

                TbxMontoTotal.Text = oCompra.MontoTotal.ToString("0.00");

            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtFecha.Text = "";
            TbxTipoDocumento.Text = "";
            TbxUsuario.Text = "";
            TbxIdProveedor.Text = "";
            TbxRazonSocial.Text = "";

            DvgData.Rows.Clear();
            TbxMontoTotal.Text = "0.00";
        }

        private void BtnDescargar_Click(object sender, EventArgs e)
        {
            if (TbxTipoDocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaCompra.ToString();
            Negocio odatos = new CN_Negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.RUC);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

            Texto_Html = Texto_Html.Replace("@tipodocumento", TbxTipoDocumento.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", TbxIdProveedor.Text);


            Texto_Html = Texto_Html.Replace("@docproveedor", TbxIdProveedor.Text);
            Texto_Html = Texto_Html.Replace("@nombreproveedor", TbxRazonSocial.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", TxtFecha.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", TbxUsuario.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in DvgData.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioCompra"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", TbxMontoTotal.Text);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Compra_{0}.pdf", TbxIdProveedor.Text);
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
    }
}
