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
    public partial class EditServiceLine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Context.User.IsInRole("SuperAdmin"))
            {
                Response.Redirect("/Account/Lockout");
            }

            int Id = Convert.ToInt32(Request.QueryString["Id"]);

            string Name = Request.QueryString["Name"];


            EditServiceLineTextBox.Text = Name;

            List<ServiceLine> List = new List<ServiceLine>();


            EditServiceLineManagerDAL editServiceLineManager = new EditServiceLineManagerDAL();

            List = editServiceLineManager.EditServiceLineManagerMethod(Id);



            foreach (ServiceLine B in List)
            {
                EditServiceLineListBox.Items.Add(new ListItem(B.Name, B.Id.ToString()));
            }


        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.AddHeader("REFRESH", "1;URL=ServiceLines.aspx");
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
           // string NameSend = EditServiceLineTextBox.Text;
            

            int Id = Convert.ToInt32(Request.QueryString["Id"]);

            string Name = Request.QueryString["Name"];

            UpdateServiceLineDAL updateServiceLineDAL  = new UpdateServiceLineDAL();

            updateServiceLineDAL.UpdateServiceLineMethod(Name,Id);

            Response.AddHeader("REFRESH", "1;URL=ServiceLines.aspx");

        }
    }
}