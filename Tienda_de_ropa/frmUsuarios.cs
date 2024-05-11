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
using Tienda_de_ropa.Utilidades;

namespace Tienda_de_ropa
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CbxEstado.Items.Add(new ObcionComboBox() { Valor = 1, Texto = "Activo" });
            CbxEstado.Items.Add(new ObcionComboBox() { Valor = 0, Texto = "No Activo" });
            CbxEstado.DisplayMember = "Texto";
            CbxEstado.ValueMember = "Valor";
            CbxEstado.SelectedIndex = 0;


            List<Rol> listaRol = new CN_Rol().Listar();

            foreach (Rol item in listaRol)
            {
                CbxRol.Items.Add(new ObcionComboBox() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            CbxRol.DisplayMember = "Texto";
            CbxRol.ValueMember = "Valor";
            CbxRol.SelectedIndex = 0;


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


            List<Usuario> listaUsuario = new CN_Usuario().Listar();

            foreach (Usuario item in listaUsuario)
            {

                DvgData.Rows.Add(new object[] {"",item.IdUsuario,item.Documento,item.NombreCompleto,item.Correo,item.Clave,
                    item.oRol.IdRol,
                    item.oRol.Descripcion,
                    item.Estado == true ? 1 : 0 ,
                    item.Estado == true ? "Activo" : "No Activo"
                });
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Usuario objusuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(TxtId.Text),
                Documento = TbxIdUsuario.Text,
                NombreCompleto =TbxNombreCompleto.Text,
                Correo = TbxCorreo.Text,
                Clave = Encriptar(TbxContrasena.Text),
                oRol = new Rol() { IdRol = Convert.ToInt32(((ObcionComboBox)CbxRol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((ObcionComboBox)CbxEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objusuario.IdUsuario == 0)
            {
                int idusuariogenerado = new CN_Usuario().Registrar(objusuario, out mensaje);

                if (idusuariogenerado != 0)
                {

                    DvgData.Rows.Add(new object[] {"",idusuariogenerado,TbxIdUsuario.Text,TbxNombreCompleto.Text,TbxCorreo.Text,TbxContrasena.Text,
                ((ObcionComboBox)CbxRol.SelectedItem).Valor.ToString(),
                ((ObcionComboBox)CbxRol.SelectedItem).Texto.ToString(),
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
                bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = DvgData.Rows[Convert.ToInt32(TxtIndice.Text)];
                    row.Cells["Id"].Value = TxtId.Text;
                    row.Cells["Documento"].Value = TbxIdUsuario.Text;
                    row.Cells["NombreCompleto"].Value = TbxNombreCompleto.Text;
                    row.Cells["Correo"].Value = TbxCorreo.Text;
                    row.Cells["Clave"].Value = Encriptar(TbxContrasena.Text);
                    row.Cells["IdRol"].Value = ((ObcionComboBox)CbxRol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((ObcionComboBox)CbxRol.SelectedItem).Texto.ToString();
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

        public string Encriptar(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        private void Limpiar()
        {

            TxtIndice.Text = "-1";
            TxtId.Text = "0";
            TbxIdUsuario.Text = "";
            TbxNombreCompleto.Text = "";
            TbxCorreo.Text = "";
            TbxContrasena.Text = "";
            TbxConfirmarContrasena.Text = "";
            CbxRol.SelectedIndex = 0;
            CbxEstado.SelectedIndex = 0;

            TbxIdUsuario.Select();

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

                    TxtIndice.Text = indice.ToString();
                    TxtId.Text = DvgData.Rows[indice].Cells["Id"].Value.ToString();
                    TbxIdUsuario.Text = DvgData.Rows[indice].Cells["Documento"].Value.ToString();
                    TbxNombreCompleto.Text = DvgData.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    TbxCorreo.Text = DvgData.Rows[indice].Cells["Correo"].Value.ToString();
                    TbxContrasena.Text = DvgData.Rows[indice].Cells["Clave"].Value.ToString();
                    TbxConfirmarContrasena.Text = DvgData.Rows[indice].Cells["Clave"].Value.ToString();


                    foreach (ObcionComboBox oc in CbxRol.Items)
                    {

                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DvgData.Rows[indice].Cells["IdRol"].Value))
                        {
                            int indice_combo = CbxRol.Items.IndexOf(oc);
                            CbxRol.SelectedIndex = indice_combo;
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TxtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el usuario", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Usuario objusuario = new Usuario()
                    {
                        IdUsuario = Convert.ToInt32(TxtId.Text)
                    };

                    bool respuesta = new CN_Usuario().Eliminar(objusuario, out mensaje);

                    if (respuesta)
                    {
                        DvgData.Rows.RemoveAt(Convert.ToInt32(TxtIndice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((ObcionComboBox)CbxBuscarPor.SelectedItem).Valor.ToString();

            if (DvgData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DvgData.Rows)
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(tbxBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            tbxBusqueda.Text = "";
            foreach (DataGridViewRow row in DvgData.Rows)
            {
                row.Visible = true;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void CbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
