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
    public partial class Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAllBrands brands = new GetAllBrands();

            List<Brands> brandsList = brands.GetallBrandsMethod();

            foreach (Brands B in brandsList)
            {
                DropDownListforBrands.Items.Add(new ListItem(B.BrandName, B.BrandId.ToString()));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string Name = NameTextBox.Text;
            int Price = Convert.ToInt32(PriceTextBox.Text);
            string URL = URLTextBox.Text;
            string Action = "insert".ToUpper();
            string Description = DescriptionTextBox.Text;
            int BrandId = DropDownListforBrands.SelectedIndex;
            string BrandName = DropDownListforBrands.SelectedItem.Value;

            //  int s = Convert.ToInt32(Request.QueryString["Id"]);

            ManipulateProducts manipulateProducts = new ManipulateProducts();

            manipulateProducts.ManipulateIndividualProductMethod(Action,Name,Price,URL,Description,BrandId);


            Label1.Text = "Insertion Successful";

           // Response.Redirect("About.aspx");
            Response.AddHeader("REFRESH", "1;URL=Product.aspx");
        }
    }
}