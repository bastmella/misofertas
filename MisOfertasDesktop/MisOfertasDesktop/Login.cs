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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txt_user_Click(object sender, EventArgs e)
        {
            txt_user.Text = "";
        }

        private void txt_pass_Click(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = true;
            txt_pass.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
