using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLineDAL.Repository
{
    public class CreateServiceLineDAL
    {

        public void CreateServiceLineMethod(string NameSent ,out int SendId)
        {

            string Name = NameSent;
            

            string strcon = "Data Source=PC-112;Initial Catalog=NotificationHub;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = strcon;
                connection.Open();

                string sql = "INSERT INTO ServiceLine (Name) VALUES(@Action)" +
                    "SELECT SCOPE_IDENTITY()";

                SqlCommand myCommand = new SqlCommand(sql, connection);

                myCommand.Parameters.Add("@Action", SqlDbType.VarChar, 20).Value = Name;

               object o = myCommand.ExecuteScalar();
                SendId = Convert.ToInt32(o);
            }

        }
    }
}
