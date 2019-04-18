using Capa_Negocio.Repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio.Logica
{
    public class CMunicipio
    {
        
        private int Mu_ID;
        private string Mu_Nombre;
        private int Pro_ID;

        public CMunicipio()
        {
        }

        public CMunicipio(int id, string nombre, int pro_ID)
        {
            Mu_ID = id;
            Mu_Nombre = nombre;
            Pro_ID = pro_ID;

        }

        public CMunicipio(string nombre, int pro_ID)
        {
            Mu_Nombre = nombre;
            Pro_ID = pro_ID;
        }

        public int ID { get => Mu_ID; set => Mu_ID = value; }
        public string Nombre { get => Mu_Nombre; set => Mu_Nombre = value; }
        public int Provincia { get => Pro_ID; set => Pro_ID = value; }

        public DataTable SeleccionarMunicipio( Int32 Pro_ID)
        {
            DataTable dataTable = new DataTable();
            CBusqueda objBusqueda = new CBusqueda();
            dataTable = objBusqueda.SeleccionarMunicipio(Pro_ID);
            return dataTable;
        }
    }
}
