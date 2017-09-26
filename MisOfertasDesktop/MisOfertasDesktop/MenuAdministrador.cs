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
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ReporteAdministrador reporte = new ReporteAdministrador();
            reporte.Show();
            this.Hide();
        }

        private void btnMantenedores_Click(object sender, EventArgs e)
        {
            AdministradorMantenedores mantenedores = new AdministradorMantenedores();
            mantenedores.Show();
            this.Hide();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
