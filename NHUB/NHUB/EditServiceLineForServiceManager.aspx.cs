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
    public partial class EditServiceLineForServiceManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Context.User.IsInRole("ServiceLineManager"))
            {
                Response.Redirect("/Account/Lockout");
            }


            int Id = Convert.ToInt32(Request.QueryString["Id"]);

            string Name = Request.QueryString["Name"];


            EditServiceLineTextBoxForServiceManager.Text = Name;

            List<Users> ListToDisplayInEditForSLM = new List<Users>();


            EditServiceLineManagerDAL editServiceLineManager = new EditServiceLineManagerDAL();

            ListToDisplayInEditForSLM = editServiceLineManager.EditServiceLineManagerMethod(Id);



            foreach (Users es in ListToDisplayInEditForSLM)
            {
                EditServiceLineListBoxForServiceManager.Items.Add(new ListItem(es.UserName, es.Id.ToString()));

            }

        }

     

       

        protected void UpdateButtonForServiceManager_Click(object sender, EventArgs e)
        {

            // string NameSend = EditServiceLineTextBox.Text;





            int ServiceLineId = Convert.ToInt32(Request.QueryString["Id"]);

            // string Name = Request.QueryString["Name"];

            List<string> SelectedValuesUserIdarrforupdateSLM = new List<string>();

            //  string UserIdSend = AddServiceLineListBox.SelectedValue;
            //string UserId = EditServiceLineListBox.SelectedValue;

            foreach (ListItem item in EditServiceLineListBoxForServiceManager.Items)
            {

                if (item.Selected)
                {
                    SelectedValuesUserIdarrforupdateSLM.Add(item.Value);

                }
            }



            //    EditServiceLineForServiceLineManager editServiceLineForServiceLineManager = new EditServiceLineForServiceLineManager();

            //   editServiceLineForServiceLineManager.EditServiceLineManagerMethod(ServiceLineId);

            UpdateServiceLineServiceLineManager updateServiceLineServiceLineManager = new UpdateServiceLineServiceLineManager();
            updateServiceLineServiceLineManager.UpdateServiceLineMethod(SelectedValuesUserIdarrforupdateSLM, ServiceLineId);

            UpdateDeleteServiceLineManager updateDeleteServiceLineManager = new UpdateDeleteServiceLineManager();

            updateDeleteServiceLineManager.UpdateServiceLineMethod(SelectedValuesUserIdarrforupdateSLM, ServiceLineId);


            Response.AddHeader("REFRESH", "1;URL=ServiceLinesForServiceManager.aspx");
        }

        protected void CancelButtonForServiceManager_Click(object sender, EventArgs e)
        {
            Response.AddHeader("REFRESH", "1;URL=ServiceLinesForServiceManager.aspx");
        }

        
    }
}