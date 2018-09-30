using ServiceLineDAL.Models;
using ServiceLineDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NHUB
{
    public partial class ServiceLinesForServiceManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Context.User.IsInRole("ServiceLineManager"))
            {
                Response.Redirect("/Account/Lockout");
            }



            List<ServiceLine> ListForServiceLinesForSLM = new List<ServiceLine>();


            GetAllServiceLinesDAL getAllServiceLines = new GetAllServiceLinesDAL();

            ListForServiceLinesForSLM = getAllServiceLines.GetAllServiceLinesMethod();

            Table TableForServiceLine = new Table();
            TableForServiceLine.BorderWidth = 3;
            TableForServiceLine.BorderStyle = BorderStyle.Solid;
            TableForServiceLine.ID = "myTable";
            TableForServiceLine.CellSpacing = 20;
            TableForServiceLine.CellPadding = 10;



            foreach (ServiceLine P in ListForServiceLinesForSLM)
            {
                TableRow tableRow = new TableRow();

                TableForServiceLine.Rows.Add(tableRow);

                TableCell tableCell = new TableCell();

                Label ServiceLabel = new Label();


                ServiceLabel.Text = P.Name;


                HyperLink Edit = new HyperLink();

                Edit.Text = "&nbsp;&nbsp;EDIT";
                Edit.NavigateUrl = "EditServiceLineForServiceManager.aspx?Id=" + P.Id + "&Name=" + P.Name;


                tableCell.Controls.Add(ServiceLabel);
                tableCell.Controls.Add(Edit);
               

                tableRow.Cells.Add(tableCell);


            }

            ServiceLinesPlaceHolderForServiceManager.Controls.Add(TableForServiceLine);

        }
    }
}