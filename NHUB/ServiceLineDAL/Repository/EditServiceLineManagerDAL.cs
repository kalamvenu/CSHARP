using ServiceLineDAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLineDAL.Repository
{
    public class EditServiceLineManagerDAL
    {

        public List<ServiceLine> EditServiceLineManagerMethod(int IdSent)
        {
            int Id = IdSent;
            List<ServiceLine> EditServiceLinesList = new List<ServiceLine>();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString =
                 @"Data Source=PC-112;Initial Catalog=NotificationHub;Integrated Security=True";
                connection.Open();

                string sql = "select UserName from AspNetUsers where Id = (select UserId from ServiceLineManager where ServiceLineId = @Id)";

                SqlCommand myCommand = new SqlCommand(sql, connection);

                myCommand.Parameters.Add("@Id", SqlDbType.Int, 50).Value = Id;

                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {

                    while (myDataReader.Read())
                    {

                        EditServiceLinesList.Add(new ServiceLine
                        {

                            Id = Convert.ToInt32(myDataReader["Id"].ToString()),
                            Name = myDataReader["Name"].ToString()

                        });

                    }
                }



            }

            return EditServiceLinesList;

        }

    }
}
