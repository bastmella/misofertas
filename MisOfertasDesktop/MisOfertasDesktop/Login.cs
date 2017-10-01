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
using Oracle.DataAccess.Client;


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
            string CadenaConexion = ConfigurationManager.ConnectionStrings["MisOfertas"].ConnectionString;
            CadenaConexion = string.Format(CadenaConexion, "admin", "adminpass");
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
            if (txt_user.Text == "Usuario" || txt_pass.Text == "Contraseña")
            {
                MessageBox.Show("No deben quedar campos vacios");
            }
            else
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
                    OraCmd.Parameters.Add(new OracleParameter("p_rol", OracleDbType.Varchar2)).Direction = ParameterDirection.Output;



                    OraCmd.Parameters["p_message"].Size = 255;
                    OraCmd.Parameters["p_rol"].Size = 255;

                    OraCmd.ExecuteNonQuery();

                    object mensaje = OraCmd.Parameters["p_message"].Value;
                    object rol = OraCmd.Parameters["p_rol"].Value;



                    if (mensaje.ToString() == "CORRECTO")
                    {
                        if (rol.ToString() == "Administrador")
                        {
                            MenuAdministrador menu = new MenuAdministrador();
                            menu.Show();
                            this.Hide();
                        }
                        else if (rol.ToString() == "Encargado de tienda")
                        {
                            MenuEncargadoTienda menu = new MenuEncargadoTienda();
                            menu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Este Usuario no posee privilegios para acceder", "Aviso");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Usuario incorrecto", "Aviso");
                    }
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_user_Validated(object sender, EventArgs e)
        {
            if (txt_user.Text.Trim() == "Usuario")
            {
                epError.SetError(txt_user, "No puede quedar en blanco");
            }
            else
            {
                epError.Clear();
            }
        }

        private void txt_pass_Validated(object sender, EventArgs e)
        {
            if (txt_pass.Text.Trim() == "Contraseña")
            {
                epError.SetError(txt_pass, "No puede quedar en blanco");
            }
            else
            {
                epError.Clear();
            }
        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            if(txt_user.Text == "Usuario")
            {
                txt_user.Text = "";

                txt_user.ForeColor = Color.Black;
            }
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if(txt_user.Text == "")
            {
                txt_user.Text = "Usuario";
                txt_user.ForeColor = Color.LightGray;
            }
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Contraseña")
            {
                txt_pass.Text = "";

                txt_pass.ForeColor = Color.Black;
            }
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                txt_pass.Text = "Contraseña";
                txt_pass.ForeColor = Color.LightGray;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MenuAdministrador admin = new MenuAdministrador();
            admin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuEncargadoTienda encarg = new MenuEncargadoTienda();
            encarg.Show();
            this.Hide();
        }
    }
}
