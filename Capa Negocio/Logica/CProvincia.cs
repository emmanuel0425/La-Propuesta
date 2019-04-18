using Capa_Negocio.Repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio.Logica
{
    public class CProvincia
    {


        private int Pro_ID;
        private string Pro_Nombre;

        public CProvincia()
        {
            //Pro_ID = 0;
            //Pro_Nombre = "";
        }

        public CProvincia(int id, string nombre)
        {
           Pro_ID = id;
           Pro_Nombre = nombre;
        }
        public CProvincia(string nombre)
        {
            Nombre = nombre;
        }

        public int ID { get => Pro_ID; set => Pro_ID = value; }
        public string Nombre { get => Pro_Nombre; set => Pro_Nombre = value; }

        public DataTable SeleccionarProvincia()
        {
            DataTable dataTable = new DataTable();
            CBusqueda objBusqueda = new CBusqueda();
            dataTable = objBusqueda.SeleccionarProvincia();
            return dataTable;
        }
    }
}
