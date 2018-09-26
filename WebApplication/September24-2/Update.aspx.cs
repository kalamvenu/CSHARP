﻿using System;
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
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

          

            string NameQ = Request.QueryString["Name"];

           // TextBox1.Text = NameQ;
            string PriceQ = Request.QueryString["Price"].ToString();
           // TextBox2.Text = PriceQ.ToString(); ;

            string URLQ = Request.QueryString["URL"];
           // TextBox3.Text = URLQ;
            string DescriptionQ = Request.QueryString["Description"];
          //  TextBox4.Text = DescriptionQ;

            Label1.Text = Request.QueryString["Id"]+ NameQ+ PriceQ+ URLQ+ DescriptionQ;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            
            string Name = TextBox1.Text;
            int Price = Convert.ToInt32(TextBox2.Text);
            string URL = TextBox3.Text;
            string Description = TextBox4.Text;


            int IdQ = Convert.ToInt32(Request.QueryString["Id"]);





            string strcon = "Data Source = PC-112; Initial Catalog = ECommerce; Integrated Security = True";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = strcon;
                connection.Open();

                SqlCommand myCommand = new SqlCommand("RetriveDataToPerformOperation", connection);

                myCommand.CommandType = CommandType.StoredProcedure;

                //myCommand.Parameters.AddWithValue("@Action", "SELECTONE");
                //myCommand.Parameters.AddWithValue("@Id", s);

                myCommand.Parameters.Add("@Action", SqlDbType.VarChar, 20).Value = "UPDATE";
                myCommand.Parameters.Add("@Id", SqlDbType.Int, 20).Value = IdQ;
                myCommand.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = Name;
                myCommand.Parameters.Add("@Price", SqlDbType.Int, 50).Value = Price;
                myCommand.Parameters.Add("@URL", SqlDbType.VarChar, 50).Value = URL;
                myCommand.Parameters.Add("@Description", SqlDbType.VarChar, 50).Value = Description;

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

            Label1.Text = "Updated";

            Response.AddHeader("REFRESH", "1;URL=About.aspx");

        }
    }
    
}