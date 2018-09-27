using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Repository.Products;
using Repository.Repositories;

namespace September24_2
{
    public partial class DataAdapterForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

          
            List < Product > DAList= new List<Product>();

            DataAdapterClass dataAdapterClass = new DataAdapterClass();

             DAList = dataAdapterClass.GetProductsWithDR();

            GridView1.DataSource = DAList;
            GridView1.DataBind();

        }
    }
}