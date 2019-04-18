using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Negocio.Repositorio;
using System.Data;

namespace Capa_Negocio.Logica
{
    public class CEstadoCivil
    {
        private int estadoC_ID;
        private string estadoC_Descripcion;

        public int EstadoC_ID { get => estadoC_ID; set => estadoC_ID = value; }
        public string EstadoC_Descripcion { get => estadoC_Descripcion; set => estadoC_Descripcion = value; }

        

        public CEstadoCivil()
        {
            
        }

        public CEstadoCivil(int id, string descripcion)
        {
            EstadoC_ID = id;
            EstadoC_Descripcion = descripcion;
        }

        public CEstadoCivil(string descripcion)
        {
            EstadoC_Descripcion = descripcion;
        }

        public DataTable SeleccionarEstadoCivil()
        {
            DataTable dataTable = new DataTable();
            CBusqueda objBusquedad = new CBusqueda();
            dataTable = objBusquedad.SeleccionarEstadoCivil();
            return dataTable;
        }


    }
}
