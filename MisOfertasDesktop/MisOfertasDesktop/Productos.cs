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

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string nombre = Convert.ToString(txtNombre_Add.Text.Trim());
            string descripcion = Convert.ToString(rtxtDescripcion_Add.Text.Trim());
            string valor = Convert.ToString(txtValor_Add.Text.Trim());
            string venc = Convert.ToString(dtpVenc_Add.Text.Trim());
            string elab = Convert.ToString(dtpElab_Add.Text.Trim());
            
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
                OraCmd.Connection = cnn;
                OraCmd.CommandText = "MantenedorProd.insert_Datos";
                OraCmd.CommandType = CommandType.StoredProcedure;
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
    }
}
