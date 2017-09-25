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
            using (OracleConnection OraConn = Conectar())
            {
                OracleCommand OraCmd = new OracleCommand();
                OraCmd.Connection = OraConn;
                OraCmd.CommandText = "valid_user";
                OraCmd.CommandType = CommandType.StoredProcedure;
                OraCmd.Parameters.Add("p_correo", OracleDbType.Varchar2).Value = txt_user.Text;
                OraCmd.Parameters.Add("p_password", OracleDbType.Varchar2).Value = txt_pass.Text;
                OraCmd.Parameters.Add(new OracleParameter("p_message", OracleDbType.Varchar2)).Direction = ParameterDirection.Output;

                OraCmd.Parameters["p_message"].Size = 255;
                
                OraCmd.ExecuteNonQuery();
                
                object mensaje = OraCmd.Parameters["p_message"].Value;

                if (mensaje.ToString() == "CORRECTO")
                {
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario incorrecto", "Aviso");
                }
            }

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

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
