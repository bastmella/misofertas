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
    public partial class Productos : Form
    {
        private void Datos()
        {
            OracleDataAdapter objAdapter = new OracleDataAdapter();
            DataTable dt = new DataTable();
            OracleCommand objSelectCmd = new OracleCommand();
            using (OracleConnection cnn = Conectar())
            {
                objSelectCmd.Connection = cnn;
                objSelectCmd.CommandText = "MantenedorProd.Cargar_Datos_DGV";
                objSelectCmd.CommandType = CommandType.StoredProcedure;
                objSelectCmd.Parameters.Add("cursorDatos", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                objAdapter.SelectCommand = objSelectCmd;
                objAdapter.Fill(dt);
                dtgProducto.DataSource = dt;
            }

        }

        public Productos()
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

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MenuEncargadoTienda menu = new MenuEncargadoTienda();
            menu.Show();
            this.Hide();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string nombre = Convert.ToString(txtNombre_Add.Text.Trim());
            string descripcion = Convert.ToString(rtxtDescripcion_Add.Text.Trim());
            string valor = Convert.ToString(txtValor_Add.Text.Trim());
            string venc = Convert.ToString(dtpVenc_Add.Text.Trim());
            string elab = Convert.ToString(dtpElab_Add.Text.Trim());
            string rubro = Convert.ToString(cbxRubro_Add.Text.Trim());

            if ((string.IsNullOrEmpty(nombre)) || (string.IsNullOrEmpty(descripcion) || (string.IsNullOrEmpty(valor)) || (string.IsNullOrEmpty(venc)) || (string.IsNullOrEmpty(elab))))
            {
                MessageBox.Show("Favor especificar todos los campos");
                return;
            }

            OracleDataAdapter OraAdap = new OracleDataAdapter();
            DataTable dt = new DataTable();
            OracleCommand OraCmd = new OracleCommand();
            using (OracleConnection cnn = Conectar())
            {
                if (rubro == "Alimentos")
                {
                    OraCmd.Connection = cnn;
                    OraCmd.CommandText = "MantenedorProd.insert_DatosA";
                    OraCmd.CommandType = CommandType.StoredProcedure;
                    OraCmd.Parameters.Add("p_nombre", OracleDbType.Varchar2, 50).Value = nombre;
                    OraCmd.Parameters.Add("p_descripcion", OracleDbType.Varchar2, 50).Value = descripcion;
                    OraCmd.Parameters.Add("p_valor", OracleDbType.Varchar2, 50).Value = valor;
                    OraCmd.Parameters.Add("p_venc", OracleDbType.Date).Value = DateTime.Parse(venc);
                    OraCmd.Parameters.Add("p_elab", OracleDbType.Date).Value = DateTime.Parse(elab);
                    OraCmd.Parameters.Add("p_rubro", OracleDbType.Varchar2).Value = 1;

                    try
                    {
                        OraCmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    OraCmd.Connection = cnn;
                    OraCmd.CommandText = "MantenedorProd.insert_DatosG";
                    OraCmd.CommandType = CommandType.StoredProcedure;
                    OraCmd.Parameters.Add("p_nombre", OracleDbType.Varchar2, 50).Value = nombre;
                    OraCmd.Parameters.Add("p_descripcion", OracleDbType.Varchar2, 50).Value = descripcion;
                    OraCmd.Parameters.Add("p_valor", OracleDbType.Varchar2, 50).Value = valor;
                    if (rubro == "Electronica")
                    {
                        OraCmd.Parameters.Add("p_rubro", OracleDbType.Varchar2).Value = 2;
                    }
                    else if (rubro == "Linea Blanca")
                    {
                        OraCmd.Parameters.Add("p_rubro", OracleDbType.Varchar2).Value = 3;
                    }
                    else if (rubro == "Ropa")
                    {
                        OraCmd.Parameters.Add("p_rubro", OracleDbType.Varchar2).Value = 4;
                    }

                    try
                    {
                        OraCmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                Datos();
            }
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            dtpElab_Add.Format = DateTimePickerFormat.Custom;
            dtpElab_Add.CustomFormat = "dd/MM/yy";
            dtpVenc_Add.Format = DateTimePickerFormat.Custom;
            dtpVenc_Add.CustomFormat = "dd/MM/yy";
        }

        private void cbxRubro_Add_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRubro_Add.SelectedItem.ToString() == "Alimentos")
            {
                dtpElab_Add.Enabled = true;
                dtpVenc_Add.Enabled = true;
            }
            else
            {
                dtpElab_Add.Enabled = false;
                dtpVenc_Add.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (OracleConnection OraConn = Conectar())
            {
                OracleCommand OraCmd = new OracleCommand();
                OraCmd.Connection = OraConn;
                OraCmd.CommandText = "MantenedorProd.ObtenerCampos";
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
                            txtValor_Mod.Text = Convert.ToString(dr["VALOR"]);
                            rtxtDesc_Mod.Text = Convert.ToString(dr["DESCRIPCION"]);
                            dtpElab_Mod.Text = Convert.ToString(dr["FECHA_ELABORACION"]);
                            dtpVenc_Mod.Text = Convert.ToString(dr["FECHA_VENCIMIENTO"]);
                            lblRubro_Mod.Text = Convert.ToString(dr["ID_RUBRO"]);
                            if (lblRubro_Mod.Text == "1")
                            {
                                dtpElab_Mod.Enabled = true;
                                dtpVenc_Mod.Enabled = true;
                            }
                            else
                            {
                                dtpElab_Mod.Enabled = false;
                                dtpVenc_Mod.Enabled = false;
                            }
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
            string descripcion = Convert.ToString(rtxtDesc_Mod.Text.Trim());
            string valor = Convert.ToString(txtValor_Mod.Text.Trim());
            string venc = Convert.ToString(dtpVenc_Mod.Text.Trim());
            string elab = Convert.ToString(dtpElab_Mod.Text.Trim());
            string rubro = Convert.ToString(lblRubro_Mod.Text.Trim());

            if ((string.IsNullOrEmpty(nombre)) || (string.IsNullOrEmpty(descripcion) || (string.IsNullOrEmpty(valor)) || (string.IsNullOrEmpty(venc)) || (string.IsNullOrEmpty(elab))))
            {
                MessageBox.Show("Favor especificar todos los campos");
                return;
            }

            OracleDataAdapter OraAdap = new OracleDataAdapter();
            DataTable dt = new DataTable();
            OracleCommand OraCmd = new OracleCommand();

            using (OracleConnection cnn = Conectar())
            {
                if (rubro == "1")
                {
                    OraCmd.Connection = cnn;
                    OraCmd.CommandText = "MantenedorProd.update_DatosA";
                    OraCmd.CommandType = CommandType.StoredProcedure;
                    OraCmd.Parameters.Add("p_id", OracleDbType.Varchar2, 50).Value = id;
                    OraCmd.Parameters.Add("p_nombre", OracleDbType.Varchar2, 50).Value = nombre;
                    OraCmd.Parameters.Add("p_descripcion", OracleDbType.Varchar2, 50).Value = descripcion;
                    OraCmd.Parameters.Add("p_valor", OracleDbType.Varchar2, 50).Value = valor;
                    OraCmd.Parameters.Add("p_venc", OracleDbType.Date).Value = DateTime.Parse(venc);
                    OraCmd.Parameters.Add("p_elab", OracleDbType.Date).Value = DateTime.Parse(elab);
                    try
                    {
                        OraCmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    OraCmd.Connection = cnn;
                    OraCmd.CommandText = "MantenedorProd.update_DatosG";
                    OraCmd.CommandType = CommandType.StoredProcedure;
                    OraCmd.Parameters.Add("p_id", OracleDbType.Varchar2, 50).Value = id;
                    OraCmd.Parameters.Add("p_nombre", OracleDbType.Varchar2, 50).Value = nombre;
                    OraCmd.Parameters.Add("p_descripcion", OracleDbType.Varchar2, 50).Value = descripcion;
                    OraCmd.Parameters.Add("p_valor", OracleDbType.Varchar2, 50).Value = valor;

                    try
                    {
                        OraCmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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
                OraCmd.CommandText = "MantenedorProd.delete_Datos";
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

