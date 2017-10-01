namespace MisOfertasDesktop
{
    partial class MenuAdministrador
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
            this.mantenedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descuentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_atras
            // 
            this.btn_atras.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(14, 304);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(94, 36);
            this.btn_atras.TabIndex = 3;
            this.btn_atras.Text = "Salir";
            this.btn_atras.UseVisualStyleBackColor = false;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedoresToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenedoresToolStripMenuItem
            // 
            this.mantenedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresasToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.descuentosToolStripMenuItem,
            this.ofertasToolStripMenuItem});
            this.mantenedoresToolStripMenuItem.Name = "mantenedoresToolStripMenuItem";
            this.mantenedoresToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.mantenedoresToolStripMenuItem.Text = "Mantenedores";
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.empresasToolStripMenuItem.Text = "Empresas";
            this.empresasToolStripMenuItem.Click += new System.EventHandler(this.empresasToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // descuentosToolStripMenuItem
            // 
            this.descuentosToolStripMenuItem.Name = "descuentosToolStripMenuItem";
            this.descuentosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.descuentosToolStripMenuItem.Text = "Descuentos";
            this.descuentosToolStripMenuItem.Click += new System.EventHandler(this.descuentosToolStripMenuItem_Click);
            // 
            // ofertasToolStripMenuItem
            // 
            this.ofertasToolStripMenuItem.Name = "ofertasToolStripMenuItem";
            this.ofertasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ofertasToolStripMenuItem.Text = "Usuarios";
            this.ofertasToolStripMenuItem.Click += new System.EventHandler(this.ofertasToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resumenToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // resumenToolStripMenuItem
            // 
            this.resumenToolStripMenuItem.Name = "resumenToolStripMenuItem";
            this.resumenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resumenToolStripMenuItem.Text = "Resumen";
            this.resumenToolStripMenuItem.Click += new System.EventHandler(this.resumenToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MisOfertasDesktop.Properties.Resources.rojoSinfo;
            this.pictureBox1.Location = new System.Drawing.Point(148, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 79);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MisOfertasDesktop.Properties.Resources.background_colores_colors_degradado_Favim_com_5139531;
            this.ClientSize = new System.Drawing.Size(508, 355);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuAdministrador";
            this.Text = "MenuAdministrador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descuentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ofertasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumenToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}