namespace Tienda_de_ropa
{
    partial class frmCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnRegistrar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxTotalAPagar = new System.Windows.Forms.TextBox();
            this.BtnAgregarProducto = new FontAwesome.Sharp.IconButton();
            this.DvgData = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TbxIdProducto = new System.Windows.Forms.TextBox();
            this.BtnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.TbxCodigoProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TbxProducto = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.TbxPrecioVenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TbxPrecioCompra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtIdProveedor2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TbxIdProveedor = new System.Windows.Forms.TextBox();
            this.BtnBuscarProveedor = new FontAwesome.Sharp.IconButton();
            this.TbxNombreProveedor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbxFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DvgData)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.BtnRegistrar.IconColor = System.Drawing.Color.DodgerBlue;
            this.BtnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRegistrar.IconSize = 30;
            this.BtnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistrar.Location = new System.Drawing.Point(951, 455);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.BtnRegistrar.Size = new System.Drawing.Size(98, 36);
            this.BtnRegistrar.TabIndex = 213;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(948, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 211;
            this.label1.Text = "Total a Pagar:";
            // 
            // TbxTotalAPagar
            // 
            this.TbxTotalAPagar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbxTotalAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxTotalAPagar.Location = new System.Drawing.Point(951, 426);
            this.TbxTotalAPagar.Name = "TbxTotalAPagar";
            this.TbxTotalAPagar.ReadOnly = true;
            this.TbxTotalAPagar.Size = new System.Drawing.Size(95, 21);
            this.TbxTotalAPagar.TabIndex = 212;
            this.TbxTotalAPagar.Text = "0";
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.BtnAgregarProducto.IconColor = System.Drawing.Color.ForestGreen;
            this.BtnAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregarProducto.IconSize = 30;
            this.BtnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAgregarProducto.Location = new System.Drawing.Point(951, 188);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(95, 69);
            this.BtnAgregarProducto.TabIndex = 210;
            this.BtnAgregarProducto.Text = "Agregar";
            this.BtnAgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // DvgData
            // 
            this.DvgData.AllowUserToAddRows = false;
            this.DvgData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DvgData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DvgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal,
            this.btneliminar});
            this.DvgData.Location = new System.Drawing.Point(288, 267);
            this.DvgData.MultiSelect = false;
            this.DvgData.Name = "DvgData";
            this.DvgData.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.DvgData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DvgData.RowTemplate.Height = 28;
            this.DvgData.Size = new System.Drawing.Size(657, 224);
            this.DvgData.TabIndex = 209;
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
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 130;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "PrecioVenta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Visible = false;
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
            // btneliminar
            // 
            this.btneliminar.HeaderText = "";
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.ReadOnly = true;
            this.btneliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btneliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btneliminar.Width = 35;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.TbxIdProducto);
            this.groupBox3.Controls.Add(this.BtnBuscarProducto);
            this.groupBox3.Controls.Add(this.TbxCodigoProducto);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TbxProducto);
            this.groupBox3.Controls.Add(this.TxtCantidad);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TbxPrecioVenta);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TbxPrecioCompra);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(288, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(657, 79);
            this.groupBox3.TabIndex = 208;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de Producto";
            // 
            // TbxIdProducto
            // 
            this.TbxIdProducto.Location = new System.Drawing.Point(110, 20);
            this.TbxIdProducto.Name = "TbxIdProducto";
            this.TbxIdProducto.Size = new System.Drawing.Size(32, 20);
            this.TbxIdProducto.TabIndex = 0;
            this.TbxIdProducto.Visible = false;
            // 
            // BtnBuscarProducto
            // 
            this.BtnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscarProducto.IconColor = System.Drawing.Color.Black;
            this.BtnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscarProducto.IconSize = 18;
            this.BtnBuscarProducto.Location = new System.Drawing.Point(149, 41);
            this.BtnBuscarProducto.Name = "BtnBuscarProducto";
            this.BtnBuscarProducto.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.BtnBuscarProducto.Size = new System.Drawing.Size(37, 23);
            this.BtnBuscarProducto.TabIndex = 2;
            this.BtnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // TbxCodigoProducto
            // 
            this.TbxCodigoProducto.Location = new System.Drawing.Point(9, 43);
            this.TbxCodigoProducto.Name = "TbxCodigoProducto";
            this.TbxCodigoProducto.Size = new System.Drawing.Size(133, 20);
            this.TbxCodigoProducto.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 96;
            this.label9.Text = "Cod. Producto:";
            // 
            // TbxProducto
            // 
            this.TbxProducto.Location = new System.Drawing.Point(193, 43);
            this.TbxProducto.Name = "TbxProducto";
            this.TbxProducto.ReadOnly = true;
            this.TbxProducto.Size = new System.Drawing.Size(195, 20);
            this.TbxProducto.TabIndex = 3;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(570, 43);
            this.TxtCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TxtCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(78, 20);
            this.TxtCantidad.TabIndex = 6;
            this.TxtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 98;
            this.label5.Text = "Cantidad:";
            // 
            // TbxPrecioVenta
            // 
            this.TbxPrecioVenta.Location = new System.Drawing.Point(484, 43);
            this.TbxPrecioVenta.Name = "TbxPrecioVenta";
            this.TbxPrecioVenta.Size = new System.Drawing.Size(78, 20);
            this.TbxPrecioVenta.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 97;
            this.label8.Text = "Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(481, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 100;
            this.label7.Text = "Precio Venta:";
            // 
            // TbxPrecioCompra
            // 
            this.TbxPrecioCompra.Location = new System.Drawing.Point(397, 43);
            this.TbxPrecioCompra.Name = "TbxPrecioCompra";
            this.TbxPrecioCompra.Size = new System.Drawing.Size(78, 20);
            this.TbxPrecioCompra.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 99;
            this.label6.Text = "Precio Compra:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.TxtIdProveedor2);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.TbxIdProveedor);
            this.groupBox2.Controls.Add(this.BtnBuscarProveedor);
            this.groupBox2.Controls.Add(this.TbxNombreProveedor);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(635, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 75);
            this.groupBox2.TabIndex = 207;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Proveedor";
            // 
            // TxtIdProveedor2
            // 
            this.TxtIdProveedor2.Location = new System.Drawing.Point(362, 12);
            this.TxtIdProveedor2.Name = "TxtIdProveedor2";
            this.TxtIdProveedor2.Size = new System.Drawing.Size(32, 21);
            this.TxtIdProveedor2.TabIndex = 88;
            this.TxtIdProveedor2.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 15);
            this.label14.TabIndex = 84;
            this.label14.Text = "Número Documento:";
            // 
            // TbxIdProveedor
            // 
            this.TbxIdProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxIdProveedor.Location = new System.Drawing.Point(9, 38);
            this.TbxIdProveedor.Name = "TbxIdProveedor";
            this.TbxIdProveedor.ReadOnly = true;
            this.TbxIdProveedor.Size = new System.Drawing.Size(134, 21);
            this.TbxIdProveedor.TabIndex = 85;
            // 
            // BtnBuscarProveedor
            // 
            this.BtnBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscarProveedor.IconColor = System.Drawing.Color.Black;
            this.BtnBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscarProveedor.IconSize = 18;
            this.BtnBuscarProveedor.Location = new System.Drawing.Point(149, 36);
            this.BtnBuscarProveedor.Name = "BtnBuscarProveedor";
            this.BtnBuscarProveedor.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.BtnBuscarProveedor.Size = new System.Drawing.Size(37, 23);
            this.BtnBuscarProveedor.TabIndex = 87;
            this.BtnBuscarProveedor.UseVisualStyleBackColor = true;
            // 
            // TbxNombreProveedor
            // 
            this.TbxNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxNombreProveedor.Location = new System.Drawing.Point(199, 40);
            this.TbxNombreProveedor.Name = "TbxNombreProveedor";
            this.TbxNombreProveedor.ReadOnly = true;
            this.TbxNombreProveedor.Size = new System.Drawing.Size(201, 21);
            this.TbxNombreProveedor.TabIndex = 86;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(191, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 15);
            this.label15.TabIndex = 83;
            this.label15.Text = "Razón Social:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.TbxFecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CbxTipoDocumento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(288, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 75);
            this.groupBox1.TabIndex = 206;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Compra";
            // 
            // TbxFecha
            // 
            this.TbxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxFecha.Location = new System.Drawing.Point(9, 38);
            this.TbxFecha.Name = "TbxFecha";
            this.TbxFecha.ReadOnly = true;
            this.TbxFecha.Size = new System.Drawing.Size(119, 21);
            this.TbxFecha.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 89;
            this.label3.Text = "Fecha:";
            // 
            // CbxTipoDocumento
            // 
            this.CbxTipoDocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbxTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxTipoDocumento.FormattingEnabled = true;
            this.CbxTipoDocumento.Location = new System.Drawing.Point(142, 38);
            this.CbxTipoDocumento.Name = "CbxTipoDocumento";
            this.CbxTipoDocumento.Size = new System.Drawing.Size(188, 23);
            this.CbxTipoDocumento.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 91;
            this.label4.Text = "Tipo Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 205;
            this.label2.Text = "Registrar Compra";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(270, 50);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(794, 467);
            this.label10.TabIndex = 204;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 567);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxTotalAPagar);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Controls.Add(this.DvgData);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Name = "frmCompras";
            this.Text = "frmCompras";
            ((System.ComponentModel.ISupportInitialize)(this.DvgData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxTotalAPagar;
        private FontAwesome.Sharp.IconButton BtnAgregarProducto;
        private System.Windows.Forms.DataGridView DvgData;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TbxIdProducto;
        private FontAwesome.Sharp.IconButton BtnBuscarProducto;
        private System.Windows.Forms.TextBox TbxCodigoProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbxProducto;
        private System.Windows.Forms.NumericUpDown TxtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbxPrecioVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbxPrecioCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtIdProveedor2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TbxIdProveedor;
        private FontAwesome.Sharp.IconButton BtnBuscarProveedor;
        private System.Windows.Forms.TextBox TbxNombreProveedor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TbxFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxTipoDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
    }
}