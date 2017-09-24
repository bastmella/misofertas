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

        private OracleConnection Conectar()
        {
            string CadenaConexion = ConfigurationManager.ConnectionStrings["MisOfertasDesktop.Properties.Settings.ConnectionString"].ConnectionString;
            CadenaConexion = string.Format(CadenaConexion, "BDMISOFERTAS", "bsam123");
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = CadenaConexion;
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return conn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Conectar();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "valid_user";
            cmd.BindByName = true;

            string user_t = Convert.ToString(txt_user.Text.Trim());
            string pass_t = Convert.ToString(txt_pass.Text.Trim());

            cmd.Parameters.Add(new OracleParameter("p_correo", OracleDbType.Varchar2)).Value = user_t;
            cmd.Parameters.Add(new OracleParameter("p_password", OracleDbType.Varchar2)).Value = pass_t;

            try
            {
                cmd.ExecuteNonQuery();
                if (cmd.Parameters.)
                {

                }
            }
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
