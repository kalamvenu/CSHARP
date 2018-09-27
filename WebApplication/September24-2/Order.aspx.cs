using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace September24_2
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Context.User.IsInRole("Order"))
            {

            }

            else
            {
                Response.Redirect("/Account/Lockout");
            }
        }
    }
}