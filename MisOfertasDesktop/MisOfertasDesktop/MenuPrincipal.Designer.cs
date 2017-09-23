namespace MisOfertasDesktop
{
    partial class MenuPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_mantenedor = new System.Windows.Forms.Button();
            this.btn_ofertas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_mantenedor);
            this.panel1.Controls.Add(this.btn_ofertas);
            this.panel1.Location = new System.Drawing.Point(31, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 249);
            this.panel1.TabIndex = 0;
            // 
            // btn_mantenedor
            // 
            this.btn_mantenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mantenedor.Location = new System.Drawing.Point(217, 87);
            this.btn_mantenedor.Margin = new System.Windows.Forms.Padding(2);
            this.btn_mantenedor.Name = "btn_mantenedor";
            this.btn_mantenedor.Size = new System.Drawing.Size(168, 66);
            this.btn_mantenedor.TabIndex = 1;
            this.btn_mantenedor.Text = "Mantenedores";
            this.btn_mantenedor.UseVisualStyleBackColor = true;
            this.btn_mantenedor.Click += new System.EventHandler(this.btn_mantenedor_Click);
            // 
            // btn_ofertas
            // 
            this.btn_ofertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ofertas.Location = new System.Drawing.Point(30, 87);
            this.btn_ofertas.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ofertas.Name = "btn_ofertas";
            this.btn_ofertas.Size = new System.Drawing.Size(152, 66);
            this.btn_ofertas.TabIndex = 0;
            this.btn_ofertas.Text = "Ofertas";
            this.btn_ofertas.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 345);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuPrincipal";
            this.Text = "Menú Principal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_mantenedor;
        private System.Windows.Forms.Button btn_ofertas;
    }
}