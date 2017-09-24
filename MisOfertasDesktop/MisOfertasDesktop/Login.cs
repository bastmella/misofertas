using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.OracleClient;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

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
            string oradb = ConfigurationManager.ConnectionStrings["MisOfertasDesktop.Properties.Settings.ConnectionString"].ConnectionString;
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = oradb;
            try
            {
                conn.Open();
                MessageBox.Show(conn.State.ToString());
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
            /*MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();*/
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
