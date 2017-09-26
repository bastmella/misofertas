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
    public partial class ReporteEncargadoTienda : Form
    {
        public ReporteEncargadoTienda()
        {
            InitializeComponent();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            MenuEncargadoTienda menu = new MenuEncargadoTienda();
            menu.Show();
            this.Hide();
        }
    }
}
