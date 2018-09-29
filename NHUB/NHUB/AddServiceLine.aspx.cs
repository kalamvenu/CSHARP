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



            List<Users> List = new List<Users>();


            GetAllUsersDAL getAllUsers = new GetAllUsersDAL();

            List = getAllUsers.GetAllUsersMethod();

            

            foreach (Users B in List)
            {
                AddServiceLineListBox.Items.Add(new ListItem(B.UserName,B.Id.ToString()));
            }


        }

        protected void CreateButton_Click(object sender, EventArgs e)
        {

            string NameSend = NameTextBox.Text;
            int IdSent;

            CreateServiceLineDAL createServiceLine = new CreateServiceLineDAL();

            createServiceLine.CreateServiceLineMethod(NameSend,out IdSent);

            int ServiceLineIdSend = IdSent;

            string UserIdSend = AddServiceLineListBox.SelectedValue;

            AddServiceLineManagerDAL addServiceLineManager = new AddServiceLineManagerDAL();

            addServiceLineManager.AddServiceLineManagerMethod(ServiceLineIdSend, UserIdSend);


            Response.AddHeader("REFRESH", "1;URL=ServiceLines.aspx");
        }
    }
}