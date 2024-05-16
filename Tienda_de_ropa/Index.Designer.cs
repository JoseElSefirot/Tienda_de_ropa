namespace Tienda_de_ropa
{
    partial class Index
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.MenuSeleccion = new System.Windows.Forms.MenuStrip();
            this.MenuUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.MenuInventario = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuProdcto = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuNegocio = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuRegistrarVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuVerDetalleVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuRegistrarCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuVerDetallesCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.MenuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuReporteCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuReporteVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuSeleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuSeleccion
            // 
            this.MenuSeleccion.AutoSize = false;
            this.MenuSeleccion.BackColor = System.Drawing.Color.Turquoise;
            this.MenuSeleccion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUsuario,
            this.MenuInventario,
            this.MenuVentas,
            this.MenuCompras,
            this.MenuProveedores,
            this.MenuReportes});
            this.MenuSeleccion.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuSeleccion.Location = new System.Drawing.Point(0, 58);
            this.MenuSeleccion.Name = "MenuSeleccion";
            this.MenuSeleccion.Size = new System.Drawing.Size(1350, 65);
            this.MenuSeleccion.TabIndex = 1;
            this.MenuSeleccion.Text = "menuStrip2";
            // 
            // MenuUsuario
            // 
            this.MenuUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MenuUsuario.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.MenuUsuario.IconColor = System.Drawing.Color.Black;
            this.MenuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuUsuario.Name = "MenuUsuario";
            this.MenuUsuario.Size = new System.Drawing.Size(64, 61);
            this.MenuUsuario.Text = "Usuarios";
            this.MenuUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuUsuario.Click += new System.EventHandler(this.MenuUsuario_Click);
            // 
            // MenuInventario
            // 
            this.MenuInventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuCategoria,
            this.SubMenuProdcto,
            this.SubMenuNegocio});
            this.MenuInventario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MenuInventario.IconChar = FontAwesome.Sharp.IconChar.PeopleCarryBox;
            this.MenuInventario.IconColor = System.Drawing.Color.Black;
            this.MenuInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuInventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuInventario.Name = "MenuInventario";
            this.MenuInventario.Size = new System.Drawing.Size(72, 61);
            this.MenuInventario.Text = "Inventario";
            this.MenuInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMenuCategoria
            // 
            this.SubMenuCategoria.Name = "SubMenuCategoria";
            this.SubMenuCategoria.Size = new System.Drawing.Size(125, 22);
            this.SubMenuCategoria.Text = "Categoria";
            this.SubMenuCategoria.Click += new System.EventHandler(this.SubMenuCategoria_Click);
            // 
            // SubMenuProdcto
            // 
            this.SubMenuProdcto.Name = "SubMenuProdcto";
            this.SubMenuProdcto.Size = new System.Drawing.Size(125, 22);
            this.SubMenuProdcto.Text = "Producto";
            this.SubMenuProdcto.Click += new System.EventHandler(this.SubMenuProdcto_Click);
            // 
            // SubMenuNegocio
            // 
            this.SubMenuNegocio.Name = "SubMenuNegocio";
            this.SubMenuNegocio.Size = new System.Drawing.Size(125, 22);
            this.SubMenuNegocio.Text = "Negocio";
            this.SubMenuNegocio.Click += new System.EventHandler(this.SubMenuNegocio_Click);
            // 
            // MenuVentas
            // 
            this.MenuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuRegistrarVenta,
            this.SubMenuVerDetalleVenta});
            this.MenuVentas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MenuVentas.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.MenuVentas.IconColor = System.Drawing.Color.Black;
            this.MenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuVentas.Name = "MenuVentas";
            this.MenuVentas.Size = new System.Drawing.Size(60, 61);
            this.MenuVentas.Text = "Ventas";
            this.MenuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMenuRegistrarVenta
            // 
            this.SubMenuRegistrarVenta.Name = "SubMenuRegistrarVenta";
            this.SubMenuRegistrarVenta.Size = new System.Drawing.Size(129, 22);
            this.SubMenuRegistrarVenta.Text = "Registrar";
            this.SubMenuRegistrarVenta.Click += new System.EventHandler(this.SubMenuRegistrarVenta_Click);
            // 
            // SubMenuVerDetalleVenta
            // 
            this.SubMenuVerDetalleVenta.Name = "SubMenuVerDetalleVenta";
            this.SubMenuVerDetalleVenta.Size = new System.Drawing.Size(129, 22);
            this.SubMenuVerDetalleVenta.Text = "Ver Detalle";
            this.SubMenuVerDetalleVenta.Click += new System.EventHandler(this.SubMenuVerDetalleVenta_Click);
            // 
            // MenuCompras
            // 
            this.MenuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuRegistrarCompra,
            this.SubMenuVerDetallesCompra});
            this.MenuCompras.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MenuCompras.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.MenuCompras.IconColor = System.Drawing.Color.Black;
            this.MenuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuCompras.Name = "MenuCompras";
            this.MenuCompras.Size = new System.Drawing.Size(67, 61);
            this.MenuCompras.Text = "Compras";
            this.MenuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMenuRegistrarCompra
            // 
            this.SubMenuRegistrarCompra.Name = "SubMenuRegistrarCompra";
            this.SubMenuRegistrarCompra.Size = new System.Drawing.Size(134, 22);
            this.SubMenuRegistrarCompra.Text = "Registrar";
            this.SubMenuRegistrarCompra.Click += new System.EventHandler(this.SubMenuRegistrarCompra_Click);
            // 
            // SubMenuVerDetallesCompra
            // 
            this.SubMenuVerDetallesCompra.Name = "SubMenuVerDetallesCompra";
            this.SubMenuVerDetallesCompra.Size = new System.Drawing.Size(134, 22);
            this.SubMenuVerDetallesCompra.Text = "Ver Detalles";
            this.SubMenuVerDetallesCompra.Click += new System.EventHandler(this.SubMenuVerDetallesCompra_Click);
            // 
            // MenuProveedores
            // 
            this.MenuProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MenuProveedores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MenuProveedores.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.MenuProveedores.IconColor = System.Drawing.Color.Black;
            this.MenuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuProveedores.Name = "MenuProveedores";
            this.MenuProveedores.Size = new System.Drawing.Size(84, 61);
            this.MenuProveedores.Text = "Proveedores";
            this.MenuProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuProveedores.Click += new System.EventHandler(this.MenuProveedores_Click);
            // 
            // MenuReportes
            // 
            this.MenuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuReporteCompras,
            this.SubMenuReporteVenta});
            this.MenuReportes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MenuReportes.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.MenuReportes.IconColor = System.Drawing.Color.Black;
            this.MenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuReportes.Name = "MenuReportes";
            this.MenuReportes.Size = new System.Drawing.Size(65, 61);
            this.MenuReportes.Text = "Reportes";
            this.MenuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMenuReporteCompras
            // 
            this.SubMenuReporteCompras.Name = "SubMenuReporteCompras";
            this.SubMenuReporteCompras.Size = new System.Drawing.Size(159, 22);
            this.SubMenuReporteCompras.Text = "Reporte compra";
            this.SubMenuReporteCompras.Click += new System.EventHandler(this.SubMenuReporteCompras_Click);
            // 
            // SubMenuReporteVenta
            // 
            this.SubMenuReporteVenta.Name = "SubMenuReporteVenta";
            this.SubMenuReporteVenta.Size = new System.Drawing.Size(159, 22);
            this.SubMenuReporteVenta.Text = "Reporte Venta";
            this.SubMenuReporteVenta.Click += new System.EventHandler(this.SubMenuReporteVenta_Click);
            // 
            // MenuTitulo
            // 
            this.MenuTitulo.AutoSize = false;
            this.MenuTitulo.BackColor = System.Drawing.Color.DarkTurquoise;
            this.MenuTitulo.Location = new System.Drawing.Point(0, 0);
            this.MenuTitulo.Name = "MenuTitulo";
            this.MenuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuTitulo.Size = new System.Drawing.Size(1350, 58);
            this.MenuTitulo.TabIndex = 2;
            this.MenuTitulo.Text = "menuStrip3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sistema de ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(738, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.BackColor = System.Drawing.Color.DarkTurquoise;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.Color.White;
            this.LblUsuario.Location = new System.Drawing.Point(803, 22);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(82, 16);
            this.LblUsuario.TabIndex = 5;
            this.LblUsuario.Text = "LblUsuario";
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(0, 123);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(1350, 606);
            this.PnlContenedor.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 55);
            this.panel1.TabIndex = 7;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlContenedor);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuSeleccion);
            this.Controls.Add(this.MenuTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Index";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Index_Load);
            this.MenuSeleccion.ResumeLayout(false);
            this.MenuSeleccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuSeleccion;
        private System.Windows.Forms.MenuStrip MenuTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblUsuario;
        private FontAwesome.Sharp.IconMenuItem MenuReportes;
        private FontAwesome.Sharp.IconMenuItem MenuUsuario;
        private FontAwesome.Sharp.IconMenuItem MenuInventario;
        private System.Windows.Forms.ToolStripMenuItem SubMenuCategoria;
        private System.Windows.Forms.ToolStripMenuItem SubMenuProdcto;
        private FontAwesome.Sharp.IconMenuItem MenuVentas;
        private FontAwesome.Sharp.IconMenuItem MenuCompras;
        private FontAwesome.Sharp.IconMenuItem MenuProveedores;
        private System.Windows.Forms.ToolStripMenuItem SubMenuNegocio;
        private System.Windows.Forms.ToolStripMenuItem SubMenuRegistrarVenta;
        private System.Windows.Forms.ToolStripMenuItem SubMenuVerDetalleVenta;
        private System.Windows.Forms.ToolStripMenuItem SubMenuRegistrarCompra;
        private System.Windows.Forms.ToolStripMenuItem SubMenuVerDetallesCompra;
        private System.Windows.Forms.ToolStripMenuItem SubMenuReporteCompras;
        private System.Windows.Forms.ToolStripMenuItem SubMenuReporteVenta;
        private System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.Panel panel1;
    }
}

