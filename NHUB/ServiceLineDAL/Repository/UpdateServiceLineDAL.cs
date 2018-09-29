using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLineDAL.Repository
{
    public class UpdateServiceLineDAL
    {


        public void UpdateServiceLineMethod(string NameSent,int SendId)
        {

            string Name = NameSent;
            int Id = SendId;

            string strcon = "Data Source=PC-112;Initial Catalog=NotificationHub;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = strcon;
                connection.Open();

                string sql = "UPDATE ServiceLineManager SET Name = @Action WHERE Id = @Id ";

                SqlCommand myCommand = new SqlCommand(sql, connection);

                myCommand.Parameters.Add("@Action", SqlDbType.VarChar, 20).Value = Name;
                myCommand.Parameters.Add("@Id", SqlDbType.Int, 50).Value = Id;

                myCommand.ExecuteNonQuery();

                
            }

        }
    }
}
