﻿namespace MisOfertasDesktop
{
    partial class Mantenedores
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
            this.btn_productos = new System.Windows.Forms.Button();
            this.btn_descuentos = new System.Windows.Forms.Button();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.btn_empresas = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_productos);
            this.panel1.Controls.Add(this.btn_descuentos);
            this.panel1.Controls.Add(this.btn_usuarios);
            this.panel1.Controls.Add(this.btn_empresas);
            this.panel1.Location = new System.Drawing.Point(22, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 248);
            this.panel1.TabIndex = 0;
            // 
            // btn_productos
            // 
            this.btn_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productos.Location = new System.Drawing.Point(252, 146);
            this.btn_productos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(164, 65);
            this.btn_productos.TabIndex = 3;
            this.btn_productos.Text = "Productos";
            this.btn_productos.UseVisualStyleBackColor = true;
            // 
            // btn_descuentos
            // 
            this.btn_descuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descuentos.Location = new System.Drawing.Point(34, 146);
            this.btn_descuentos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_descuentos.Name = "btn_descuentos";
            this.btn_descuentos.Size = new System.Drawing.Size(164, 65);
            this.btn_descuentos.TabIndex = 2;
            this.btn_descuentos.Text = "Descuentos";
            this.btn_descuentos.UseVisualStyleBackColor = true;
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuarios.Location = new System.Drawing.Point(252, 40);
            this.btn_usuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(164, 65);
            this.btn_usuarios.TabIndex = 1;
            this.btn_usuarios.Text = "Usuarios";
            this.btn_usuarios.UseVisualStyleBackColor = true;
            // 
            // btn_empresas
            // 
            this.btn_empresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empresas.Location = new System.Drawing.Point(34, 40);
            this.btn_empresas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_empresas.Name = "btn_empresas";
            this.btn_empresas.Size = new System.Drawing.Size(164, 65);
            this.btn_empresas.TabIndex = 0;
            this.btn_empresas.Text = "Empresas";
            this.btn_empresas.UseVisualStyleBackColor = true;
            this.btn_empresas.Click += new System.EventHandler(this.btn_empresas_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(22, 296);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(94, 36);
            this.btn_atras.TabIndex = 1;
            this.btn_atras.Text = "Atras";
            this.btn_atras.UseVisualStyleBackColor = true;
            // 
            // Mantenedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 345);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Mantenedores";
            this.Text = "Mantenedores";
            this.Load += new System.EventHandler(this.Mantenedores_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_productos;
        private System.Windows.Forms.Button btn_descuentos;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.Button btn_empresas;
        private System.Windows.Forms.Button btn_atras;
    }
}