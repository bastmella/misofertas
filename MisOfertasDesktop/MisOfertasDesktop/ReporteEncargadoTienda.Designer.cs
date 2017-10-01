namespace MisOfertasDesktop
{
    partial class ReporteEncargadoTienda
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
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnMantenedores = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_atras
            // 
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(14, 345);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(94, 36);
            this.btn_atras.TabIndex = 6;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(277, 100);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(164, 65);
            this.btnReporte.TabIndex = 1;
            this.btnReporte.Text = "Descarga Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // btnMantenedores
            // 
            this.btnMantenedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenedores.Location = new System.Drawing.Point(73, 100);
            this.btnMantenedores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMantenedores.Name = "btnMantenedores";
            this.btnMantenedores.Size = new System.Drawing.Size(176, 65);
            this.btnMantenedores.TabIndex = 0;
            this.btnMantenedores.Text = "Visualizar";
            this.btnMantenedores.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(63, 192);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(390, 148);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MisOfertasDesktop.Properties.Resources.rojoSinfo;
            this.pictureBox1.Location = new System.Drawing.Point(148, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 70);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ReporteEncargadoTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MisOfertasDesktop.Properties.Resources.background_colores_colors_degradado_Favim_com_5139531;
            this.ClientSize = new System.Drawing.Size(509, 399);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnMantenedores);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReporteEncargadoTienda";
            this.Text = "ReporteEncargadoTienda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnMantenedores;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}