namespace Tienda_de_ropa
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TbxContrasena = new System.Windows.Forms.TextBox();
            this.TbxIdUsuario = new System.Windows.Forms.TextBox();
            this.LblLogin = new System.Windows.Forms.Label();
            this.btnIngresar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.LblIdUsuarioLogin = new System.Windows.Forms.Label();
            this.LblContrasenaUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TbxContrasena
            // 
            this.TbxContrasena.Location = new System.Drawing.Point(22, 287);
            this.TbxContrasena.MaxLength = 64;
            this.TbxContrasena.Name = "TbxContrasena";
            this.TbxContrasena.Size = new System.Drawing.Size(219, 20);
            this.TbxContrasena.TabIndex = 7;
            this.TbxContrasena.UseSystemPasswordChar = true;
            this.TbxContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxContrasena_KeyPress);
            // 
            // TbxIdUsuario
            // 
            this.TbxIdUsuario.Location = new System.Drawing.Point(22, 216);
            this.TbxIdUsuario.MaxLength = 64;
            this.TbxIdUsuario.Name = "TbxIdUsuario";
            this.TbxIdUsuario.Size = new System.Drawing.Size(219, 20);
            this.TbxIdUsuario.TabIndex = 6;
            this.TbxIdUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxIdUsuario_KeyPress);
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.ForeColor = System.Drawing.Color.White;
            this.LblLogin.Location = new System.Drawing.Point(59, 60);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(172, 34);
            this.LblLogin.TabIndex = 5;
            this.LblLogin.Text = "Bienvenido";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIngresar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnIngresar.IconColor = System.Drawing.Color.Black;
            this.btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngresar.IconSize = 1;
            this.btnIngresar.Location = new System.Drawing.Point(12, 367);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(122, 25);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 1;
            this.btnCancelar.Location = new System.Drawing.Point(176, 367);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 25);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar ";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // LblIdUsuarioLogin
            // 
            this.LblIdUsuarioLogin.AutoSize = true;
            this.LblIdUsuarioLogin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdUsuarioLogin.ForeColor = System.Drawing.Color.White;
            this.LblIdUsuarioLogin.Location = new System.Drawing.Point(61, 188);
            this.LblIdUsuarioLogin.Name = "LblIdUsuarioLogin";
            this.LblIdUsuarioLogin.Size = new System.Drawing.Size(165, 22);
            this.LblIdUsuarioLogin.TabIndex = 11;
            this.LblIdUsuarioLogin.Text = "Ingresar Usuario";
            // 
            // LblContrasenaUsuario
            // 
            this.LblContrasenaUsuario.AutoSize = true;
            this.LblContrasenaUsuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContrasenaUsuario.ForeColor = System.Drawing.Color.White;
            this.LblContrasenaUsuario.Location = new System.Drawing.Point(61, 259);
            this.LblContrasenaUsuario.Name = "LblContrasenaUsuario";
            this.LblContrasenaUsuario.Size = new System.Drawing.Size(221, 22);
            this.LblContrasenaUsuario.TabIndex = 12;
            this.LblContrasenaUsuario.Text = "Ingrese su Contraseña";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(97, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 64);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(58, 45);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(28, 185);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(27, 25);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(22, 256);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(33, 25);
            this.panel4.TabIndex = 15;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(287, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblContrasenaUsuario);
            this.Controls.Add(this.LblIdUsuarioLogin);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.TbxContrasena);
            this.Controls.Add(this.TbxIdUsuario);
            this.Controls.Add(this.LblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbxContrasena;
        private System.Windows.Forms.TextBox TbxIdUsuario;
        private System.Windows.Forms.Label LblLogin;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.Label LblIdUsuarioLogin;
        private System.Windows.Forms.Label LblContrasenaUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}