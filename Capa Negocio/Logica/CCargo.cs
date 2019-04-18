using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Negocio.Repositorio;
namespace Capa_Negocio.Logica
{
    public class CCargo
    {
        private int cargo_ID;
        private string cargo_Descripcion;

        public int Cargo_ID { get => cargo_ID; set => cargo_ID = value; }
        public string Cargo_Descripcion { get => cargo_Descripcion; set => cargo_Descripcion = value; }

        public CCargo()
        {

        }

        public CCargo(int id, string descripcion)
        {
            Cargo_ID = id;
            Cargo_Descripcion = descripcion;
        }

        public CCargo(string descripcion)
        {
            Cargo_Descripcion = descripcion;
        }

       public  DataTable SeleccionarCargo()
        {
            DataTable dataTable = new DataTable();
            CBusqueda objBusquedad = new CBusqueda();
            dataTable = objBusquedad.SeleccionarCargo();
            return dataTable;

        }
    }


}
