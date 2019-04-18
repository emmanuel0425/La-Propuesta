using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio.Logica;
using Capa_Negocio.Repositorio;
using Capa_Negocio;
using System.Data.SqlClient;
using System.Data.Sql;
 

namespace Capa_Presentacion
{
    public partial class Registro_Empleados : Form
    {
        //SqlDataAdapter SqlDa;
        //SqlCommandBuilder SqlCb;
        //DataTable dt;
        //SqlConnection con;


        public Registro_Empleados()
        {
            InitializeComponent();
        }
        //objBusqueda = new CBusqueda();
        CProvincia provincia = new CProvincia();
        CMunicipio municipio = new CMunicipio();
        CSexo sexo = new CSexo();
        CEstadoCivil estadocivil = new CEstadoCivil();
        CCargo cargo = new CCargo();
        
        
        private void Registro_Empleados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyecto_FinalDataSet.Empleado' table. You can move, or remove it, as needed.
            //this.empleadoTableAdapter.Fill(this.proyecto_FinalDataSet.Empleado);
            //CBEmpleadoSexo.DataSource = objBusqueda.SeleccionarSexo();
            CBEmpleadoProvincia.DataSource = provincia.SeleccionarProvincia();
            provincia.ID = Convert.ToInt32(CBEmpleadoProvincia.SelectedValue);
            CBEmpleadoMunicipio.DataSource = municipio.SeleccionarMunicipio(provincia.ID);
           // sexo.Sexo_ID = Convert.ToInt32(CBEmpleadoSexo.SelectedValue);
            CBEmpleadoSexo.DataSource = sexo.SeleccionarSexo();
            CBEmpleadoEstadoCivil.DataSource = estadocivil.SeleccionarEstadoCivil();
            CBCargo.DataSource = cargo.SeleccionarCargo();

            //CBEmpleadoMunicipio.DataSource = municipio.SeleccionarMunicipio();
            //this.empleadoTableAdapter.Fill(this.proyecto_FinalDataSet.Empleado);
        }

        void Load_Municipio()
        {
            provincia.ID = Convert.ToInt32(CBEmpleadoProvincia.SelectedValue);
            CBEmpleadoMunicipio.DataSource = municipio.SeleccionarMunicipio(provincia.ID);
        }

       void Load_Sexo()
        {
            //sexo.Sexo_ID = Convert.ToInt32(CBEmpleadoSexo.SelectedValue);
            //CBEmpleadoSexo.DataSource = sexo.SeleccionarSexo();
        }



        public void Registrar()
        {
            CEmpleado objEmpleado = new CEmpleado();

            string MensajeError = "";
            bool ResultadoOK = true;

            objEmpleado.Nombres = TBEmpleadoNombres.Text.ToString();
            objEmpleado.Apellidos = TBEmpleadoApellidos.Text.ToString();
            objEmpleado.Telefono = TBTelefono.Text.ToString();
            objEmpleado.Celular = TBCelular.Text.ToString();
            objEmpleado.Cedula = TBCedula.Text.ToString();
            objEmpleado.Direccion = TBEmpleadoCalle.Text.ToString();
            objEmpleado.Email = TBEmpleadoEmail.Text.ToString();
            objEmpleado.Sector = TBSector.Text.ToString();
            objEmpleado.FechaNac = Convert.ToDateTime(DTPFechaNac.Text);
            if (CHBActivo.Checked)
            {
                objEmpleado.Activo = true;
                    }
            else
            {
                objEmpleado.Activo = false;
            }
            objEmpleado.Municipio_ID = Convert.ToInt32(CBEmpleadoMunicipio.SelectedValue); // It must be obtained from the database using a DataTable
            objEmpleado.Sexo_ID = (int) CBEmpleadoSexo.SelectedValue;
            objEmpleado.EstadoC_ID = (int) CBEmpleadoEstadoCivil.SelectedValue;
            objEmpleado.Cargo_ID = (int)CBCargo.SelectedValue;
            objEmpleado.Registrar(objEmpleado, ref ResultadoOK, ref MensajeError);

            if (ResultadoOK == true)
            {
                MessageBox.Show(objEmpleado.Empleado_ID.ToString() + "Guardado Exitosamente.");
            }
            else
            {
                MessageBox.Show(MensajeError);
            }

           
        }

        private void CBEmpleadoProvincia_SelectedIndexChanged(object sender, EventArgs e)

        {
            Load_Municipio();
        }

        private void CBEmpleadoSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Sexo();
        }



        private void BtnEmpleadoAgregarRegistro_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        private void BtnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            //using (SqlConnection con = new SqlConnection(CConexion.Conectar()))
            //    con.Open();
            //SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Empleado", con);
            //DataTable dataTable = new DataTable();
            //sqlDa.Fill(dataTable);

            //DGVEmpleado.DataSource = dataTable;

            //SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = Proyecto Final; Integrated Security = True;");
            //SqlDa = new SqlDataAdapter("SELECT * FROM Empleado", con);
            //dt = new DataTable();
            //SqlDa.Fill(dt);
            //DGVEmpleado.DataSource = dt;

        //    Cursor.Current = Cursors.WaitCursor;

        //    try
        //    {
        //        empleadoBindingSource.EndEdit();
        //        empleadoTableAdapter.Update(this.proyecto_FinalDataSet.Empleado);
        //        MessageBox.Show("El empleado ha sido agregado exitosamente.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //    Cursor.Current = Cursors.Default;
        //}

        //private void DGVEmpleado_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Delete)
        //    {
        //        if (MessageBox.Show("Realmente desea eliminar este registro?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //            empleadoBindingSource.RemoveCurrent();
        //    }
                
        }
    }
}
