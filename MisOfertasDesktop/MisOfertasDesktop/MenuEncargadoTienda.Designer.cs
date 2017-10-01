namespace MisOfertasDesktop
{
    partial class MenuEncargadoTienda
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
            this.btn_atras = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valoraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_atras
            // 
            this.btn_atras.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(18, 307);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(94, 36);
            this.btn_atras.TabIndex = 6;
            this.btn_atras.Text = "Salir";
            this.btn_atras.UseVisualStyleBackColor = false;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedorToolStripMenuItem,
            this.ofertasToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(517, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenedorToolStripMenuItem
            // 
            this.mantenedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem});
            this.mantenedorToolStripMenuItem.Name = "mantenedorToolStripMenuItem";
            this.mantenedorToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.mantenedorToolStripMenuItem.Text = "Mantenedor";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // ofertasToolStripMenuItem
            // 
            this.ofertasToolStripMenuItem.Name = "ofertasToolStripMenuItem";
            this.ofertasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ofertasToolStripMenuItem.Text = "Ofertas";
            this.ofertasToolStripMenuItem.Click += new System.EventHandler(this.ofertasToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valoraciónToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            this.reporteToolStripMenuItem.Click += new System.EventHandler(this.reporteToolStripMenuItem_Click);
            // 
            // valoraciónToolStripMenuItem
            // 
            this.valoraciónToolStripMenuItem.Name = "valoraciónToolStripMenuItem";
            this.valoraciónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.valoraciónToolStripMenuItem.Text = "Valoración";
            this.valoraciónToolStripMenuItem.Click += new System.EventHandler(this.valoraciónToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MisOfertasDesktop.Properties.Resources.rojoSinfo;
            this.pictureBox1.Location = new System.Drawing.Point(147, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 76);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // MenuEncargadoTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MisOfertasDesktop.Properties.Resources.background_colores_colors_degradado_Favim_com_5139531;
            this.ClientSize = new System.Drawing.Size(517, 355);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuEncargadoTienda";
            this.Text = "Menu Encargado Tienda";
            this.Load += new System.EventHandler(this.MenuEncargadoTienda_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ofertasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valoraciónToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}