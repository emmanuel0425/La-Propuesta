﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Negocio;
using Capa_Negocio.Logica;

namespace Capa_Datos
{
    public class CRegistro
    {

        public void Registrar(CEmpleado objEmpleado, ref bool ResultadoOk, ref string MensajeError)
        {
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            SqlConnection con = new SqlConnection(CConexion.Conectar());

            try
            {
                SqlCommand cmd = new SqlCommand("SIUD_Empleado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (objEmpleado.Empleado_ID == 0)
                {
                    cmd.Parameters.AddWithValue("@Control", "I");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Control", "U");
                    cmd.Parameters.AddWithValue("@Emp_ID", objEmpleado.Empleado_ID);
                }

                cmd.Parameters.AddWithValue("@Emp_Nombres", objEmpleado.Nombres);
                cmd.Parameters.AddWithValue("@Emp_Apellidos", objEmpleado.Apellidos);
                cmd.Parameters.AddWithValue("@Emp_Telefono", objEmpleado.Telefono);
                cmd.Parameters.AddWithValue("@Emp_Celular", objEmpleado.Celular);
                cmd.Parameters.AddWithValue("@Emp_Email", objEmpleado.Email);
                cmd.Parameters.AddWithValue("@Emp_Cedula", objEmpleado.Cedula);
                cmd.Parameters.AddWithValue("@Sexo_ID", objEmpleado.Sexo_ID);
                cmd.Parameters.AddWithValue("@Emp_FechaNac", objEmpleado.FechaNac);
                cmd.Parameters.AddWithValue("@EstadoC_ID", objEmpleado.EstadoC_ID);
                cmd.Parameters.AddWithValue("@Emp_Direccion", objEmpleado.Direccion);
                cmd.Parameters.AddWithValue("@Emp_Activo", objEmpleado.Activo);
                cmd.Parameters.AddWithValue("@ProvinciaID", objEmpleado.Provincia_ID);
                cmd.Parameters.AddWithValue("@Cargo_ID", objEmpleado.Cargo_ID);
                SqlDataAdapter SqlDa = new SqlDataAdapter(cmd);
                SqlDa.Fill(dataset);

                if (objEmpleado.Empleado_ID== 0)
                {
                    datatable = dataset.Tables[0];
                    objEmpleado.Empleado_ID= Convert.ToInt32(datatable.Rows[0]["Emp_ID"]);
                }
                
                ResultadoOk = true;
                MensajeError = "";
            }
            catch (Exception error)
            {
                ResultadoOk = false;
                MensajeError = "Ha ocurrido un error al guardar los datos del empleado." + error.Message.ToString();
            }
            finally
            {
                con.Close();
                datatable = null;
                datatable = null;
                con = null;
            }

        }


    }
}
