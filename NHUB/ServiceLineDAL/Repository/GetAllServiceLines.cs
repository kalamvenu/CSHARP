using ServiceLineDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLineDAL.Repository
{
    public class GetAllServiceLines
    {
        public List<ServiceLine> GetAllServiceLinesMethod()
        {

            List<ServiceLine> ServiceLinesList = new List<ServiceLine>();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString =
                 @"Data Source=PC-112;Initial Catalog=NotificationHub;Integrated Security=True";
                connection.Open();

                string sql = "Select * From Serviceline";

                SqlCommand myCommand = new SqlCommand(sql, connection);

                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {

                    while (myDataReader.Read())
                    {

                        ServiceLinesList.Add(new ServiceLine
                        {

                            Id = Convert.ToInt32(myDataReader["Id"].ToString()),
                            Name = myDataReader["Name"].ToString()

                        });

                    }
                }



            }

            return ServiceLinesList;

        }

    }
}
