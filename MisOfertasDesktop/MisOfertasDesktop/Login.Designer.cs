namespace MisOfertasDesktop
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.Location = new System.Drawing.Point(153, 234);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(163, 34);
            this.btn_ingresar.TabIndex = 2;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.SystemColors.Window;
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_pass.Location = new System.Drawing.Point(153, 163);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(164, 31);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.Text = "Contraseña";
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            this.txt_pass.Enter += new System.EventHandler(this.txt_pass_Enter);
            this.txt_pass.Leave += new System.EventHandler(this.txt_pass_Leave);
            this.txt_pass.Validated += new System.EventHandler(this.txt_pass_Validated);
            // 
            // txt_user
            // 
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_user.Location = new System.Drawing.Point(153, 103);
            this.txt_user.Margin = new System.Windows.Forms.Padding(2);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(164, 31);
            this.txt_user.TabIndex = 0;
            this.txt_user.Text = "Usuario";
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_user.Enter += new System.EventHandler(this.txt_user_Enter);
            this.txt_user.Leave += new System.EventHandler(this.txt_user_Leave);
            this.txt_user.Validated += new System.EventHandler(this.txt_user_Validated);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Admin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Encarg";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MisOfertasDesktop.Properties.Resources.rojoSinfo;
            this.pictureBox1.Location = new System.Drawing.Point(126, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 68);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::MisOfertasDesktop.Properties.Resources.background_colores_colors_degradado_Favim_com_5139531;
            this.ClientSize = new System.Drawing.Size(451, 355);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.txt_pass);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Autenticaión de usuario";
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

