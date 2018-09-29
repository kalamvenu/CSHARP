using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceLineDAL.Models;
using ServiceLineDAL.Repository;

namespace NHUB
{
    public partial class ServiceLines : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Context.User.IsInRole("SuperAdmin"))
            {
                Response.Redirect("/Account/Lockout");
            }


            List<ServiceLine> List = new List<ServiceLine>();


            GetAllServiceLines getAllProducts = new GetAllServiceLines();

            List = getAllProducts.GetAllServiceLinesMethod();

            Table TableForServiceLine = new Table();
            TableForServiceLine.BorderWidth = 3;
            TableForServiceLine.BorderStyle = BorderStyle.Solid;
            TableForServiceLine.ID = "myTable";
            TableForServiceLine.CellSpacing = 20;
            TableForServiceLine.CellPadding = 10;

           

            foreach (ServiceLine P in List)
            {
                TableRow tableRow = new TableRow();

                TableForServiceLine.Rows.Add(tableRow);

                TableCell tableCell = new TableCell();

                Label ServiceLabel = new Label();

                
                ServiceLabel.Text = P.Name;

                
                HyperLink Edit = new HyperLink();

                Edit.Text = "&nbsp;&nbsp;EDIT";
                Edit.NavigateUrl = "EditServiceLine.aspx?Id=" + P.Id + "&Name=" + P.Name;


                HyperLink Delete = new HyperLink();

                Delete.Text = "&nbsp;&nbsp;DELETE";
                Delete.NavigateUrl = "DeleteServiceLine.aspx?Id=" + P.Id;

                tableCell.Controls.Add(ServiceLabel);
                tableCell.Controls.Add(Edit);
                tableCell.Controls.Add(Delete);

                tableRow.Cells.Add(tableCell);
               
        
            }

            ServiceLinesPlaceHolder.Controls.Add(TableForServiceLine);



        }

        protected void AddServiceLine_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddServiceLine.aspx");

        }
    }
}