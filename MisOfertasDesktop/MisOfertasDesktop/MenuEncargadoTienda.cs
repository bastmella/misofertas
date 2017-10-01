using System;
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
    public partial class MenuEncargadoTienda : Form
    {
        public MenuEncargadoTienda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ofertas menu = new Ofertas();
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Productos menu = new Productos();
            menu.Show();
            this.Hide();
        }

        private void MenuEncargadoTienda_Load(object sender, EventArgs e)
        {

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ReporteEncargadoTienda reporte = new ReporteEncargadoTienda();
            reporte.Show();
            this.Hide();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos menu = new Productos();
            menu.Show();
            this.Hide();
        }

        private void ofertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ofertas menu = new Ofertas();
            menu.Show();
            this.Hide();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void valoraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteEncargadoTienda reporte = new ReporteEncargadoTienda();
            reporte.Show();
            this.Hide();
        }
    }
}
