namespace MisOfertasDesktop
{
    partial class Tiendas
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
            this.tc_mantenedores = new System.Windows.Forms.TabControl();
            this.tp_añadir = new System.Windows.Forms.TabPage();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.txtFono_Add = new System.Windows.Forms.TextBox();
            this.txtDireccion_Add = new System.Windows.Forms.TextBox();
            this.txtNombre_Add = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tp_modificar = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtFono_Mod = new System.Windows.Forms.TextBox();
            this.txtDireccion_Mod = new System.Windows.Forms.TextBox();
            this.txtNombre_Mod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tp_eliminar = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtId_Del = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtgTienda = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId_Mod = new System.Windows.Forms.TextBox();
            this.tc_mantenedores.SuspendLayout();
            this.tp_añadir.SuspendLayout();
            this.tp_modificar.SuspendLayout();
            this.tp_eliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTienda)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_atras
            // 
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(17, 772);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(161, 65);
            this.btn_atras.TabIndex = 0;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            // 
            // tc_mantenedores
            // 
            this.tc_mantenedores.Controls.Add(this.tp_añadir);
            this.tc_mantenedores.Controls.Add(this.tp_modificar);
            this.tc_mantenedores.Controls.Add(this.tp_eliminar);
            this.tc_mantenedores.Location = new System.Drawing.Point(20, 55);
            this.tc_mantenedores.Margin = new System.Windows.Forms.Padding(4);
            this.tc_mantenedores.Name = "tc_mantenedores";
            this.tc_mantenedores.SelectedIndex = 0;
            this.tc_mantenedores.Size = new System.Drawing.Size(1142, 260);
            this.tc_mantenedores.TabIndex = 1;
            // 
            // tp_añadir
            // 
            this.tp_añadir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tp_añadir.Controls.Add(this.btnAñadir);
            this.tp_añadir.Controls.Add(this.txtFono_Add);
            this.tp_añadir.Controls.Add(this.txtDireccion_Add);
            this.tp_añadir.Controls.Add(this.txtNombre_Add);
            this.tp_añadir.Controls.Add(this.label4);
            this.tp_añadir.Controls.Add(this.label3);
            this.tp_añadir.Controls.Add(this.label2);
            this.tp_añadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_añadir.Location = new System.Drawing.Point(4, 33);
            this.tp_añadir.Margin = new System.Windows.Forms.Padding(4);
            this.tp_añadir.Name = "tp_añadir";
            this.tp_añadir.Padding = new System.Windows.Forms.Padding(4);
            this.tp_añadir.Size = new System.Drawing.Size(1134, 223);
            this.tp_añadir.TabIndex = 0;
            this.tp_añadir.Text = "Añadir";
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.Linen;
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold);
            this.btnAñadir.Location = new System.Drawing.Point(475, 153);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(196, 52);
            this.btnAñadir.TabIndex = 8;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // txtFono_Add
            // 
            this.txtFono_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFono_Add.Location = new System.Drawing.Point(798, 102);
            this.txtFono_Add.Margin = new System.Windows.Forms.Padding(4);
            this.txtFono_Add.Name = "txtFono_Add";
            this.txtFono_Add.Size = new System.Drawing.Size(242, 34);
            this.txtFono_Add.TabIndex = 7;
            // 
            // txtDireccion_Add
            // 
            this.txtDireccion_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion_Add.Location = new System.Drawing.Point(798, 41);
            this.txtDireccion_Add.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion_Add.Name = "txtDireccion_Add";
            this.txtDireccion_Add.Size = new System.Drawing.Size(242, 34);
            this.txtDireccion_Add.TabIndex = 6;
            // 
            // txtNombre_Add
            // 
            this.txtNombre_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre_Add.Location = new System.Drawing.Point(217, 44);
            this.txtNombre_Add.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre_Add.Name = "txtNombre_Add";
            this.txtNombre_Add.Size = new System.Drawing.Size(242, 34);
            this.txtNombre_Add.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(691, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(633, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(72, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // tp_modificar
            // 
            this.tp_modificar.Controls.Add(this.txtId_Mod);
            this.tp_modificar.Controls.Add(this.label1);
            this.tp_modificar.Controls.Add(this.btnBuscar);
            this.tp_modificar.Controls.Add(this.btnModificar);
            this.tp_modificar.Controls.Add(this.txtFono_Mod);
            this.tp_modificar.Controls.Add(this.txtDireccion_Mod);
            this.tp_modificar.Controls.Add(this.txtNombre_Mod);
            this.tp_modificar.Controls.Add(this.label5);
            this.tp_modificar.Controls.Add(this.label6);
            this.tp_modificar.Controls.Add(this.label7);
            this.tp_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_modificar.Location = new System.Drawing.Point(4, 33);
            this.tp_modificar.Margin = new System.Windows.Forms.Padding(4);
            this.tp_modificar.Name = "tp_modificar";
            this.tp_modificar.Padding = new System.Windows.Forms.Padding(4);
            this.tp_modificar.Size = new System.Drawing.Size(1134, 223);
            this.tp_modificar.TabIndex = 1;
            this.tp_modificar.Text = "Modificar";
            this.tp_modificar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(304, 153);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(196, 52);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Location = new System.Drawing.Point(728, 153);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(196, 52);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtFono_Mod
            // 
            this.txtFono_Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F);
            this.txtFono_Mod.Location = new System.Drawing.Point(708, 87);
            this.txtFono_Mod.Margin = new System.Windows.Forms.Padding(4);
            this.txtFono_Mod.Name = "txtFono_Mod";
            this.txtFono_Mod.Size = new System.Drawing.Size(242, 34);
            this.txtFono_Mod.TabIndex = 16;
            // 
            // txtDireccion_Mod
            // 
            this.txtDireccion_Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F);
            this.txtDireccion_Mod.Location = new System.Drawing.Point(708, 28);
            this.txtDireccion_Mod.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion_Mod.Name = "txtDireccion_Mod";
            this.txtDireccion_Mod.Size = new System.Drawing.Size(242, 34);
            this.txtDireccion_Mod.TabIndex = 15;
            // 
            // txtNombre_Mod
            // 
            this.txtNombre_Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F);
            this.txtNombre_Mod.Location = new System.Drawing.Point(269, 31);
            this.txtNombre_Mod.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre_Mod.Name = "txtNombre_Mod";
            this.txtNombre_Mod.Size = new System.Drawing.Size(242, 34);
            this.txtNombre_Mod.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(612, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(561, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(121, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nombre";
            // 
            // tp_eliminar
            // 
            this.tp_eliminar.Controls.Add(this.btnEliminar);
            this.tp_eliminar.Controls.Add(this.txtId_Del);
            this.tp_eliminar.Controls.Add(this.label9);
            this.tp_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_eliminar.Location = new System.Drawing.Point(4, 33);
            this.tp_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.tp_eliminar.Name = "tp_eliminar";
            this.tp_eliminar.Padding = new System.Windows.Forms.Padding(4);
            this.tp_eliminar.Size = new System.Drawing.Size(1134, 223);
            this.tp_eliminar.TabIndex = 2;
            this.tp_eliminar.Text = "Eliminar";
            this.tp_eliminar.UseVisualStyleBackColor = true;
            this.tp_eliminar.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(453, 111);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(196, 52);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtId_Del
            // 
            this.txtId_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            this.txtId_Del.Location = new System.Drawing.Point(567, 46);
            this.txtId_Del.Margin = new System.Windows.Forms.Padding(4);
            this.txtId_Del.Name = "txtId_Del";
            this.txtId_Del.Size = new System.Drawing.Size(242, 34);
            this.txtId_Del.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(378, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 29);
            this.label9.TabIndex = 14;
            this.label9.Text = "ID Tienda";
            // 
            // dtgTienda
            // 
            this.dtgTienda.AllowUserToAddRows = false;
            this.dtgTienda.AllowUserToDeleteRows = false;
            this.dtgTienda.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtgTienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTienda.Location = new System.Drawing.Point(20, 386);
            this.dtgTienda.Margin = new System.Windows.Forms.Padding(4);
            this.dtgTienda.Name = "dtgTienda";
            this.dtgTienda.ReadOnly = true;
            this.dtgTienda.RowTemplate.Height = 31;
            this.dtgTienda.Size = new System.Drawing.Size(1135, 249);
            this.dtgTienda.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(447, 327);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(320, 32);
            this.label10.TabIndex = 3;
            this.label10.Text = "LISTA DE EMPRESAS";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(1027, 22);
            this.button5.Margin = new System.Windows.Forms.Padding(6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 50);
            this.button5.TabIndex = 7;
            this.button5.Text = "Atrás";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(101, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID Tienda";
            // 
            // txtId_Mod
            // 
            this.txtId_Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F);
            this.txtId_Mod.Location = new System.Drawing.Point(269, 90);
            this.txtId_Mod.Name = "txtId_Mod";
            this.txtId_Mod.Size = new System.Drawing.Size(242, 34);
            this.txtId_Mod.TabIndex = 20;
            // 
            // Tiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MisOfertasDesktop.Properties.Resources.background_colores_colors_degradado_Favim_com_5139531;
            this.ClientSize = new System.Drawing.Size(1175, 655);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtgTienda);
            this.Controls.Add(this.tc_mantenedores);
            this.Controls.Add(this.btn_atras);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tiendas";
            this.Text = "Mantenedor de Tiendas";
            this.tc_mantenedores.ResumeLayout(false);
            this.tp_añadir.ResumeLayout(false);
            this.tp_añadir.PerformLayout();
            this.tp_modificar.ResumeLayout(false);
            this.tp_modificar.PerformLayout();
            this.tp_eliminar.ResumeLayout(false);
            this.tp_eliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTienda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.TabControl tc_mantenedores;
        private System.Windows.Forms.TabPage tp_añadir;
        private System.Windows.Forms.TabPage tp_modificar;
        private System.Windows.Forms.TabPage tp_eliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.TextBox txtFono_Add;
        private System.Windows.Forms.TextBox txtDireccion_Add;
        private System.Windows.Forms.TextBox txtNombre_Add;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtFono_Mod;
        private System.Windows.Forms.TextBox txtDireccion_Mod;
        private System.Windows.Forms.TextBox txtNombre_Mod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtId_Del;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtgTienda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtId_Mod;
        private System.Windows.Forms.Label label1;
    }
}