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
    public partial class Preview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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

                myCommand.Parameters.Add("@Action", SqlDbType.VarChar, 20).Value = "SELECTONE";
                myCommand.Parameters.Add("@Id", SqlDbType.Int, 20).Value = s;

                //SqlParameter param;
                //param = new SqlParameter
                //{
                //    ParameterName = "@petName",
                //    SqlDbType = SqlDbType.Char,
                //    Size = 10,
                //    Direction = ParameterDirection.Output
                //};


                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {

                    if (myDataReader.Read())
                    {

                        int Id = Convert.ToInt32(myDataReader["Id"].ToString());
                        string Name = myDataReader["Name"].ToString();
                        int Price = Convert.ToInt32(myDataReader["Price"].ToString());
                        string Description = myDataReader["Description"].ToString();

                        Image image = new Image();
                        image.ImageUrl = myDataReader["URL"].ToString();
                        image.Width = 113;
                        image.Height = 87;

                        PlaceHolder1.Controls.Add(image);
                        Label label = new Label();
                        label.Text = Id + "  " + Name + "   " + Price + "   " + Description;
                        PlaceHolder1.Controls.Add(label);
                    }


                }
            }
        }
    }
    
}