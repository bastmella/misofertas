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
    public partial class Empresas : Form
    {
        public Empresas()
        {
            InitializeComponent();
        }

        private void Empresas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dt_empresas.EMPRESA' Puede moverla o quitarla según sea necesario.
            this.eMPRESATableAdapter.Fill(this.dt_empresas.EMPRESA);

        }
    }
}
