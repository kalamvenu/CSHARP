using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fields
{
    public partial class DeleteField : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               



                
            }
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {


            string userName = "venu.kalam@acuvate.com";
            string str = "Kvr@1708";

            var password = new SecureString();

            foreach (char c in str)
            {
                password.AppendChar(c);
            }

            ClientContext clientContext = new ClientContext("https://acuvatehyd.sharepoint.com/teams/TestS");

            clientContext.Credentials = new SharePointOnlineCredentials(userName, password);

            List oList = clientContext.Web.Lists.GetByTitle("Creating a List");

            FieldCollection oFields = oList.Fields;

            clientContext.Load(oFields);
            clientContext.ExecuteQuery();

            Field oField = oFields.GetByInternalNameOrTitle("etertt");

            oField.DeleteObject();

            clientContext.ExecuteQuery();

        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}