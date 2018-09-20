using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace September_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {

          //  Label1.Text = "hello world from preinit ";

            ViewState["value"] = "<br/>this is a view state";
            Label1.Text = Convert.ToString(ViewState["value"]);
        }

        protected void Page_Init(object sender, EventArgs e)
        {

            //   Label2.Text = "hello world from init ";
            Label2.Text = Convert.ToString(ViewState["value"]);
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {

            // Label3.Text = "hello world from initcomplete";
            Label3.Text = Convert.ToString(ViewState["value"]);

        }
        protected void Page_PreLoad(EventArgs e)
        {
           // Label4.Text = "hello world from preload";
            Label4.Text = Convert.ToString(ViewState["value"]);

        }
        protected void Page_Load(object sender, EventArgs e)
        {
           // Label5.Text = "hello world from load";
            Label5.Text = Convert.ToString(ViewState["value"]);
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
           // Label6.Text = "hello world from loadcomplete";
            Label6.Text = Convert.ToString(ViewState["value"]);
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {

           // Label7.Text = "hello world  from prerender";
            Label7.Text = Convert.ToString(ViewState["value"]);
        }
        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
           // Label8.Text = "hello world from prerender complete";
            Label8.Text = Convert.ToString(ViewState["value"]);
        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {

            //Label9.Text = "hello world from page unload";
            Label9.Text = Convert.ToString(ViewState["value"]);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string buf = TextBox1.Text;
            changed_text.InnerHtml = buf.ToUpper();


            // Label10.Text = "button cllicked <br/>";


        }
    }
}






// Page_PreInit(sender, e);
// Page_Init(sender, e);
// Page_InitComplete(sender,e);

//Page_PreLoad(e);
// Page_Load(sender, e);
// Page_LoadComplete(sender, e);


// Page_PreRender(sender, e);
// Page_PreRenderComplete(sender, e);
// Page_UnLoad(sender, e);