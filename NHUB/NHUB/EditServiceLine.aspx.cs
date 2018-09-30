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

            List<Users> ListToDisplayInEditServiceLine = new List<Users>();


            EditServiceLineManagerDAL editServiceLineManager = new EditServiceLineManagerDAL();

            ListToDisplayInEditServiceLine = editServiceLineManager.EditServiceLineManagerMethod(Id);



            foreach (Users es in ListToDisplayInEditServiceLine)
            {
                EditServiceLineListBox.Items.Add(new ListItem(es.UserName, es.Id.ToString()));
               
            }

        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.AddHeader("REFRESH", "1;URL=ServiceLines.aspx");
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
           // string NameSend = EditServiceLineTextBox.Text;
            

            int ServiceLineId = Convert.ToInt32(Request.QueryString["Id"]);

            // string Name = Request.QueryString["Name"];

            List<string> SelectedValuesUserIdForUpdate = new List<string>();

            //  string UserIdSend = AddServiceLineListBox.SelectedValue;
            //string UserId = EditServiceLineListBox.SelectedValue;

            foreach (ListItem item in EditServiceLineListBox.Items)
            {

                if (item.Selected)
                {
                    SelectedValuesUserIdForUpdate.Add(item.Value);

                }
            }

            

            UpdateServiceLineDAL updateServiceLineDAL  = new UpdateServiceLineDAL();

            updateServiceLineDAL.UpdateServiceLineMethod(SelectedValuesUserIdForUpdate, ServiceLineId);

            UpdateandDelete updateandDelete = new UpdateandDelete();
            updateandDelete.UpdateServiceLineMethod(SelectedValuesUserIdForUpdate, ServiceLineId);

            Response.AddHeader("REFRESH", "1;URL=ServiceLines.aspx");

        }
    }
}