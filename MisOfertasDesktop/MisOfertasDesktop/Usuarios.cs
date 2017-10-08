﻿using System;
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


        private void textBox13_TextChanged(object sender, EventArgs e)
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
                
                /*try
                {*/
                    OraCmd.Parameters.Add("p_rut", OracleDbType.Varchar2).Value = txt_rut.Text;
                    OraCmd2.Parameters.Add("p_rut", OracleDbType.Varchar2).Value = txt_rut.Text;
                    OraCmd.Parameters.Add("P_password", OracleDbType.Varchar2).Value = txt_pass.Text;
                    OraCmd.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = txt_nombre.Text;
                    OraCmd.Parameters.Add("p_apellido", OracleDbType.Varchar2).Value = txt_apellido.Text;
                    OraCmd.Parameters.Add("p_correo", OracleDbType.Varchar2).Value = txt_correo.Text;
                    OraCmd2.Parameters.Add("p_correo", OracleDbType.Varchar2).Value = txt_correo.Text;
                    OraCmd.Parameters.Add("p_fono", OracleDbType.Int32).Value = txt_fono.Text;
                    OraCmd.Parameters.Add("p_direccion", OracleDbType.Varchar2).Value = txt_direccion.Text;
                    OraCmd.Parameters.Add("p_fecha_registro", DateTime.Now);
                    OraCmd.Parameters.Add("p_ultimo_acceso", DateTime.Now);
                    OraCmd.Parameters.Add("p_rol", OracleDbType.Varchar2).Value = cbxRol.Text;
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
                /*}catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }*/

                
            }

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
