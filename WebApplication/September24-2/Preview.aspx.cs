using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Repository.Products;
using Repository.Repositories;


namespace September24_2
{
    public partial class Preview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int SendId = Convert.ToInt32(Request.QueryString["Id"]);

            string SendAction = "selectone".ToUpper();

            List<Product> IndividualList = new List<Product>();


            ManipulateProducts ManipulateIndividualProduct = new ManipulateProducts();

            IndividualList = ManipulateIndividualProduct.ManipulateIndividualProductMethod(SendId,SendAction);


            foreach (Product P in IndividualList)
            {

                int Id = P.Id;
                string Name = P.Name;
                int Price = P.Price;
                string Description = P.Description;

                Image image = new Image();
                image.ImageUrl = P.URL;
                image.Width = 250;
                image.Height = 150;

                PlaceHolder1.Controls.Add(image);
                Label label = new Label();
                label.Text = Id + "  " + Name + "   " + Price + "   " + Description;
                PlaceHolder1.Controls.Add(label);
            }
        }
        
        
    }
    
}