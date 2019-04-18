using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Capa_Datos
{
    class CConexion
    {

        //ConectadorDBConnectionString

        public static string Conectar()
        {
            string conexion = "Data Source =.; Initial Catalog = Proyecto Final; Integrated Security = True;"; 
            //System.Configuration.ConfigurationManager.ConnectionStrings["SQLServerConection"].ConnectionString;
            return conexion;
        }


}
}
