using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;

namespace Testing_Registration_and_validation_september_21
{
    public class Names: System.Web.UI.Page                                     
    {
        public string FirstName;
        public string LastName;
        public string EmailId;
        public string DOB;
        public string Gender;
        public string Country;
        public string Interests;
        public string MobileNumber;
        public string RememberMe;
    }

    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

       static List<Names> ListNames = new List<Names>();



        protected void Button1_Click(object sender, EventArgs e)
        {
           
            string selectedItems = String.Join(",",
             CheckBoxList1.Items.OfType<ListItem>().Where(r => r.Selected)
            .Select(r => r.Text));

            string remember;
            if (CheckBox1.Checked == true)
              remember = "remembered";
            else
             remember = "not remembered";

            ListNames.Add(new Names()
            {
                FirstName = TextBox1.Text + "<br/>",
                LastName = TextBox4.Text + "<br/>",
                EmailId = TextBox2.Text + "<br/>",
                DOB = txtSelectDate.Text + "<br/>",
                Gender = RadioButtonList2.Text + "<br/>",
                Country= DropDownList1.Text + "<br/>",
                Interests = selectedItems + "<br/>",
                MobileNumber = TextBox3.Text + "<br/>",
                RememberMe = remember + "<br/>"

            });

            
           
            ViewState["value"] = ListNames;
            GridView1.DataSource = ViewState["value"];

            GridView1.DataBind();



            //int i = ListNames.Count();
            //while (i > 0)
            //{
            //    Label1.Text = ListNames[i - 1].FirstName;
            //    Label2.Text = ListNames[i - 1].LastName;
            //    Label3.Text = ListNames[i - 1].EmailId;
            //    Label4.Text = ListNames[i - 1].DOB;
            //    Label5.Text = ListNames[i - 1].Gender;
            //    Label6.Text = ListNames[i - 1].Country;
            //    Label7.Text = ListNames[i - 1].Interests;
            //    Label8.Text = ListNames[i - 1].MobileNumber;
            //    Label9.Text = ListNames[i - 1].RememberMe;
            //    Label10.Text = ListNames.Count().ToString();
            //    i--;
            //}
        }
    }

      
}