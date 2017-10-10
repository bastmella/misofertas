using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Oracle.DataAccess.Client;

namespace MisOfertasDesktop
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private OracleConnection Conectar()
        {
            string CadenaConexion = ConfigurationManager.ConnectionStrings["MisOfertas"].ConnectionString;
            CadenaConexion = string.Format(CadenaConexion, "MisOfertas", "bsam123");
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


        private void button5_Click(object sender, EventArgs e)
        {
            AdministradorMantenedores mantenedor = new AdministradorMantenedores();
            mantenedor.Show();
            this.Hide();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            using (OracleConnection OraConn = Conectar())
            {
                OracleCommand OraCmd = new OracleCommand();
                OracleCommand OraCmd2 = new OracleCommand();
                OraCmd.Connection = OraConn;
                OraCmd2.Connection = OraConn;
                OraCmd.CommandText = "add_user";
                OraCmd2.CommandText = "valid_exist";
                OraCmd.CommandType = CommandType.StoredProcedure;
                OraCmd2.CommandType = CommandType.StoredProcedure;

                try
                {
                    OraCmd.Parameters.Add("p_rut", OracleDbType.Varchar2).Value = txtRut_Add.Text;
                    OraCmd2.Parameters.Add("p_rut", OracleDbType.Varchar2).Value = txtRut_Add.Text;
                    OraCmd.Parameters.Add("P_password", OracleDbType.Varchar2).Value = txtPass_Add.Text;
                    OraCmd.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = txtNombre_Add.Text;
                    OraCmd.Parameters.Add("p_apellido", OracleDbType.Varchar2).Value = txtApellido_Add.Text;
                    OraCmd.Parameters.Add("p_correo", OracleDbType.Varchar2).Value = txtCorreo_Add.Text;
                    OraCmd2.Parameters.Add("p_correo", OracleDbType.Varchar2).Value = txtCorreo_Add.Text;
                    OraCmd.Parameters.Add("p_fono", OracleDbType.Int32).Value = txtFono_Add.Text;
                    OraCmd.Parameters.Add("p_direccion", OracleDbType.Varchar2).Value = txtDirecc_Add.Text;
                    OraCmd.Parameters.Add("p_fecha_registro", DateTime.Now);
                    OraCmd.Parameters.Add("p_ultimo_acceso", DateTime.Now);
                    OraCmd.Parameters.Add("p_rol", OracleDbType.Varchar2).Value = cbxRol_Add.Text;
                    OraCmd.Parameters.Add("p_puntos_acumulados", OracleDbType.Int32).Value = null;
                    OraCmd.Parameters.Add("p_rut_empresa_a_cargo", OracleDbType.Varchar2).Value = "79.859.690-K";
                    OraCmd2.Parameters.Add(new OracleParameter("p_message", OracleDbType.Varchar2)).Direction = ParameterDirection.Output;

                    OraCmd2.Parameters["p_message"].Size = 255;


                    OraCmd2.ExecuteNonQuery();

                    object mensaje = OraCmd2.Parameters["p_message"].Value;

                    if (mensaje.ToString() == "OK")
                    {
                        MessageBox.Show("Se ha ingresado correctamente un usuario", "Aviso");
                        OraCmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Usuario existe", "Aviso");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }

        }
        private void Datos()
        {
            OracleDataAdapter objAdapter = new OracleDataAdapter();
            DataTable dt = new DataTable();
            OracleCommand objSelectCmd = new OracleCommand();
            using (OracleConnection cnn = Conectar())
            {
                objSelectCmd.Connection = cnn;
                objSelectCmd.CommandText = "Mantenedor.Cargar_Datos_DGV";
                objSelectCmd.CommandType = CommandType.StoredProcedure;
                objSelectCmd.Parameters.Add("cursorDatos", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                objAdapter.SelectCommand = objSelectCmd;
                objAdapter.Fill(dt);
                dtgUsuario.DataSource = dt;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (OracleConnection OraConn = Conectar())
            {
                OracleCommand OraCmd = new OracleCommand();
                OraCmd.Connection = OraConn;
                OraCmd.CommandText = "Mantenedor.ObtenerCampos";
                OraCmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    OraCmd.Parameters.Add("p_rut", OracleDbType.Varchar2).Value = txtRut_Mod.Text;
                    OraCmd.Parameters.Add(new OracleParameter("cursorObtener", OracleDbType.RefCursor)).Direction = ParameterDirection.Output;

                    OracleDataReader dr = OraCmd.ExecuteReader();
                    OraCmd.ExecuteNonQuery();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            txtNombre_Mod.Text = Convert.ToString(dr["NOMBRE"]);
                            txtApellido_Mod.Text = Convert.ToString(dr["APELLIDO"]);
                            txtCorreo_Mod.Text = Convert.ToString(dr["CORREO"]);
                            txtFono_Mod.Text = Convert.ToString(dr["FONO"]);
                            txtDirecc_Mod.Text = Convert.ToString(dr["DIRECCION"]);
                            txtPass_Mod.Text = Convert.ToString(dr["PASSWORD"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bntModificar_Click(object sender, EventArgs e)
        {
            string rut = Convert.ToString(txtRut_Mod.Text.Trim());
            string nombre = Convert.ToString(txtNombre_Mod.Text.Trim());
            string apellido = Convert.ToString(txtApellido_Mod.Text.Trim());
            string correo = Convert.ToString(txtCorreo_Mod.Text.Trim());
            int fono = Convert.ToInt32(txtFono_Mod.Text.Trim());
            string direccion = Convert.ToString(txtDirecc_Mod.Text.Trim());
            string contraseña = Convert.ToString(txtPass_Mod.Text.Trim());
            if ((string.IsNullOrEmpty(rut)) || (string.IsNullOrEmpty(nombre) || (string.IsNullOrEmpty(apellido)) || (string.IsNullOrEmpty(correo)) || (string.IsNullOrEmpty(fono.ToString())) || (string.IsNullOrEmpty(direccion)) || (string.IsNullOrEmpty(contraseña))))
            {
                MessageBox.Show("Favor especificar todos los campos");
                return;
            }

            OracleDataAdapter OraAdap = new OracleDataAdapter();
            DataTable dt = new DataTable();
            OracleCommand OraCmd = new OracleCommand();

            using (OracleConnection cnn = Conectar())
            {
                OraCmd.Connection = cnn;
                OraCmd.CommandText = "Mantenedor.update_Datos";
                OraCmd.CommandType = CommandType.StoredProcedure;
                OraCmd.Parameters.Add("p_rut", OracleDbType.Varchar2, 10).Value = rut;
                OraCmd.Parameters.Add("p_nombre", OracleDbType.Varchar2, 50).Value = nombre;
                OraCmd.Parameters.Add("p_apellido", OracleDbType.Varchar2, 50).Value = apellido;
                OraCmd.Parameters.Add("p_correo", OracleDbType.Varchar2, 50).Value = correo;
                OraCmd.Parameters.Add("p_fono", OracleDbType.Int32, 8).Value = fono;
                OraCmd.Parameters.Add("p_direccion", OracleDbType.Varchar2, 50).Value = direccion;
                OraCmd.Parameters.Add("p_password", OracleDbType.Varchar2, 50).Value = contraseña;

                try
                {
                    OraCmd.ExecuteNonQuery();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Datos();
            }
        }
    }
}

