namespace Tienda_de_ropa
{
    partial class frmNegocio
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbxDireccion = new System.Windows.Forms.TextBox();
            this.BtnGuardarCambios = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbxRcu = new System.Windows.Forms.TextBox();
            this.BtnSubir = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 567);
            this.label1.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aqua;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TbxDireccion);
            this.groupBox1.Controls.Add(this.BtnGuardarCambios);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TbxNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TbxRcu);
            this.groupBox1.Controls.Add(this.BtnSubir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PbxLogo);
            this.groupBox1.Location = new System.Drawing.Point(17, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 407);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 116;
            this.label5.Text = "Dirección:";
            // 
            // TbxDireccion
            // 
            this.TbxDireccion.Location = new System.Drawing.Point(20, 307);
            this.TbxDireccion.Name = "TbxDireccion";
            this.TbxDireccion.Size = new System.Drawing.Size(275, 20);
            this.TbxDireccion.TabIndex = 117;
            // 
            // BtnGuardarCambios
            // 
            this.BtnGuardarCambios.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnGuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarCambios.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnGuardarCambios.IconColor = System.Drawing.Color.Black;
            this.BtnGuardarCambios.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnGuardarCambios.IconSize = 16;
            this.BtnGuardarCambios.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardarCambios.Location = new System.Drawing.Point(136, 347);
            this.BtnGuardarCambios.Name = "BtnGuardarCambios";
            this.BtnGuardarCambios.Size = new System.Drawing.Size(136, 23);
            this.BtnGuardarCambios.TabIndex = 115;
            this.BtnGuardarCambios.Text = "Guardar Cambios";
            this.BtnGuardarCambios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardarCambios.UseVisualStyleBackColor = false;
            this.BtnGuardarCambios.Click += new System.EventHandler(this.BtnGuardarCambios_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 111;
            this.label3.Text = "Nombre Negocio:";
            // 
            // TbxNombre
            // 
            this.TbxNombre.Location = new System.Drawing.Point(20, 195);
            this.TbxNombre.Name = "TbxNombre";
            this.TbxNombre.Size = new System.Drawing.Size(275, 20);
            this.TbxNombre.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 113;
            this.label4.Text = "R.U.C:";
            // 
            // TbxRcu
            // 
            this.TbxRcu.Location = new System.Drawing.Point(20, 250);
            this.TbxRcu.Name = "TbxRcu";
            this.TbxRcu.Size = new System.Drawing.Size(275, 20);
            this.TbxRcu.TabIndex = 114;
            // 
            // BtnSubir
            // 
            this.BtnSubir.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnSubir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSubir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubir.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.BtnSubir.IconColor = System.Drawing.Color.Black;
            this.BtnSubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSubir.IconSize = 16;
            this.BtnSubir.Location = new System.Drawing.Point(20, 347);
            this.BtnSubir.Name = "BtnSubir";
            this.BtnSubir.Size = new System.Drawing.Size(101, 23);
            this.BtnSubir.TabIndex = 108;
            this.BtnSubir.Text = "Subir";
            this.BtnSubir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSubir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSubir.UseVisualStyleBackColor = false;
            this.BtnSubir.Click += new System.EventHandler(this.BtnSubir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logo:";
            // 
            // PbxLogo
            // 
            this.PbxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxLogo.Location = new System.Drawing.Point(20, 35);
            this.PbxLogo.Name = "PbxLogo";
            this.PbxLogo.Size = new System.Drawing.Size(136, 127);
            this.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxLogo.TabIndex = 0;
            this.PbxLogo.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Detalle Negocio";
            // 
            // frmNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 567);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "frmNegocio";
            this.Text = "frmNegocio";
            this.Load += new System.EventHandler(this.frmNegocio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbxDireccion;
        private FontAwesome.Sharp.IconButton BtnGuardarCambios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbxRcu;
        private FontAwesome.Sharp.IconButton BtnSubir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PbxLogo;
        private System.Windows.Forms.Label label9;
    }
}