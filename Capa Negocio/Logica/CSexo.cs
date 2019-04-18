using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Negocio.Repositorio;
using System.Data;

namespace Capa_Negocio.Logica
{
    public class CSexo
    {
        private int sexo_ID;
        private string sexo_Descripcion;

        public int Sexo_ID { get => sexo_ID; set => sexo_ID = value; }
        public string Sexo_Descripcion { get => sexo_Descripcion; set => sexo_Descripcion = value; }

        public CSexo()
        {
            //Sexo_ID = 0;
            //Sexo_Descripcion = "";
        }

        public CSexo(int id, string descripcion)
        {
            Sexo_ID = id;
            Sexo_Descripcion = descripcion;
        }

        public CSexo(string descripcion)
        {
            Sexo_Descripcion = descripcion;
        }

        public DataTable SeleccionarSexo()
        {
            DataTable dataTable = new DataTable();
            CBusqueda objBusquedad = new CBusqueda();
            dataTable = objBusquedad.SeleccionarSexo();
            return dataTable;
        }
    }
}

