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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_mantenedor_Click(object sender, EventArgs e)
        {
            Mantenedores mant = new Mantenedores();
            mant.Show();
            this.Hide();
        }

        private void btn_ofertas_Click(object sender, EventArgs e)
        {
            Ofertas ofer = new Ofertas();
            ofer.Show();
            this.Hide();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
