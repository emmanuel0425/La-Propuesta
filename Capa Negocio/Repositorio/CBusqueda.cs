using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio.Repositorio
{
    internal class CBusqueda
    {
        internal  DataTable SeleccionarSexo()
        {

            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            SqlConnection coneccion = new SqlConnection(CConexion.Conectar());
            try
            {

                SqlCommand cmd = new SqlCommand("S_Sexo", coneccion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "S");

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];

            }
            catch (Exception error)
            {
                error.Message.ToString();
            }
            finally
            {
                coneccion.Close();
            }

            return datatable;

        }


        internal DataTable SeleccionarEstadoCivil()
        {
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            SqlConnection coneccion = new SqlConnection(CConexion.Conectar());
            try
            {

                SqlCommand cmd = new SqlCommand("S_EstadoCivil", coneccion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "S");

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];

            }
            catch (Exception error)
            {
                error.Message.ToString();
            }
            finally
            {
                coneccion.Close();
            }

            return datatable;

        }
 

        internal DataTable SeleccionarMunicipio(int Pro_ID)
        {
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            SqlConnection coneccion = new SqlConnection(CConexion.Conectar());
            try
            {

                SqlCommand cmd = new SqlCommand("S_Municipio", coneccion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "S");
                cmd.Parameters.AddWithValue("@Pro_ID", Pro_ID);

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];

            }
            catch (Exception error)
            {
                error.Message.ToString();
            }
            finally
            {
                coneccion.Close();
                
            }

            return datatable;
        }


        internal DataTable SeleccionarProvincia()
        {
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            SqlConnection coneccion = new SqlConnection(CConexion.Conectar());
            try
            {

                SqlCommand cmd = new SqlCommand("S_Provincia", coneccion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "S");
                

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];

            }
            catch (Exception error)
            {
                error.Message.ToString();
            }
            finally
            {
                coneccion.Close();
                
            }

            return datatable;
        }

        internal DataTable SeleccionarCargo()
        {

            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            SqlConnection coneccion = new SqlConnection(CConexion.Conectar());
            try
            {

                SqlCommand cmd = new SqlCommand("S_Cargo", coneccion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "S");

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];

            }
            catch (Exception error)
            {
                error.Message.ToString();
            }
            finally
            {
                coneccion.Close();
            }

            return datatable;

        }

        //This method here retreive all Employees from the database
        //This will be chaged later
        internal DataTable SeleccionarEmpleado()
        {

            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            SqlConnection coneccion = new SqlConnection(CConexion.Conectar());
            try
            {

                SqlCommand cmd = new SqlCommand("SIUD_Empleado", coneccion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Control", "S");
                //cmd.Parameters.AddWithValue("@Emp_ID", EmpID);

                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);
                datatable = dataset.Tables[0];

            }
            catch (Exception error)
            {
                error.Message.ToString();
            }
            finally
            {
                coneccion.Close();
            }

            return datatable;

        }




        /*  internal DataTable SeleccionarUsuario(string Usuario, string Contrasena, int Sub_Control, ref bool ResultadoOK, ref string MensajeError)
          {
              DataSet dataset = new DataSet();
              DataTable datatable = new DataTable();
              clConexion ObjConexion = new clConexion();
              SqlConnection coneccion = new SqlConnection(ObjConexion.Conectar());
              try
              {

                  SqlCommand cmd = new SqlCommand("Busqueda_Usuario", coneccion);
                  cmd.CommandType = CommandType.StoredProcedure;
                  cmd.Parameters.AddWithValue("@Control", "S");
                  cmd.Parameters.AddWithValue("@Sub_Control", Sub_Control);
                  cmd.Parameters.AddWithValue("@Usuario", Usuario);
                  cmd.Parameters.AddWithValue("@Contrasena", Contrasena);

                  SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                  SqlDa.Fill(dataset);
                  datatable = dataset.Tables[0];

                  ResultadoOK = true;
                  MensajeError = "";

              }
              catch (Exception error)
              {
                  ResultadoOK = false;
                  MensajeError = "No Encontrado" + error.Message.ToString();
              }
              finally
              {

                  coneccion.Close();
                  ObjConexion = null;
              }

              return datatable;
          }*/


    }

}
