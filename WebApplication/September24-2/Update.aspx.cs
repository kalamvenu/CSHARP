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
using Repository.Products;

namespace September24_2
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            GetAllBrands brands = new GetAllBrands();

            List<Brands> brandsList = brands.GetallBrandsMethod();

            foreach (Brands B in brandsList)
            {
                DropDownList1.Items.Add(new ListItem(B.BrandName, B.BrandId.ToString()));
            }

            if (!IsPostBack)
            {
                string NameQ = Request.QueryString["Name"];

                TextBox1.Text = NameQ;
                int PriceQ = Convert.ToInt32(Request.QueryString["Price"]);
                TextBox2.Text = PriceQ.ToString(); ;

                string URLQ = Request.QueryString["URL"];
                TextBox3.Text = URLQ;
                string DescriptionQ = Request.QueryString["Description"];
                TextBox4.Text = DescriptionQ;

               // Label1.Text = Request.QueryString["Id"]+ NameQ+ PriceQ+ URLQ+ DescriptionQ;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            
            string Name = TextBox1.Text;
            int Price = Convert.ToInt32(TextBox2.Text);
            string URL = TextBox3.Text;
            string Description = TextBox4.Text;

            string Action = "update".ToUpper();
            int IdQ = Convert.ToInt32(Request.QueryString["Id"]);
            int BrandId = DropDownList1.SelectedIndex;
            string BrandName = DropDownList1.SelectedItem.Value;

            ManipulateProducts manipulateProducts = new ManipulateProducts();

            manipulateProducts.ManipulateIndividualProductMethod(IdQ,Action, Name, Price, URL,Description,BrandId);


            Label1.Text = "Updated";

            Response.AddHeader("REFRESH", "1;URL=Product.aspx");

        }
    }
    
}