using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLineDAL.Repository
{
    public class DeleteServiceLineDAL
    {
        public void DeleteServiceLineMethod(int IdSent)
        {
           
            int Id = IdSent;

            string strcon = "Data Source = PC-112; Initial Catalog = ECommerce; Integrated Security = True";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = strcon;
                connection.Open();

                string sql = "Delete From ServiceLine where Id = @Id";

                SqlCommand myCommand = new SqlCommand(sql, connection);

                myCommand.Parameters.Add("@Id", SqlDbType.Int, 20).Value = Id;

                myCommand.ExecuteNonQuery();

            }

        }


    }
}
