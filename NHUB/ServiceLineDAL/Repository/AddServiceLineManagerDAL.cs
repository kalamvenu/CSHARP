using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ServiceLineDAL.Repository
{
    public class AddServiceLineManagerDAL
    {

        public void AddServiceLineManagerMethod(int ServiceLineIdSent,string UserIdSent)
        {

            int ServiceLineId = ServiceLineIdSent;
            string UserId = UserIdSent;

            string strcon = "Data Source=PC-112;Initial Catalog=NotificationHub;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = strcon;
                connection.Open();

                string sql = "INSERT INTO ServiceLineManager (ServiceLineId,UserId) VALUES(@Action1,@Action2)";

                SqlCommand myCommand = new SqlCommand(sql, connection);

                myCommand.Parameters.Add("@Action1", SqlDbType.Int, 20).Value = ServiceLineId;
                myCommand.Parameters.Add("@Action2", SqlDbType.VarChar, 50).Value = UserId;
                myCommand.ExecuteNonQuery();


            }

        }

    }
}
