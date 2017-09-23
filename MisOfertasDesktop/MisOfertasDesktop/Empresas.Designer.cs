namespace MisOfertasDesktop
{
    partial class Empresas
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
            this.components = new System.ComponentModel.Container();
            this.btn_atras = new System.Windows.Forms.Button();
            this.dt_empresas = new MisOfertasDesktop.dt_empresas();
            this.eMPRESABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPRESATableAdapter = new MisOfertasDesktop.dt_empresasTableAdapters.EMPRESATableAdapter();
            this.tc_mantenedores = new System.Windows.Forms.TabControl();
            this.tp_añadir = new System.Windows.Forms.TabPage();
            this.btn_añadir = new System.Windows.Forms.Button();
            this.txt_fonoañ = new System.Windows.Forms.TextBox();
            this.txt_direccionañ = new System.Windows.Forms.TextBox();
            this.txt_nombreañ = new System.Windows.Forms.TextBox();
            this.txt_rutañ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tp_modificar = new System.Windows.Forms.TabPage();
            this.tp_eliminar = new System.Windows.Forms.TabPage();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.txt_fonomod = new System.Windows.Forms.TextBox();
            this.txt_direcmod = new System.Windows.Forms.TextBox();
            this.txt_nombremod = new System.Windows.Forms.TextBox();
            this.txt_rutmod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_rutel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_empresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingSource)).BeginInit();
            this.tc_mantenedores.SuspendLayout();
            this.tp_añadir.SuspendLayout();
            this.tp_modificar.SuspendLayout();
            this.tp_eliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_atras
            // 
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(16, 771);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(161, 65);
            this.btn_atras.TabIndex = 0;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            // 
            // dt_empresas
            // 
            this.dt_empresas.DataSetName = "dt_empresas";
            this.dt_empresas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPRESABindingSource
            // 
            this.eMPRESABindingSource.DataMember = "EMPRESA";
            this.eMPRESABindingSource.DataSource = this.dt_empresas;
            // 
            // eMPRESATableAdapter
            // 
            this.eMPRESATableAdapter.ClearBeforeFill = true;
            // 
            // tc_mantenedores
            // 
            this.tc_mantenedores.Controls.Add(this.tp_añadir);
            this.tc_mantenedores.Controls.Add(this.tp_modificar);
            this.tc_mantenedores.Controls.Add(this.tp_eliminar);
            this.tc_mantenedores.Location = new System.Drawing.Point(12, 12);
            this.tc_mantenedores.Name = "tc_mantenedores";
            this.tc_mantenedores.SelectedIndex = 0;
            this.tc_mantenedores.Size = new System.Drawing.Size(1220, 398);
            this.tc_mantenedores.TabIndex = 1;
            // 
            // tp_añadir
            // 
            this.tp_añadir.Controls.Add(this.btn_añadir);
            this.tp_añadir.Controls.Add(this.txt_fonoañ);
            this.tp_añadir.Controls.Add(this.txt_direccionañ);
            this.tp_añadir.Controls.Add(this.txt_nombreañ);
            this.tp_añadir.Controls.Add(this.txt_rutañ);
            this.tp_añadir.Controls.Add(this.label4);
            this.tp_añadir.Controls.Add(this.label3);
            this.tp_añadir.Controls.Add(this.label2);
            this.tp_añadir.Controls.Add(this.label1);
            this.tp_añadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_añadir.Location = new System.Drawing.Point(4, 33);
            this.tp_añadir.Name = "tp_añadir";
            this.tp_añadir.Padding = new System.Windows.Forms.Padding(3);
            this.tp_añadir.Size = new System.Drawing.Size(1212, 361);
            this.tp_añadir.TabIndex = 0;
            this.tp_añadir.Text = "Añadir";
            this.tp_añadir.UseVisualStyleBackColor = true;
            // 
            // btn_añadir
            // 
            this.btn_añadir.Location = new System.Drawing.Point(544, 272);
            this.btn_añadir.Name = "btn_añadir";
            this.btn_añadir.Size = new System.Drawing.Size(166, 66);
            this.btn_añadir.TabIndex = 8;
            this.btn_añadir.Text = "Añadir";
            this.btn_añadir.UseVisualStyleBackColor = true;
            // 
            // txt_fonoañ
            // 
            this.txt_fonoañ.Location = new System.Drawing.Point(781, 151);
            this.txt_fonoañ.Name = "txt_fonoañ";
            this.txt_fonoañ.Size = new System.Drawing.Size(401, 45);
            this.txt_fonoañ.TabIndex = 7;
            // 
            // txt_direccionañ
            // 
            this.txt_direccionañ.Location = new System.Drawing.Point(781, 25);
            this.txt_direccionañ.Name = "txt_direccionañ";
            this.txt_direccionañ.Size = new System.Drawing.Size(401, 45);
            this.txt_direccionañ.TabIndex = 6;
            // 
            // txt_nombreañ
            // 
            this.txt_nombreañ.Location = new System.Drawing.Point(167, 151);
            this.txt_nombreañ.Name = "txt_nombreañ";
            this.txt_nombreañ.Size = new System.Drawing.Size(423, 45);
            this.txt_nombreañ.TabIndex = 5;
            // 
            // txt_rutañ
            // 
            this.txt_rutañ.Location = new System.Drawing.Point(167, 28);
            this.txt_rutañ.Name = "txt_rutañ";
            this.txt_rutañ.Size = new System.Drawing.Size(423, 45);
            this.txt_rutañ.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tp_modificar
            // 
            this.tp_modificar.Controls.Add(this.btn_buscar);
            this.tp_modificar.Controls.Add(this.btn_modificar);
            this.tp_modificar.Controls.Add(this.txt_fonomod);
            this.tp_modificar.Controls.Add(this.txt_direcmod);
            this.tp_modificar.Controls.Add(this.txt_nombremod);
            this.tp_modificar.Controls.Add(this.txt_rutmod);
            this.tp_modificar.Controls.Add(this.label5);
            this.tp_modificar.Controls.Add(this.label6);
            this.tp_modificar.Controls.Add(this.label7);
            this.tp_modificar.Controls.Add(this.label8);
            this.tp_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_modificar.Location = new System.Drawing.Point(4, 33);
            this.tp_modificar.Name = "tp_modificar";
            this.tp_modificar.Padding = new System.Windows.Forms.Padding(3);
            this.tp_modificar.Size = new System.Drawing.Size(1212, 361);
            this.tp_modificar.TabIndex = 1;
            this.tp_modificar.Text = "Modificar";
            this.tp_modificar.UseVisualStyleBackColor = true;
            // 
            // tp_eliminar
            // 
            this.tp_eliminar.Controls.Add(this.btn_eliminar);
            this.tp_eliminar.Controls.Add(this.txt_rutel);
            this.tp_eliminar.Controls.Add(this.label9);
            this.tp_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_eliminar.Location = new System.Drawing.Point(4, 33);
            this.tp_eliminar.Name = "tp_eliminar";
            this.tp_eliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tp_eliminar.Size = new System.Drawing.Size(1212, 361);
            this.tp_eliminar.TabIndex = 2;
            this.tp_eliminar.Text = "Eliminar";
            this.tp_eliminar.UseVisualStyleBackColor = true;
            this.tp_eliminar.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(899, 265);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(166, 66);
            this.btn_modificar.TabIndex = 17;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // txt_fonomod
            // 
            this.txt_fonomod.Location = new System.Drawing.Point(785, 150);
            this.txt_fonomod.Name = "txt_fonomod";
            this.txt_fonomod.Size = new System.Drawing.Size(401, 45);
            this.txt_fonomod.TabIndex = 16;
            // 
            // txt_direcmod
            // 
            this.txt_direcmod.Location = new System.Drawing.Point(785, 24);
            this.txt_direcmod.Name = "txt_direcmod";
            this.txt_direcmod.Size = new System.Drawing.Size(401, 45);
            this.txt_direcmod.TabIndex = 15;
            // 
            // txt_nombremod
            // 
            this.txt_nombremod.Location = new System.Drawing.Point(171, 150);
            this.txt_nombremod.Name = "txt_nombremod";
            this.txt_nombremod.Size = new System.Drawing.Size(423, 45);
            this.txt_nombremod.TabIndex = 14;
            // 
            // txt_rutmod
            // 
            this.txt_rutmod.Location = new System.Drawing.Point(171, 27);
            this.txt_rutmod.Name = "txt_rutmod";
            this.txt_rutmod.Size = new System.Drawing.Size(423, 45);
            this.txt_rutmod.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(619, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 39);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(619, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 39);
            this.label6.TabIndex = 11;
            this.label6.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 39);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 39);
            this.label8.TabIndex = 9;
            this.label8.Text = "Rut";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(280, 265);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(166, 66);
            this.btn_buscar.TabIndex = 18;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // txt_rutel
            // 
            this.txt_rutel.Location = new System.Drawing.Point(469, 98);
            this.txt_rutel.Name = "txt_rutel";
            this.txt_rutel.Size = new System.Drawing.Size(423, 45);
            this.txt_rutel.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 39);
            this.label9.TabIndex = 14;
            this.label9.Text = "Rut";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(542, 235);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(166, 66);
            this.btn_eliminar.TabIndex = 19;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 518);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1212, 209);
            this.dataGridView1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(426, 441);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(430, 48);
            this.label10.TabIndex = 3;
            this.label10.Text = "Lista de las Empresas";
            // 
            // Empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 853);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tc_mantenedores);
            this.Controls.Add(this.btn_atras);
            this.Name = "Empresas";
            this.Text = "Mantenedor de Empresas";
            this.Load += new System.EventHandler(this.Empresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_empresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingSource)).EndInit();
            this.tc_mantenedores.ResumeLayout(false);
            this.tp_añadir.ResumeLayout(false);
            this.tp_añadir.PerformLayout();
            this.tp_modificar.ResumeLayout(false);
            this.tp_modificar.PerformLayout();
            this.tp_eliminar.ResumeLayout(false);
            this.tp_eliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_atras;
        private dt_empresas dt_empresas;
        private System.Windows.Forms.BindingSource eMPRESABindingSource;
        private dt_empresasTableAdapters.EMPRESATableAdapter eMPRESATableAdapter;
        private System.Windows.Forms.TabControl tc_mantenedores;
        private System.Windows.Forms.TabPage tp_añadir;
        private System.Windows.Forms.TabPage tp_modificar;
        private System.Windows.Forms.TabPage tp_eliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_añadir;
        private System.Windows.Forms.TextBox txt_fonoañ;
        private System.Windows.Forms.TextBox txt_direccionañ;
        private System.Windows.Forms.TextBox txt_nombreañ;
        private System.Windows.Forms.TextBox txt_rutañ;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.TextBox txt_fonomod;
        private System.Windows.Forms.TextBox txt_direcmod;
        private System.Windows.Forms.TextBox txt_nombremod;
        private System.Windows.Forms.TextBox txt_rutmod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txt_rutel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
    }
}