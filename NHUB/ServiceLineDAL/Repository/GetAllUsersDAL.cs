using ServiceLineDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLineDAL.Repository
{
    public class GetAllUsersDAL
    {
        public List<Users> GetAllUsersMethod()
        {

            List<Users> UserList = new List<Users>();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString =
                 @"Data Source=PC-112;Initial Catalog=NotificationHub;Integrated Security=True";
                connection.Open();

                string sql = "Select * From AspNetUsers";

                SqlCommand myCommand = new SqlCommand(sql, connection);

                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {

                    while (myDataReader.Read())
                    {

                        UserList.Add(new Users
                        {

                            Id = myDataReader["Id"].ToString(),
                            UserName = myDataReader["UserName"].ToString()

                        });

                    }
                }



            }

            return UserList;
        }
        
    }
}
