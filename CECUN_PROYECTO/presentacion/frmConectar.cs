using CECUN_PROYECTO.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CECUN_PROYECTO.presentacion
{
    public partial class frmConectar : Form
    {
        public frmConectar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon = Conexion.crearInstancia().CrearConexion();

            try
            {
                sqlCon.Open();
                MessageBox.Show("Conexion Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conexion Fallida");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
