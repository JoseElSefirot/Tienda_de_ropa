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
            this.TbxContrasena = new System.Windows.Forms.TextBox();
            this.TbxIdUsuario = new System.Windows.Forms.TextBox();
            this.LblLogin = new System.Windows.Forms.Label();
            this.btnIngresar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.LblIdUsuarioLogin = new System.Windows.Forms.Label();
            this.LblContrasenaUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbxContrasena
            // 
            this.TbxContrasena.Location = new System.Drawing.Point(37, 271);
            this.TbxContrasena.Name = "TbxContrasena";
            this.TbxContrasena.Size = new System.Drawing.Size(219, 20);
            this.TbxContrasena.TabIndex = 7;
            // 
            // TbxIdUsuario
            // 
            this.TbxIdUsuario.Location = new System.Drawing.Point(37, 210);
            this.TbxIdUsuario.Name = "TbxIdUsuario";
            this.TbxIdUsuario.Size = new System.Drawing.Size(219, 20);
            this.TbxIdUsuario.TabIndex = 6;
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.Location = new System.Drawing.Point(95, 34);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(103, 40);
            this.LblLogin.TabIndex = 5;
            this.LblLogin.Text = "Login";
            // 
            // btnIngresar
            // 
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.IconChar = FontAwesome.Sharp.IconChar.Airbnb;
            this.btnIngresar.IconColor = System.Drawing.Color.Black;
            this.btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngresar.IconSize = 20;
            this.btnIngresar.Location = new System.Drawing.Point(37, 340);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(219, 25);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Airbnb;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 20;
            this.btnCancelar.Location = new System.Drawing.Point(37, 390);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(219, 25);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar ";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // LblIdUsuarioLogin
            // 
            this.LblIdUsuarioLogin.AutoSize = true;
            this.LblIdUsuarioLogin.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdUsuarioLogin.Location = new System.Drawing.Point(87, 176);
            this.LblIdUsuarioLogin.Name = "LblIdUsuarioLogin";
            this.LblIdUsuarioLogin.Size = new System.Drawing.Size(121, 22);
            this.LblIdUsuarioLogin.TabIndex = 11;
            this.LblIdUsuarioLogin.Text = "Id de Usuario";
            // 
            // LblContrasenaUsuario
            // 
            this.LblContrasenaUsuario.AutoSize = true;
            this.LblContrasenaUsuario.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContrasenaUsuario.Location = new System.Drawing.Point(93, 239);
            this.LblContrasenaUsuario.Name = "LblContrasenaUsuario";
            this.LblContrasenaUsuario.Size = new System.Drawing.Size(105, 22);
            this.LblContrasenaUsuario.TabIndex = 12;
            this.LblContrasenaUsuario.Text = "Contraseña";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(287, 450);
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
            this.Load += new System.EventHandler(this.Login_Load);
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
    }
}