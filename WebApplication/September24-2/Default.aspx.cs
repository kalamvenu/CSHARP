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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int LengthOfList = 0;

            List<Product> List = new List<Product>();

          

            GetAllProducts getAllProducts = new GetAllProducts();

            List = getAllProducts.GetallProductsMethod();

            Table tb = new Table();
            tb.BorderWidth = 3;
            tb.BorderStyle = BorderStyle.Solid;
            tb.ID = "myTable";
            tb.CellSpacing = 20;
            tb.CellPadding = 10;

            TableRow tr = new TableRow();

                 foreach (Product P in List)
                 {

                      tb.Rows.Add(tr);

                      TableCell tc1 = new TableCell();
                 
                      Image image = new Image();
                      image.ImageUrl = P.URL;
                      image.Width = 350;
                      image.Height = 250;
                      HyperLink HL = new HyperLink();
                      String name = P.Name;
                      HL.Text = P.Name;
                      HL.ID = P.Id.ToString();
                      HL.NavigateUrl = "ProductDetails.aspx?Id="+ P.Id;

                      tc1.Controls.Add(image);
                        
                      tc1.Controls.Add(HL);

                      tr.Cells.Add(tc1);
                      LengthOfList++;

                      if(LengthOfList%2 == 0)
                      {
                           tr = new TableRow();
                      }
                 }

                 PlaceHolderforDefaultDisplay.Controls.Add(tb);
        }
            
        



        protected void Button1_Click(object sender, EventArgs e)
        {
            string Search = Searchbox.Text;

            List<Product> SList = new List<Product>();

           SearchEngine searchEngine = new SearchEngine();


            SList = searchEngine.SearchEngineMethod(Search);

            Table Stb = new Table();
            Stb.BorderWidth = 3;
            Stb.BorderStyle = BorderStyle.Solid;
            Stb.ID = "myTable";

            foreach (Product P in SList)
            {
                TableRow Str = new TableRow();

                TableCell Stc1 = new TableCell();

                Image image = new Image();
                image.ImageUrl = P.URL;
                image.Width = 250;
                image.Height = 150;
                HyperLink HL = new HyperLink();
                String name = P.Name;
                HL.Text = P.Name;
                HL.ID = P.Id.ToString();
                HL.NavigateUrl = "ProductDetails.aspx?Id=" + P.Id;

                PlaceHolderforSearch.Controls.Add(image);
                PlaceHolderforSearch.Controls.Add(HL);

                Str.Cells.Add(Stc1);


            }


        }
    }
}