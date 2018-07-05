using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data.SqlClient;

namespace Logica
{
    public class LoginClass
    {
        Conexion a = new Conexion();


        public bool loggear(string usuario, string contraseña)
        {
            SqlConnection com = a.conectar();
            com.Open();
            SqlCommand logg = new SqlCommand("select * from Usuario where Nombre_Usu='" + usuario + "'and Contraseña='" + contraseña + "'", com);
            SqlDataReader ex = logg.ExecuteReader();
            if (ex.Read() == true)
            {
                com.Close();
                return true;
            }
            else
            {
                com.Close();
                return false;
            }
        }
    }
}
