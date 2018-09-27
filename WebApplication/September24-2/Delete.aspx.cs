using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Repository.Repositories;

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

            int SendId = Convert.ToInt32(Request.QueryString["Id"]);

            string Action = "Delete".ToUpper();

            ManipulateProducts manipulateProducts = new ManipulateProducts();

            manipulateProducts.ManipulateIndividualProductMethod(Action,SendId);

            Label1.Text = "Deleted";

            Response.AddHeader("REFRESH", "1;URL=Product.aspx");
        }
    }
}