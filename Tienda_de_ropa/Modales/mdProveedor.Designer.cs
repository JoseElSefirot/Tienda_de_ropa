namespace Tienda_de_ropa.Modales
{
    partial class mdProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnBusqueda = new FontAwesome.Sharp.IconButton();
            this.Dvgdata = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            this.TbxBusqueda = new System.Windows.Forms.TextBox();
            this.CbxBusqueda = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dvgdata)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBusqueda
            // 
            this.BtnBusqueda.BackColor = System.Drawing.Color.White;
            this.BtnBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBusqueda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBusqueda.ForeColor = System.Drawing.Color.Black;
            this.BtnBusqueda.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBusqueda.IconColor = System.Drawing.Color.Black;
            this.BtnBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBusqueda.IconSize = 16;
            this.BtnBusqueda.Location = new System.Drawing.Point(424, 42);
            this.BtnBusqueda.Name = "BtnBusqueda";
            this.BtnBusqueda.Size = new System.Drawing.Size(42, 23);
            this.BtnBusqueda.TabIndex = 98;
            this.BtnBusqueda.UseVisualStyleBackColor = false;
            this.BtnBusqueda.Click += new System.EventHandler(this.BtnBusqueda_Click);
            // 
            // Dvgdata
            // 
            this.Dvgdata.AllowUserToAddRows = false;
            this.Dvgdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dvgdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dvgdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvgdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Documento,
            this.RazonSocial});
            this.Dvgdata.Location = new System.Drawing.Point(2, 95);
            this.Dvgdata.MultiSelect = false;
            this.Dvgdata.Name = "Dvgdata";
            this.Dvgdata.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Dvgdata.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dvgdata.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dvgdata.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Dvgdata.RowTemplate.Height = 28;
            this.Dvgdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dvgdata.Size = new System.Drawing.Size(523, 257);
            this.Dvgdata.TabIndex = 93;
            this.Dvgdata.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dvgdata_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Nro Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 150;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            this.RazonSocial.Width = 180;
            // 
            // BtnLimpiarBuscador
            // 
            this.BtnLimpiarBuscador.BackColor = System.Drawing.Color.White;
            this.BtnLimpiarBuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiarBuscador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnLimpiarBuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarBuscador.ForeColor = System.Drawing.Color.Black;
            this.BtnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.BtnLimpiarBuscador.IconColor = System.Drawing.Color.Black;
            this.BtnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLimpiarBuscador.IconSize = 18;
            this.BtnLimpiarBuscador.Location = new System.Drawing.Point(472, 42);
            this.BtnLimpiarBuscador.Name = "BtnLimpiarBuscador";
            this.BtnLimpiarBuscador.Size = new System.Drawing.Size(42, 23);
            this.BtnLimpiarBuscador.TabIndex = 99;
            this.BtnLimpiarBuscador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiarBuscador.UseVisualStyleBackColor = false;
            this.BtnLimpiarBuscador.Click += new System.EventHandler(this.BtnLimpiarBuscador_Click);
            // 
            // TbxBusqueda
            // 
            this.TbxBusqueda.Location = new System.Drawing.Point(264, 44);
            this.TbxBusqueda.Name = "TbxBusqueda";
            this.TbxBusqueda.Size = new System.Drawing.Size(152, 20);
            this.TbxBusqueda.TabIndex = 97;
            // 
            // CbxBusqueda
            // 
            this.CbxBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxBusqueda.FormattingEnabled = true;
            this.CbxBusqueda.Location = new System.Drawing.Point(142, 43);
            this.CbxBusqueda.Name = "CbxBusqueda";
            this.CbxBusqueda.Size = new System.Drawing.Size(116, 21);
            this.CbxBusqueda.TabIndex = 96;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(75, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 95;
            this.label11.Text = "Buscar por:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 2);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(6, 6, 0, 0);
            this.label10.Size = new System.Drawing.Size(523, 79);
            this.label10.TabIndex = 94;
            this.label10.Text = "Lista de Proveedores:";
            // 
            // mdProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 355);
            this.Controls.Add(this.BtnBusqueda);
            this.Controls.Add(this.Dvgdata);
            this.Controls.Add(this.BtnLimpiarBuscador);
            this.Controls.Add(this.TbxBusqueda);
            this.Controls.Add(this.CbxBusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Name = "mdProveedor";
            this.Text = "mdProveedor";
            this.Load += new System.EventHandler(this.mdProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dvgdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnBusqueda;
        private System.Windows.Forms.DataGridView Dvgdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private FontAwesome.Sharp.IconButton BtnLimpiarBuscador;
        private System.Windows.Forms.TextBox TbxBusqueda;
        private System.Windows.Forms.ComboBox CbxBusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}