using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace September24_2
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "do you want to delete the record";



        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            int s = Convert.ToInt32(Request.QueryString["Id"]);



            string strcon = "Data Source = PC-112; Initial Catalog = ECommerce; Integrated Security = True";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = strcon;
                connection.Open();

                SqlCommand myCommand = new SqlCommand("RetriveDataToPerformOperation", connection);

                myCommand.CommandType = CommandType.StoredProcedure;

                //myCommand.Parameters.AddWithValue("@Action", "SELECTONE");
                //myCommand.Parameters.AddWithValue("@Id", s);

                myCommand.Parameters.Add("@Action", SqlDbType.VarChar, 20).Value = "DELETE";
                myCommand.Parameters.Add("@Id", SqlDbType.Int, 20).Value = s;

                //SqlParameter param;
                //param = new SqlParameter
                //{
                //    ParameterName = "@petName",
                //    SqlDbType = SqlDbType.Char,
                //    Size = 10,
                //    Direction = ParameterDirection.Output
                //};

                myCommand.ExecuteNonQuery();




            }

            Label1.Text = "Deleted";

            Response.AddHeader("REFRESH", "1;URL=About.aspx");
        }
    }
}