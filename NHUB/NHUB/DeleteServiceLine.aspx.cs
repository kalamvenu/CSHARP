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
    public partial class DeleteServiceLine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

             int Id = Convert.ToInt32(Request.QueryString["Id"]);

            string Name = Request.QueryString["Name"];

            Label DisplayName = new Label
            {
                Text = "are you sure you want to delete      " + Name
            };

            DeleteServiceLinePlaceHolder.Controls.Add(DisplayName);


        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(Request.QueryString["Id"]);

            DeleteServiceLineDAL deleteServiceLineDAL = new DeleteServiceLineDAL();
            deleteServiceLineDAL.DeleteServiceLineMethod(Id);

            Response.AddHeader("REFRESH", "1;URL=ServiceLines.aspx");

        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.AddHeader("REFRESH", "1;URL=ServiceLines.aspx");
        }
    }
}