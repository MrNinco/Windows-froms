using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    class database
    {
        public static SqlConnection getconnection()
        {
            SqlConnection db = new SqlConnection("Data Source = DESKTOP-A64L3K8\\SQLEXPRESS; Initial Catalog = dancastore;Integrated Security = true");
            db.Open();
            return db;
        }
    }
}
