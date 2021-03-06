﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisOfertasDesktop
{
    public partial class AdministradorMantenedores : Form
    {
        public AdministradorMantenedores()
        {
            InitializeComponent();
        }

        private void Mantenedores_Load(object sender, EventArgs e)
        {

        }

        private void btn_empresas_Click(object sender, EventArgs e)
        {
            Tiendas emp = new Tiendas();
            emp.Show();
            this.Hide();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            MenuAdministrador menu = new MenuAdministrador();
            menu.Show();
            this.Hide();
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            Usuarios usu = new Usuarios();
            usu.Show();
            this.Hide();
        }

        private void btn_descuentos_Click(object sender, EventArgs e)
        {
            Descuentos dcto = new Descuentos();
            dcto.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos prod = new Productos();
            prod.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
