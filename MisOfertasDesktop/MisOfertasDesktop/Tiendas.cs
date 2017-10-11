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
    public partial class Tiendas : Form
    {
        private void Datos()
        {
            OracleDataAdapter objAdapter = new OracleDataAdapter();
            DataTable dt = new DataTable();
            OracleCommand objSelectCmd = new OracleCommand();
            using (OracleConnection cnn = Conectar())
            {
                objSelectCmd.Connection = cnn;
                objSelectCmd.CommandText = "MantenedorTienda.Cargar_Datos_DGV";
                objSelectCmd.CommandType = CommandType.StoredProcedure;
                objSelectCmd.Parameters.Add("cursorDatos", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                objAdapter.SelectCommand = objSelectCmd;
                objAdapter.Fill(dt);
                dtgTienda.DataSource = dt;
            }

        }
        public Tiendas()
        {
            InitializeComponent();
            Datos();
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

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdministradorMantenedores mantenedor = new AdministradorMantenedores();
            mantenedor.Show();
            this.Hide();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string nombre = Convert.ToString(txtNombre_Add.Text.Trim());
            string direccion = Convert.ToString(txtDireccion_Add.Text.Trim());
            string fono = Convert.ToString(txtFono_Add.Text.Trim());

            if ((string.IsNullOrEmpty(nombre)) || (string.IsNullOrEmpty(direccion)) || (string.IsNullOrEmpty(fono)))
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
                OraCmd.CommandText = "MantenedorTienda.insert_Datos";
                OraCmd.CommandType = CommandType.StoredProcedure;
                OraCmd.Parameters.Add("p_nombre", OracleDbType.Varchar2, 50).Value = nombre;
                OraCmd.Parameters.Add("p_direccion", OracleDbType.Varchar2, 50).Value = direccion;
                OraCmd.Parameters.Add("p_fono", OracleDbType.Varchar2, 50).Value = fono;
                OraCmd.Parameters.Add("p_rut", OracleDbType.Varchar2, 50).Value = "79.859.690-K";

                try
                {
                    OraCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Datos();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (OracleConnection OraConn = Conectar())
            {
                OracleCommand OraCmd = new OracleCommand();
                OraCmd.Connection = OraConn;
                OraCmd.CommandText = "MantenedorTienda.ObtenerCampos";
                OraCmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    OraCmd.Parameters.Add("p_id", OracleDbType.Varchar2).Value = txtId_Mod.Text;
                    OraCmd.Parameters.Add(new OracleParameter("cursorObtener", OracleDbType.RefCursor)).Direction = ParameterDirection.Output;

                    OracleDataReader dr = OraCmd.ExecuteReader();
                    OraCmd.ExecuteNonQuery();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            txtNombre_Mod.Text = Convert.ToString(dr["NOMBRE"]);
                            txtDireccion_Mod.Text = Convert.ToString(dr["DIRECCION"]);
                            txtFono_Mod.Text = Convert.ToString(dr["FONO"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(txtId_Mod.Text.Trim());
            string nombre = Convert.ToString(txtNombre_Mod.Text.Trim());
            string direccion = Convert.ToString(txtDireccion_Mod.Text.Trim());
            string fono = Convert.ToString(txtFono_Mod.Text.Trim());

            if ((string.IsNullOrEmpty(nombre)) || (string.IsNullOrEmpty(direccion) || (string.IsNullOrEmpty(fono))))
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
                OraCmd.CommandText = "MantenedorTienda.update_Datos";
                OraCmd.CommandType = CommandType.StoredProcedure;
                OraCmd.Parameters.Add("p_id", OracleDbType.Varchar2, 50).Value = id;
                OraCmd.Parameters.Add("p_nombre", OracleDbType.Varchar2, 50).Value = nombre;
                OraCmd.Parameters.Add("p_direccion", OracleDbType.Varchar2, 50).Value = direccion;
                OraCmd.Parameters.Add("p_fono", OracleDbType.Varchar2, 50).Value = fono;
                try
                {
                    OraCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Datos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(txtId_Del.Text.Trim());

            if ((string.IsNullOrEmpty(id)))
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
                OraCmd.CommandText = "MantenedorTienda.delete_Datos";
                OraCmd.CommandType = CommandType.StoredProcedure;
                OraCmd.Parameters.Add("p_id", OracleDbType.Varchar2, 10).Value = id;
                try
                {
                    OraCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Datos();
            }
        }
    }
}
