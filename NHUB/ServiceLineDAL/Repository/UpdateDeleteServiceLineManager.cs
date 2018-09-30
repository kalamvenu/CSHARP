using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLineDAL.Repository
{
    public class UpdateDeleteServiceLineManager
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

                foreach (string Count in ReceivedName)
                {

                    string sql = "INSERT INTO OperationManager (ServiceLineId,OperationManagerId) VALUES(@Action1,@Action2)";

                    SqlCommand myCommand = new SqlCommand(sql, connection);

                    myCommand.Parameters.Add("@Action1", SqlDbType.Int, 50).Value = Id;
                    myCommand.Parameters.Add("@Action2", SqlDbType.VarChar, 200).Value = Count;
                    myCommand.ExecuteNonQuery();
                }

            }

        }

    }
}
