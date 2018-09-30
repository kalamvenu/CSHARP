using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLineDAL.Repository
{
    public class UpdateServiceLineServiceLineManager
    {

        public void UpdateServiceLineMethod(List<string> NameSent, int SendId)
        {

            //string UserId = NameSent;
            int Id = SendId;

            List<string> ReceivedName = new List<string>();

            ReceivedName = NameSent;

            string strcon = "Data Source=PC-112;Initial Catalog=NotificationHub;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = strcon;
                connection.Open();

                string sql = "delete from OperationManager WHERE ServiceLineId = @Action1";

                SqlCommand myCommand = new SqlCommand(sql, connection);

                myCommand.Parameters.Add("@Action1", SqlDbType.Int, 50).Value = Id;

                myCommand.ExecuteNonQuery();

            }

        }
    }
}
