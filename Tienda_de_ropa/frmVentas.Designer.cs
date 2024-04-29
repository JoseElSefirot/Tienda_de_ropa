namespace Tienda_de_ropa
{
    partial class frmVentas
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
            this.PnlContenedorVentas = new System.Windows.Forms.Panel();
            this.BtnCrearVenta = new FontAwesome.Sharp.IconButton();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxCambio = new System.Windows.Forms.TextBox();
            this.TbxPagaCon = new System.Windows.Forms.TextBox();
            this.TbxTotalaPagar = new System.Windows.Forms.TextBox();
            this.DvgData = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnAgregar = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.TbxFecha = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TbxidProducto = new System.Windows.Forms.TextBox();
            this.BtnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.TbxCodigoProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TbxProducto = new System.Windows.Forms.TextBox();
            this.TextCantidad = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.TbxStock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TbxPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PnlContenedorVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvgData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlContenedorVentas
            // 
            this.PnlContenedorVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlContenedorVentas.BackColor = System.Drawing.Color.White;
            this.PnlContenedorVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlContenedorVentas.Controls.Add(this.BtnCrearVenta);
            this.PnlContenedorVentas.Controls.Add(this.label16);
            this.PnlContenedorVentas.Controls.Add(this.label13);
            this.PnlContenedorVentas.Controls.Add(this.label3);
            this.PnlContenedorVentas.Controls.Add(this.TbxCambio);
            this.PnlContenedorVentas.Controls.Add(this.TbxPagaCon);
            this.PnlContenedorVentas.Controls.Add(this.TbxTotalaPagar);
            this.PnlContenedorVentas.Controls.Add(this.DvgData);
            this.PnlContenedorVentas.Controls.Add(this.BtnAgregar);
            this.PnlContenedorVentas.Controls.Add(this.groupBox1);
            this.PnlContenedorVentas.Controls.Add(this.groupBox3);
            this.PnlContenedorVentas.Location = new System.Drawing.Point(260, 50);
            this.PnlContenedorVentas.Name = "PnlContenedorVentas";
            this.PnlContenedorVentas.Size = new System.Drawing.Size(794, 466);
            this.PnlContenedorVentas.TabIndex = 0;
            // 
            // BtnCrearVenta
            // 
            this.BtnCrearVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCrearVenta.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.BtnCrearVenta.IconColor = System.Drawing.Color.DodgerBlue;
            this.BtnCrearVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCrearVenta.IconSize = 30;
            this.BtnCrearVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCrearVenta.Location = new System.Drawing.Point(691, 402);
            this.BtnCrearVenta.Name = "BtnCrearVenta";
            this.BtnCrearVenta.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.BtnCrearVenta.Size = new System.Drawing.Size(83, 36);
            this.BtnCrearVenta.TabIndex = 215;
            this.BtnCrearVenta.Text = "Crear Venta";
            this.BtnCrearVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCrearVenta.UseVisualStyleBackColor = true;
            this.BtnCrearVenta.Click += new System.EventHandler(this.BtnCrearVenta_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(688, 353);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 15);
            this.label16.TabIndex = 209;
            this.label16.Text = "Cambio:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(688, 308);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 15);
            this.label13.TabIndex = 210;
            this.label13.Text = "Paga con:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(691, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 211;
            this.label3.Text = "Total a Pagar:";
            // 
            // TbxCambio
            // 
            this.TbxCambio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbxCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxCambio.Location = new System.Drawing.Point(691, 371);
            this.TbxCambio.Name = "TbxCambio";
            this.TbxCambio.ReadOnly = true;
            this.TbxCambio.Size = new System.Drawing.Size(80, 21);
            this.TbxCambio.TabIndex = 214;
            // 
            // TbxPagaCon
            // 
            this.TbxPagaCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxPagaCon.Location = new System.Drawing.Point(691, 326);
            this.TbxPagaCon.Name = "TbxPagaCon";
            this.TbxPagaCon.Size = new System.Drawing.Size(80, 21);
            this.TbxPagaCon.TabIndex = 213;
            this.TbxPagaCon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxPagaCon_KeyDown);
            this.TbxPagaCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxPagaCon_KeyPress);
            // 
            // TbxTotalaPagar
            // 
            this.TbxTotalaPagar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbxTotalaPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxTotalaPagar.Location = new System.Drawing.Point(691, 262);
            this.TbxTotalaPagar.Name = "TbxTotalaPagar";
            this.TbxTotalaPagar.ReadOnly = true;
            this.TbxTotalaPagar.Size = new System.Drawing.Size(80, 21);
            this.TbxTotalaPagar.TabIndex = 212;
            this.TbxTotalaPagar.Text = "0";
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
            this.IdProducto,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal,
            this.btneliminar});
            this.DvgData.Location = new System.Drawing.Point(20, 216);
            this.DvgData.MultiSelect = false;
            this.DvgData.Name = "DvgData";
            this.DvgData.ReadOnly = true;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.DvgData.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DvgData.RowTemplate.Height = 28;
            this.DvgData.Size = new System.Drawing.Size(657, 224);
            this.DvgData.TabIndex = 202;
            this.DvgData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DvgData_CellContentClick);
            this.DvgData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DvgData_CellPainting);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            this.IdProducto.Width = 150;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 200;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 130;
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
            this.SubTotal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btneliminar
            // 
            this.btneliminar.HeaderText = "";
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.ReadOnly = true;
            this.btneliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btneliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btneliminar.Width = 35;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnAgregar.IconColor = System.Drawing.Color.Black;
            this.BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregar.Location = new System.Drawing.Point(691, 136);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(83, 74);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "iconButton1";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CbxTipoDocumento);
            this.groupBox1.Controls.Add(this.TbxFecha);
            this.groupBox1.Location = new System.Drawing.Point(20, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha:";
            // 
            // CbxTipoDocumento
            // 
            this.CbxTipoDocumento.FormattingEnabled = true;
            this.CbxTipoDocumento.Location = new System.Drawing.Point(248, 52);
            this.CbxTipoDocumento.Name = "CbxTipoDocumento";
            this.CbxTipoDocumento.Size = new System.Drawing.Size(194, 21);
            this.CbxTipoDocumento.TabIndex = 1;
            // 
            // TbxFecha
            // 
            this.TbxFecha.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TbxFecha.Location = new System.Drawing.Point(47, 52);
            this.TbxFecha.Name = "TbxFecha";
            this.TbxFecha.Size = new System.Drawing.Size(157, 20);
            this.TbxFecha.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TbxidProducto);
            this.groupBox3.Controls.Add(this.BtnBuscarProducto);
            this.groupBox3.Controls.Add(this.TbxCodigoProducto);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TbxProducto);
            this.groupBox3.Controls.Add(this.TextCantidad);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TbxStock);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TbxPrecio);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(20, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(665, 74);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion del Producto";
            // 
            // TbxidProducto
            // 
            this.TbxidProducto.Location = new System.Drawing.Point(114, 15);
            this.TbxidProducto.Name = "TbxidProducto";
            this.TbxidProducto.Size = new System.Drawing.Size(32, 20);
            this.TbxidProducto.TabIndex = 101;
            this.TbxidProducto.Visible = false;
            // 
            // BtnBuscarProducto
            // 
            this.BtnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscarProducto.IconColor = System.Drawing.Color.Black;
            this.BtnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscarProducto.IconSize = 18;
            this.BtnBuscarProducto.Location = new System.Drawing.Point(152, 36);
            this.BtnBuscarProducto.Name = "BtnBuscarProducto";
            this.BtnBuscarProducto.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.BtnBuscarProducto.Size = new System.Drawing.Size(37, 23);
            this.BtnBuscarProducto.TabIndex = 103;
            this.BtnBuscarProducto.UseVisualStyleBackColor = true;
            this.BtnBuscarProducto.Click += new System.EventHandler(this.BtnBuscarProducto_Click);
            // 
            // TbxCodigoProducto
            // 
            this.TbxCodigoProducto.Location = new System.Drawing.Point(12, 38);
            this.TbxCodigoProducto.Name = "TbxCodigoProducto";
            this.TbxCodigoProducto.Size = new System.Drawing.Size(133, 20);
            this.TbxCodigoProducto.TabIndex = 102;
            this.TbxCodigoProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxCodigoProducto_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 108;
            this.label9.Text = "Cod. Producto:";
            // 
            // TbxProducto
            // 
            this.TbxProducto.Location = new System.Drawing.Point(196, 38);
            this.TbxProducto.Name = "TbxProducto";
            this.TbxProducto.ReadOnly = true;
            this.TbxProducto.Size = new System.Drawing.Size(195, 20);
            this.TbxProducto.TabIndex = 104;
            // 
            // TextCantidad
            // 
            this.TextCantidad.Location = new System.Drawing.Point(573, 38);
            this.TextCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TextCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TextCantidad.Name = "TextCantidad";
            this.TextCantidad.Size = new System.Drawing.Size(78, 20);
            this.TextCantidad.TabIndex = 107;
            this.TextCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 110;
            this.label5.Text = "Cantidad:";
            // 
            // TbxStock
            // 
            this.TbxStock.Location = new System.Drawing.Point(487, 38);
            this.TbxStock.Name = "TbxStock";
            this.TbxStock.ReadOnly = true;
            this.TbxStock.Size = new System.Drawing.Size(78, 20);
            this.TbxStock.TabIndex = 106;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 109;
            this.label8.Text = "Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 112;
            this.label7.Text = "Stock:";
            // 
            // TbxPrecio
            // 
            this.TbxPrecio.Location = new System.Drawing.Point(400, 38);
            this.TbxPrecio.Name = "TbxPrecio";
            this.TbxPrecio.Size = new System.Drawing.Size(78, 20);
            this.TbxPrecio.TabIndex = 105;
            this.TbxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxPrecio_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 111;
            this.label6.Text = "Precio:";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 567);
            this.Controls.Add(this.PnlContenedorVentas);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.PnlContenedorVentas.ResumeLayout(false);
            this.PnlContenedorVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvgData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlContenedorVentas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxTipoDocumento;
        private System.Windows.Forms.TextBox TbxFecha;
        private System.Windows.Forms.TextBox TbxidProducto;
        private FontAwesome.Sharp.IconButton BtnBuscarProducto;
        private System.Windows.Forms.TextBox TbxCodigoProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbxProducto;
        private System.Windows.Forms.NumericUpDown TextCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbxStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbxPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DvgData;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
        private FontAwesome.Sharp.IconButton BtnCrearVenta;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxCambio;
        private System.Windows.Forms.TextBox TbxPagaCon;
        private System.Windows.Forms.TextBox TbxTotalaPagar;
    }
}