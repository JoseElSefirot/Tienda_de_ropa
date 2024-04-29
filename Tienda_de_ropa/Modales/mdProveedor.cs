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

namespace Tienda_de_ropa.Modales
{
    public partial class mdProveedor : Form
    {
        public Proveedor _Proveedor { get; set; }

        public mdProveedor()
        {
            InitializeComponent();
        }

        private void BtnBusqueda_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((ObcionComboBox)CbxBusqueda.SelectedItem).Valor.ToString();

            if (Dvgdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in Dvgdata.Rows)
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(TbxBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void mdProveedor_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in Dvgdata.Columns)
            {
                if (columna.Visible == true)
                {
                    CbxBusqueda.Items.Add(new ObcionComboBox() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            CbxBusqueda.DisplayMember = "Texto";
            CbxBusqueda.ValueMember = "Valor";
            CbxBusqueda.SelectedIndex = 0;

            List<Proveedor> lista = new CN_Proveedor().Listar();

            foreach (Proveedor item in lista)
            {
                Dvgdata.Rows.Add(new object[] { item.IdProveedor, item.Documento, item.RazonSocial });
            }
        }

        private void Dvgdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {

                _Proveedor = new Proveedor()
                {
                    IdProveedor = Convert.ToInt32(Dvgdata.Rows[iRow].Cells["Id"].Value.ToString()),
                    Documento = Dvgdata.Rows[iRow].Cells["Documento"].Value.ToString(),
                    RazonSocial = Dvgdata.Rows[iRow].Cells["RazonSocial"].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BtnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            TbxBusqueda.Text = "";
            foreach (DataGridViewRow row in Dvgdata.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
