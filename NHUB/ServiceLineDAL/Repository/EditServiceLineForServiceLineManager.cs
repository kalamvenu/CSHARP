using ServiceLineDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLineDAL.Repository
{
    public class EditServiceLineForServiceLineManager
    {
        public List<Users> EditServiceLineManagerMethod(int IdSent)
        {
            int Id = IdSent;
            List<Users> EditServiceLinesList = new List<Users>();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString =
                 @"Data Source=PC-112;Initial Catalog=NotificationHub;Integrated Security=True";
                connection.Open();

                //string sql = "select distinct AspNetUsers.UserName,AspNetUsers.Id from OperationManager,AspNetUsers where OperationManager.ServicelineId =" + Id;

                string sql = "select UserName,Id from AspNetUsers where Id in (select OperationManagerId from[OperationManager] where ServicelineId =" + Id + ")";

                SqlCommand myCommand = new SqlCommand(sql, connection);

                // myCommand.Parameters.Add("@Id", SqlDbType.Int, 50).Value = Id;

                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {

                    while (myDataReader.Read())
                    {

                        EditServiceLinesList.Add(new Users
                        {

                            Id = myDataReader["Id"].ToString(),
                            UserName = myDataReader["UserName"].ToString()

                        });

                    }
                }



            }

            return EditServiceLinesList;

        }
    }
}
