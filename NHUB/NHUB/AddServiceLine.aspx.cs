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
    public partial class AddServiceLine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Context.User.IsInRole("SuperAdmin"))
            {
                Response.Redirect("/Account/Lockout");
            }


            List<Users> ListForDisplaying = new List<Users>();

            GetAllUsersDAL getAllUsers = new GetAllUsersDAL();

            ListForDisplaying = getAllUsers.GetAllUsersMethod();


           foreach (Users UsersCount in ListForDisplaying)
            {
                 AddServiceLineListBox.Items.Add(new ListItem(UsersCount.UserName,UsersCount.Id.ToString()));
     
            }

            
        }

        protected void CreateButton_Click(object sender, EventArgs e)
        {

            string NameSend = NameTextBox.Text;

            int IdSent;


            // to enter the name of the service line

            CreateServiceLineDAL createServiceLine = new CreateServiceLineDAL();

            createServiceLine.CreateServiceLineMethod(NameSend,out IdSent);

            int ServiceLineIdSend = IdSent;

            // selevterd items in list storing 

            List<string> SelectedValuesForCollectingUserId = new List<string>();

            //  string UserIdSend = AddServiceLineListBox.SelectedValue;
            
            foreach (ListItem item in AddServiceLineListBox.Items)
            {
                
                if (item.Selected)
                {
                    SelectedValuesForCollectingUserId.Add(item.Value);

                }
            }

            //to enter the names of users into the foriegn table with the string userid

            AddServiceLineManagerDAL addServiceLineManager = new AddServiceLineManagerDAL();

            addServiceLineManager.AddServiceLineManagerMethod(ServiceLineIdSend, SelectedValuesForCollectingUserId);


            Response.AddHeader("REFRESH", "1;URL=ServiceLines.aspx");
        }
    }
}