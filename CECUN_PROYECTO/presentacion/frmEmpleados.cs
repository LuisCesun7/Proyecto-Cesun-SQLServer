using CECUN_PROYECTO.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CECUN_PROYECTO.presentacion
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        #region "Métodos"

        private void CargarEmpleados(string cBusqueda)
        {
            //MUESTRA LOS DATOS DE LA BD EN EL "DATA GRID VIEW
            D_Empleados Datos = new D_Empleados();
            dgvLista.DataSource = Datos.Listar_Empleados(cBusqueda);
            FormatoListaEmpleados();
        }

        private void FormatoListaEmpleados()
        {
            // Ancho de las columnas por numero de columna, ejemplo, id es la 1, nombre es la 2.
            dgvLista.Columns[0].Width = 45;
            dgvLista.Columns[1].Width = 160;
            dgvLista.Columns[2].Width = 160;
            // dgvLista.Columns[3].Width =
            // dgvLista.Columns[4].Width =
            dgvLista.Columns[5].Width = 250;
            // dgvLista.Columns[6].Width =
            dgvLista.Columns[7].Width = 160;

        }

        private void CargarDepartamentos()
        {
            D_Departamentos Datos = new D_Departamentos();
            cmbDepartamento.DataSource = Datos.Listar_Departamentos();
            cmbDepartamento.ValueMember = "id_departamento";
            cmbDepartamento.DisplayMember = "nombre_departamento";
            cmbDepartamento.SelectedIndex = -1;
            // La linea anteior es para que el ComboBox inicie sin ningun valor o dato
        }

        private void CargarCargos()
        {
            D_Cargos Datos = new D_Cargos();
            cmbCargo.DataSource = Datos.Listar_Cargos();
            cmbCargo.ValueMember = "id_cargo";
            cmbCargo.DisplayMember = "nombre_cargo";
            cmbCargo.SelectedIndex = -1;

        }

        #endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados("%");
            CargarDepartamentos();
            CargarCargos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarEmpleados(txtBuscar.Text);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            // SE PUEDE USAR EL MISMO METODO QUE CON EL BOTON DE "BUSCAR" PARA QUE
            // LO QUE SE VAYA ESCRIBIENDO EN LA CAJA DE TEXTO DE BUSCAR SE VAYAN FILTRANDO
            // EN LA TABLA
            // CargarEmpleados(txtBuscar.Text);
            // SE PUEDE USAR CUALQUIERA DE LOS 2 METODOS.
        }
    }
}
