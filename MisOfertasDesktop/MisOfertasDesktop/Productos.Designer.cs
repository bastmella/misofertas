﻿namespace MisOfertasDesktop
{
    partial class Productos
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
            this.dtgProducto = new System.Windows.Forms.DataGridView();
            this.label26 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtxtDescripcion_Add = new System.Windows.Forms.RichTextBox();
            this.dtpElab_Add = new System.Windows.Forms.DateTimePicker();
            this.dtpVenc_Add = new System.Windows.Forms.DateTimePicker();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValor_Add = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNombre_Add = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpElab_Mod = new System.Windows.Forms.DateTimePicker();
            this.dtpVenc_Mod = new System.Windows.Forms.DateTimePicker();
            this.rtxtDesc_Mod = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor_Mod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre_Mod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtId_Del = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.lblRubro = new System.Windows.Forms.Label();
            this.cbxRubro_Add = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId_Mod = new System.Windows.Forms.TextBox();
            this.lblRubro_Mod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgProducto
            // 
            this.dtgProducto.AllowUserToAddRows = false;
            this.dtgProducto.AllowUserToDeleteRows = false;
            this.dtgProducto.AllowUserToOrderColumns = true;
            this.dtgProducto.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducto.Location = new System.Drawing.Point(15, 434);
            this.dtgProducto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtgProducto.Name = "dtgProducto";
            this.dtgProducto.ReadOnly = true;
            this.dtgProducto.Size = new System.Drawing.Size(1131, 279);
            this.dtgProducto.TabIndex = 8;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(402, 391);
            this.label26.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(343, 32);
            this.label26.TabIndex = 7;
            this.label26.Text = "LISTA DE PRODUCTOS";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(15, 54);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1131, 319);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage1.Controls.Add(this.cbxRubro_Add);
            this.tabPage1.Controls.Add(this.lblRubro);
            this.tabPage1.Controls.Add(this.rtxtDescripcion_Add);
            this.tabPage1.Controls.Add(this.dtpElab_Add);
            this.tabPage1.Controls.Add(this.dtpVenc_Add);
            this.tabPage1.Controls.Add(this.btnAñadir);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtValor_Add);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtNombre_Add);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Size = new System.Drawing.Size(1123, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Añadir";
            // 
            // rtxtDescripcion_Add
            // 
            this.rtxtDescripcion_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescripcion_Add.Location = new System.Drawing.Point(218, 96);
            this.rtxtDescripcion_Add.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rtxtDescripcion_Add.Name = "rtxtDescripcion_Add";
            this.rtxtDescripcion_Add.Size = new System.Drawing.Size(242, 93);
            this.rtxtDescripcion_Add.TabIndex = 18;
            this.rtxtDescripcion_Add.Text = "";
            // 
            // dtpElab_Add
            // 
            this.dtpElab_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpElab_Add.Location = new System.Drawing.Point(746, 94);
            this.dtpElab_Add.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpElab_Add.Name = "dtpElab_Add";
            this.dtpElab_Add.Size = new System.Drawing.Size(338, 34);
            this.dtpElab_Add.TabIndex = 16;
            // 
            // dtpVenc_Add
            // 
            this.dtpVenc_Add.CustomFormat = "";
            this.dtpVenc_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVenc_Add.Location = new System.Drawing.Point(746, 35);
            this.dtpVenc_Add.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpVenc_Add.Name = "dtpVenc_Add";
            this.dtpVenc_Add.Size = new System.Drawing.Size(338, 34);
            this.dtpVenc_Add.TabIndex = 15;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold);
            this.btnAñadir.Location = new System.Drawing.Point(665, 210);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(196, 52);
            this.btnAñadir.TabIndex = 14;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(486, 35);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(236, 29);
            this.label15.TabIndex = 8;
            this.label15.Text = "Fecha Vencimiento";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(490, 94);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(232, 29);
            this.label14.TabIndex = 6;
            this.label14.Text = "Fecha Elaboración";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(112, 220);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 29);
            this.label13.TabIndex = 4;
            this.label13.Text = "Valor";
            // 
            // txtValor_Add
            // 
            this.txtValor_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor_Add.Location = new System.Drawing.Point(218, 220);
            this.txtValor_Add.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtValor_Add.Name = "txtValor_Add";
            this.txtValor_Add.Size = new System.Drawing.Size(242, 34);
            this.txtValor_Add.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(33, 100);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 29);
            this.label12.TabIndex = 2;
            this.label12.Text = "Descripción";
            // 
            // txtNombre_Add
            // 
            this.txtNombre_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre_Add.Location = new System.Drawing.Point(218, 35);
            this.txtNombre_Add.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNombre_Add.Name = "txtNombre_Add";
            this.txtNombre_Add.Size = new System.Drawing.Size(242, 34);
            this.txtNombre_Add.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(79, 35);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 29);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nombre";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtId_Mod);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnBuscar);
            this.tabPage2.Controls.Add(this.dtpElab_Mod);
            this.tabPage2.Controls.Add(this.dtpVenc_Mod);
            this.tabPage2.Controls.Add(this.rtxtDesc_Mod);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtValor_Mod);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtNombre_Mod);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnModificar);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Size = new System.Drawing.Size(1123, 282);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(665, 209);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(196, 52);
            this.btnBuscar.TabIndex = 44;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpElab_Mod
            // 
            this.dtpElab_Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpElab_Mod.Location = new System.Drawing.Point(746, 94);
            this.dtpElab_Mod.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpElab_Mod.Name = "dtpElab_Mod";
            this.dtpElab_Mod.Size = new System.Drawing.Size(338, 34);
            this.dtpElab_Mod.TabIndex = 43;
            // 
            // dtpVenc_Mod
            // 
            this.dtpVenc_Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVenc_Mod.Location = new System.Drawing.Point(746, 28);
            this.dtpVenc_Mod.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpVenc_Mod.Name = "dtpVenc_Mod";
            this.dtpVenc_Mod.Size = new System.Drawing.Size(338, 34);
            this.dtpVenc_Mod.TabIndex = 42;
            // 
            // rtxtDesc_Mod
            // 
            this.rtxtDesc_Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDesc_Mod.Location = new System.Drawing.Point(235, 98);
            this.rtxtDesc_Mod.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rtxtDesc_Mod.Name = "rtxtDesc_Mod";
            this.rtxtDesc_Mod.Size = new System.Drawing.Size(242, 93);
            this.rtxtDesc_Mod.TabIndex = 41;
            this.rtxtDesc_Mod.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(499, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "Fecha Vencimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(502, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "Fecha Elaboración";
            // 
            // txtValor_Mod
            // 
            this.txtValor_Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor_Mod.Location = new System.Drawing.Point(235, 209);
            this.txtValor_Mod.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtValor_Mod.Name = "txtValor_Mod";
            this.txtValor_Mod.Size = new System.Drawing.Size(242, 34);
            this.txtValor_Mod.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(119, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(42, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "Descripción";
            // 
            // txtNombre_Mod
            // 
            this.txtNombre_Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre_Mod.Location = new System.Drawing.Point(235, 33);
            this.txtNombre_Mod.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNombre_Mod.Name = "txtNombre_Mod";
            this.txtNombre_Mod.Size = new System.Drawing.Size(242, 34);
            this.txtNombre_Mod.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(86, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 29);
            this.label5.TabIndex = 31;
            this.label5.Text = "Nombre";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Location = new System.Drawing.Point(888, 209);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(196, 52);
            this.btnModificar.TabIndex = 29;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnEliminar);
            this.tabPage3.Controls.Add(this.txtId_Del);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage3.Size = new System.Drawing.Size(1123, 282);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(416, 175);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(196, 52);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtId_Del
            // 
            this.txtId_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_Del.Location = new System.Drawing.Point(532, 96);
            this.txtId_Del.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtId_Del.Name = "txtId_Del";
            this.txtId_Del.Size = new System.Drawing.Size(242, 34);
            this.txtId_Del.TabIndex = 3;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(303, 100);
            this.label25.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(150, 29);
            this.label25.TabIndex = 2;
            this.label25.Text = "ID Producto";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(986, 22);
            this.button5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 44);
            this.button5.TabIndex = 9;
            this.button5.Text = "Atrás";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblRubro.Location = new System.Drawing.Point(638, 151);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(84, 29);
            this.lblRubro.TabIndex = 19;
            this.lblRubro.Text = "Rubro";
            // 
            // cbxRubro_Add
            // 
            this.cbxRubro_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F);
            this.cbxRubro_Add.FormattingEnabled = true;
            this.cbxRubro_Add.Items.AddRange(new object[] {
            "Alimentos",
            "Electronica",
            "Linea Blanca",
            "Ropa"});
            this.cbxRubro_Add.Location = new System.Drawing.Point(746, 155);
            this.cbxRubro_Add.Name = "cbxRubro_Add";
            this.cbxRubro_Add.Size = new System.Drawing.Size(338, 37);
            this.cbxRubro_Add.TabIndex = 20;
            this.cbxRubro_Add.SelectedIndexChanged += new System.EventHandler(this.cbxRubro_Add_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(579, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 29);
            this.label6.TabIndex = 45;
            this.label6.Text = "Id Producto";
            // 
            // txtId_Mod
            // 
            this.txtId_Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F);
            this.txtId_Mod.Location = new System.Drawing.Point(746, 155);
            this.txtId_Mod.Name = "txtId_Mod";
            this.txtId_Mod.Size = new System.Drawing.Size(338, 34);
            this.txtId_Mod.TabIndex = 46;
            // 
            // lblRubro_Mod
            // 
            this.lblRubro_Mod.AutoSize = true;
            this.lblRubro_Mod.Location = new System.Drawing.Point(19, 3);
            this.lblRubro_Mod.Name = "lblRubro_Mod";
            this.lblRubro_Mod.Size = new System.Drawing.Size(64, 25);
            this.lblRubro_Mod.TabIndex = 10;
            this.lblRubro_Mod.Text = "Rubro";
            this.lblRubro_Mod.Visible = false;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MisOfertasDesktop.Properties.Resources.background_colores_colors_degradado_Favim_com_5139531;
            this.ClientSize = new System.Drawing.Size(1175, 740);
            this.Controls.Add(this.lblRubro_Mod);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dtgProducto);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgProducto;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtValor_Add;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNombre_Add;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtId_Del;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RichTextBox rtxtDescripcion_Add;
        private System.Windows.Forms.DateTimePicker dtpElab_Add;
        private System.Windows.Forms.DateTimePicker dtpVenc_Add;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpElab_Mod;
        private System.Windows.Forms.DateTimePicker dtpVenc_Mod;
        private System.Windows.Forms.RichTextBox rtxtDesc_Mod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor_Mod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre_Mod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cbxRubro_Add;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.TextBox txtId_Mod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRubro_Mod;
    }
}