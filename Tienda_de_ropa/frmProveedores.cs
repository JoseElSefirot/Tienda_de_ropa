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
using Tienda_de_ropa.Utilidades;

namespace Tienda_de_ropa
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            CbxEstado.Items.Add(new ObcionComboBox() { Valor = 1, Texto = "Activo" });
            CbxEstado.Items.Add(new ObcionComboBox() { Valor = 0, Texto = "No Activo" });
            CbxEstado.DisplayMember = "Texto";
            CbxEstado.ValueMember = "Valor";
            CbxEstado.SelectedIndex = 0;


            foreach (DataGridViewColumn columna in DvgData.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    CbxBuscarPor.Items.Add(new ObcionComboBox() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            CbxBuscarPor.DisplayMember = "Texto";
            CbxBuscarPor.ValueMember = "Valor";
            CbxBuscarPor.SelectedIndex = 0;

            List<Proveedor> lista = new CN_Proveedor().Listar();

            foreach (Proveedor item in lista)
            {
                DvgData.Rows.Add(new object[] {"",item.IdProveedor,item.Documento,item.RazonSocial,item.Correo,item.Telefono,
                    item.Estado == true ? 1 : 0 ,
                    item.Estado == true ? "Activo" : "No Activo"
                });
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Proveedor obj = new Proveedor()
            {
                IdProveedor = Convert.ToInt32(txtid.Text),
                Documento = TbxIdProveedor.Text,
                RazonSocial = TbxRazonSocial.Text,
                Correo = tbxCorreo.Text,
                Telefono = tbxTelefono.Text,
                Estado = Convert.ToInt32(((ObcionComboBox)CbxEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (obj.IdProveedor == 0)
            {
                int idgenerado = new CN_Proveedor().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {

                    DvgData.Rows.Add(new object[] {"",idgenerado,TbxIdProveedor.Text,TbxRazonSocial.Text,tbxCorreo.Text,tbxTelefono.Text,
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
                bool resultado = new CN_Proveedor().Editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = DvgData.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Documento"].Value = TbxIdProveedor.Text;
                    row.Cells["RazonSocial"].Value = TbxRazonSocial.Text;
                    row.Cells["Correo"].Value = tbxCorreo.Text;
                    row.Cells["Telefono"].Value = tbxTelefono.Text;
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
            txtindice.Text = "-1";
            txtid.Text = "0";
            TbxIdProveedor.Text = "";
            TbxRazonSocial.Text = "";
            tbxCorreo.Text = "";
            tbxTelefono.Text = "";
            CbxEstado.SelectedIndex = 0;
            TbxIdProveedor.Select();
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

                    txtindice.Text = indice.ToString();
                    txtid.Text = DvgData.Rows[indice].Cells["Id"].Value.ToString();
                    TbxIdProveedor.Text = DvgData.Rows[indice].Cells["Documento"].Value.ToString();
                    TbxRazonSocial.Text = DvgData.Rows[indice].Cells["RazonSocial"].Value.ToString();
                    tbxCorreo.Text = DvgData.Rows[indice].Cells["Correo"].Value.ToString();
                    tbxTelefono.Text = DvgData.Rows[indice].Cells["Telefono"].Value.ToString();

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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((ObcionComboBox)CbxBuscarPor.SelectedItem).Valor.ToString();

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el proveedor", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Proveedor obj = new Proveedor()
                    {
                        IdProveedor = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_Proveedor().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        DvgData.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void TbxIdProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void TbxRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}