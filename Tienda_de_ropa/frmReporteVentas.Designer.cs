namespace Tienda_de_ropa
{
    partial class frmReporteVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnExportarReporte = new FontAwesome.Sharp.IconButton();
            this.BtnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            this.TbxBusqueda = new System.Windows.Forms.TextBox();
            this.CbxBusqueda = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnBusqueda = new FontAwesome.Sharp.IconButton();
            this.DvgData = new System.Windows.Forms.DataGridView();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBuscarReporte = new FontAwesome.Sharp.IconButton();
            this.CbxFechaFin = new System.Windows.Forms.DateTimePicker();
            this.CbxFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DvgData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 132);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(1123, 392);
            this.label1.TabIndex = 237;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(106, 42);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(1123, 81);
            this.label10.TabIndex = 236;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnExportarReporte
            // 
            this.BtnExportarReporte.BackColor = System.Drawing.SystemColors.Control;
            this.BtnExportarReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExportarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExportarReporte.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.BtnExportarReporte.IconColor = System.Drawing.Color.LimeGreen;
            this.BtnExportarReporte.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnExportarReporte.IconSize = 17;
            this.BtnExportarReporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnExportarReporte.Location = new System.Drawing.Point(117, 147);
            this.BtnExportarReporte.Name = "BtnExportarReporte";
            this.BtnExportarReporte.Size = new System.Drawing.Size(118, 21);
            this.BtnExportarReporte.TabIndex = 255;
            this.BtnExportarReporte.Text = "Descargar Excel";
            this.BtnExportarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExportarReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExportarReporte.UseVisualStyleBackColor = false;
            this.BtnExportarReporte.Click += new System.EventHandler(this.BtnExportarReporte_Click);
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
            this.BtnLimpiarBuscador.Location = new System.Drawing.Point(1174, 146);
            this.BtnLimpiarBuscador.Name = "BtnLimpiarBuscador";
            this.BtnLimpiarBuscador.Size = new System.Drawing.Size(42, 23);
            this.BtnLimpiarBuscador.TabIndex = 254;
            this.BtnLimpiarBuscador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiarBuscador.UseVisualStyleBackColor = false;
            this.BtnLimpiarBuscador.Click += new System.EventHandler(this.BtnLimpiarBuscador_Click);
            // 
            // TbxBusqueda
            // 
            this.TbxBusqueda.Location = new System.Drawing.Point(966, 148);
            this.TbxBusqueda.Name = "TbxBusqueda";
            this.TbxBusqueda.Size = new System.Drawing.Size(152, 20);
            this.TbxBusqueda.TabIndex = 252;
            // 
            // CbxBusqueda
            // 
            this.CbxBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxBusqueda.FormattingEnabled = true;
            this.CbxBusqueda.Location = new System.Drawing.Point(844, 147);
            this.CbxBusqueda.Name = "CbxBusqueda";
            this.CbxBusqueda.Size = new System.Drawing.Size(116, 21);
            this.CbxBusqueda.TabIndex = 251;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(777, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 250;
            this.label11.Text = "Buscar por:";
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
            this.BtnBusqueda.Location = new System.Drawing.Point(1126, 146);
            this.BtnBusqueda.Name = "BtnBusqueda";
            this.BtnBusqueda.Size = new System.Drawing.Size(42, 23);
            this.BtnBusqueda.TabIndex = 253;
            this.BtnBusqueda.UseVisualStyleBackColor = false;
            this.BtnBusqueda.Click += new System.EventHandler(this.BtnBusqueda_Click);
            // 
            // DvgData
            // 
            this.DvgData.AllowUserToAddRows = false;
            this.DvgData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DvgData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DvgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaRegistro,
            this.TipoDocumento,
            this.NumeroDocumento,
            this.MontoTotal,
            this.UsuarioRegistro,
            this.CodigoProducto,
            this.NombreProducto,
            this.Categoria,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal});
            this.DvgData.Location = new System.Drawing.Point(118, 185);
            this.DvgData.MultiSelect = false;
            this.DvgData.Name = "DvgData";
            this.DvgData.ReadOnly = true;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.DvgData.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DvgData.RowTemplate.Height = 28;
            this.DvgData.Size = new System.Drawing.Size(1099, 329);
            this.DvgData.TabIndex = 249;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "Numero Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            // 
            // UsuarioRegistro
            // 
            this.UsuarioRegistro.HeaderText = "Usuario Registro";
            this.UsuarioRegistro.Name = "UsuarioRegistro";
            this.UsuarioRegistro.ReadOnly = true;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Codigo Producto";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // BtnBuscarReporte
            // 
            this.BtnBuscarReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarReporte.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscarReporte.IconColor = System.Drawing.Color.Black;
            this.BtnBuscarReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscarReporte.IconSize = 17;
            this.BtnBuscarReporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscarReporte.Location = new System.Drawing.Point(494, 90);
            this.BtnBuscarReporte.Name = "BtnBuscarReporte";
            this.BtnBuscarReporte.Size = new System.Drawing.Size(78, 21);
            this.BtnBuscarReporte.TabIndex = 248;
            this.BtnBuscarReporte.Text = "Buscar";
            this.BtnBuscarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscarReporte.UseVisualStyleBackColor = true;
            this.BtnBuscarReporte.Click += new System.EventHandler(this.BtnBuscarReporte_Click);
            // 
            // CbxFechaFin
            // 
            this.CbxFechaFin.CustomFormat = "dd/MM/yyyy";
            this.CbxFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CbxFechaFin.Location = new System.Drawing.Point(382, 90);
            this.CbxFechaFin.Name = "CbxFechaFin";
            this.CbxFechaFin.Size = new System.Drawing.Size(97, 20);
            this.CbxFechaFin.TabIndex = 247;
            // 
            // CbxFechaInicio
            // 
            this.CbxFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.CbxFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CbxFechaInicio.Location = new System.Drawing.Point(194, 90);
            this.CbxFechaInicio.Name = "CbxFechaInicio";
            this.CbxFechaInicio.Size = new System.Drawing.Size(97, 20);
            this.CbxFechaInicio.TabIndex = 245;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(120, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 246;
            this.label4.Text = "Fecha Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 244;
            this.label3.Text = "Fecha Fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 243;
            this.label2.Text = "Reporte Ventas";
            // 
            // frmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 567);
            this.Controls.Add(this.BtnExportarReporte);
            this.Controls.Add(this.BtnLimpiarBuscador);
            this.Controls.Add(this.TbxBusqueda);
            this.Controls.Add(this.CbxBusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnBusqueda);
            this.Controls.Add(this.DvgData);
            this.Controls.Add(this.BtnBuscarReporte);
            this.Controls.Add(this.CbxFechaFin);
            this.Controls.Add(this.CbxFechaInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Name = "frmReporteVentas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DvgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton BtnExportarReporte;
        private FontAwesome.Sharp.IconButton BtnLimpiarBuscador;
        private System.Windows.Forms.TextBox TbxBusqueda;
        private System.Windows.Forms.ComboBox CbxBusqueda;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton BtnBusqueda;
        private System.Windows.Forms.DataGridView DvgData;
        private FontAwesome.Sharp.IconButton BtnBuscarReporte;
        private System.Windows.Forms.DateTimePicker CbxFechaFin;
        private System.Windows.Forms.DateTimePicker CbxFechaInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}