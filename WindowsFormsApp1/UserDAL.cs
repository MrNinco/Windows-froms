using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class UserDAL
    {
        public static int NewUser (string pNombre, string pApellido, string pEmail, string pTelefono, string pCiudad, string pDireccion, string pContrasena)
        {
            int result = 0;
            SqlConnection db = database.getconnection();
            {
                SqlCommand command = new SqlCommand(string.Format("insert into user_(name, lastname, email, password, phone_number, town, address) values('{0}', '{1}', '{2}', HashBytes('MD5','{3}'), '{4}', '{5}', '{6}')", pNombre,  pApellido, pEmail, pContrasena, pTelefono, pCiudad, pDireccion),db);
                result = command.ExecuteNonQuery();
            }
            return result;
        }

        public static int AuthenticationLogin (string pEmail, string pContrasena)
        {
            int result = 0;
            SqlConnection db = database.getconnection();
            SqlCommand command = new SqlCommand(string.Format("select * from user_ where email = '{0}' and HashBytes('MD5','{1}') = password", pEmail, pContrasena), db);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result = 50;
            }

            db.Close();
            return result;
        }
    }
}
