using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        public SqlConnection conectar()
        {
            SqlConnection con = new SqlConnection("Persist Security Info=False;User ID=Prueba;Password=1234;Initial Catalog=Los_Monos;Server=192.168.0.17");
            return con;
        }
    }
}
