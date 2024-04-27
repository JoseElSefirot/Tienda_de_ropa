namespace Tienda_de_ropa
{
    partial class frmUsuarios
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
            this.label10 = new System.Windows.Forms.Label();
            this.DvgData = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIndice = new System.Windows.Forms.TextBox();
            this.btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.tbxBusqueda = new System.Windows.Forms.TextBox();
            this.CbxBuscarPor = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.CbxEstado = new System.Windows.Forms.ComboBox();
            this.CbxRol = new System.Windows.Forms.ComboBox();
            this.TbxConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.TbxContrasena = new System.Windows.Forms.TextBox();
            this.TbxCorreo = new System.Windows.Forms.TextBox();
            this.TbxNombreCompleto = new System.Windows.Forms.TextBox();
            this.TbxIdUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DvgData)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(391, 33);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(841, 57);
            this.label10.TabIndex = 23;
            this.label10.Text = "Lista de Usuarios:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnseleccionar,
            this.Id,
            this.Documento,
            this.NombreCompleto,
            this.Correo,
            this.Clave,
            this.IdRol,
            this.Rol,
            this.EstadoValor,
            this.Estado});
            this.DvgData.Location = new System.Drawing.Point(391, 109);
            this.DvgData.MultiSelect = false;
            this.DvgData.Name = "DvgData";
            this.DvgData.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.DvgData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DvgData.RowTemplate.Height = 28;
            this.DvgData.Size = new System.Drawing.Size(841, 372);
            this.DvgData.TabIndex = 22;
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 30;
            // 
            // Id
            // 
            this.Id.HeaderText = "IdUsuario";
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
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 180;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 150;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Visible = false;
            // 
            // IdRol
            // 
            this.IdRol.HeaderText = "IdRol";
            this.IdRol.Name = "IdRol";
            this.IdRol.ReadOnly = true;
            this.IdRol.Visible = false;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 567);
            this.label1.TabIndex = 21;
            // 
            // TxtIndice
            // 
            this.TxtIndice.Location = new System.Drawing.Point(166, 46);
            this.TxtIndice.Name = "TxtIndice";
            this.TxtIndice.Size = new System.Drawing.Size(25, 20);
            this.TxtIndice.TabIndex = 46;
            this.TxtIndice.Text = "-1";
            this.TxtIndice.Visible = false;
            // 
            // btnLimpiarBuscador
            // 
            this.btnLimpiarBuscador.BackColor = System.Drawing.Color.White;
            this.btnLimpiarBuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBuscador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBuscador.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarBuscador.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBuscador.IconSize = 18;
            this.btnLimpiarBuscador.Location = new System.Drawing.Point(1073, 51);
            this.btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            this.btnLimpiarBuscador.Size = new System.Drawing.Size(42, 23);
            this.btnLimpiarBuscador.TabIndex = 45;
            this.btnLimpiarBuscador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarBuscador.UseVisualStyleBackColor = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnBuscar.IconColor = System.Drawing.Color.Black;
            this.BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBuscar.IconSize = 16;
            this.BtnBuscar.Location = new System.Drawing.Point(1025, 51);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(42, 23);
            this.BtnBuscar.TabIndex = 44;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // tbxBusqueda
            // 
            this.tbxBusqueda.Location = new System.Drawing.Point(865, 53);
            this.tbxBusqueda.Name = "tbxBusqueda";
            this.tbxBusqueda.Size = new System.Drawing.Size(152, 20);
            this.tbxBusqueda.TabIndex = 43;
            // 
            // CbxBuscarPor
            // 
            this.CbxBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxBuscarPor.FormattingEnabled = true;
            this.CbxBuscarPor.Location = new System.Drawing.Point(743, 52);
            this.CbxBuscarPor.Name = "CbxBuscarPor";
            this.CbxBuscarPor.Size = new System.Drawing.Size(116, 21);
            this.CbxBuscarPor.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(676, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Buscar por:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(197, 46);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(25, 20);
            this.TxtId.TabIndex = 40;
            this.TxtId.Text = "0";
            this.TxtId.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 25);
            this.label9.TabIndex = 39;
            this.label9.Text = "Detalle Usuario";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BtnEliminar.IconColor = System.Drawing.Color.White;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.IconSize = 16;
            this.BtnEliminar.Location = new System.Drawing.Point(31, 454);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(192, 23);
            this.BtnEliminar.TabIndex = 38;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.BtnLimpiar.IconColor = System.Drawing.Color.White;
            this.BtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLimpiar.IconSize = 18;
            this.BtnLimpiar.Location = new System.Drawing.Point(31, 425);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(192, 23);
            this.BtnLimpiar.TabIndex = 37;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.IconSize = 16;
            this.BtnGuardar.Location = new System.Drawing.Point(31, 396);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(192, 23);
            this.BtnGuardar.TabIndex = 36;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // CbxEstado
            // 
            this.CbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxEstado.FormattingEnabled = true;
            this.CbxEstado.Location = new System.Drawing.Point(31, 357);
            this.CbxEstado.Name = "CbxEstado";
            this.CbxEstado.Size = new System.Drawing.Size(192, 21);
            this.CbxEstado.TabIndex = 35;
            // 
            // CbxRol
            // 
            this.CbxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxRol.FormattingEnabled = true;
            this.CbxRol.Location = new System.Drawing.Point(31, 310);
            this.CbxRol.Name = "CbxRol";
            this.CbxRol.Size = new System.Drawing.Size(192, 21);
            this.CbxRol.TabIndex = 34;
            // 
            // TbxConfirmarContrasena
            // 
            this.TbxConfirmarContrasena.Location = new System.Drawing.Point(31, 260);
            this.TbxConfirmarContrasena.Name = "TbxConfirmarContrasena";
            this.TbxConfirmarContrasena.PasswordChar = '*';
            this.TbxConfirmarContrasena.Size = new System.Drawing.Size(192, 20);
            this.TbxConfirmarContrasena.TabIndex = 33;
            // 
            // TbxContrasena
            // 
            this.TbxContrasena.Location = new System.Drawing.Point(31, 213);
            this.TbxContrasena.Name = "TbxContrasena";
            this.TbxContrasena.PasswordChar = '*';
            this.TbxContrasena.Size = new System.Drawing.Size(192, 20);
            this.TbxContrasena.TabIndex = 32;
            // 
            // TbxCorreo
            // 
            this.TbxCorreo.Location = new System.Drawing.Point(31, 166);
            this.TbxCorreo.Name = "TbxCorreo";
            this.TbxCorreo.Size = new System.Drawing.Size(192, 20);
            this.TbxCorreo.TabIndex = 31;
            // 
            // TbxNombreCompleto
            // 
            this.TbxNombreCompleto.Location = new System.Drawing.Point(31, 120);
            this.TbxNombreCompleto.Name = "TbxNombreCompleto";
            this.TbxNombreCompleto.Size = new System.Drawing.Size(192, 20);
            this.TbxNombreCompleto.TabIndex = 30;
            // 
            // TbxIdUsuario
            // 
            this.TbxIdUsuario.Location = new System.Drawing.Point(31, 72);
            this.TbxIdUsuario.Name = "TbxIdUsuario";
            this.TbxIdUsuario.Size = new System.Drawing.Size(192, 20);
            this.TbxIdUsuario.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Id Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(28, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Rol:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Confirmar Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Nombre Completo:";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 567);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtIndice);
            this.Controls.Add(this.btnLimpiarBuscador);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.tbxBusqueda);
            this.Controls.Add(this.CbxBuscarPor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CbxEstado);
            this.Controls.Add(this.CbxRol);
            this.Controls.Add(this.TbxConfirmarContrasena);
            this.Controls.Add(this.TbxContrasena);
            this.Controls.Add(this.TbxCorreo);
            this.Controls.Add(this.TbxNombreCompleto);
            this.Controls.Add(this.TbxIdUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DvgData);
            this.Controls.Add(this.label1);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.DvgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DvgData;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIndice;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.TextBox tbxBusqueda;
        private System.Windows.Forms.ComboBox CbxBuscarPor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.ComboBox CbxEstado;
        private System.Windows.Forms.ComboBox CbxRol;
        private System.Windows.Forms.TextBox TbxConfirmarContrasena;
        private System.Windows.Forms.TextBox TbxContrasena;
        private System.Windows.Forms.TextBox TbxCorreo;
        private System.Windows.Forms.TextBox TbxNombreCompleto;
        private System.Windows.Forms.TextBox TbxIdUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}