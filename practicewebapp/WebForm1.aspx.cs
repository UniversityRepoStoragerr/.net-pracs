using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practicewebapp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBoxList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(RadioButton1.Checked)
            {
                Label4.Text = "User selected Gender is " + RadioButton1.Text;
            }
            if (RadioButton2.Checked)
            {
                Label4.Text = "User selected Gender is " + RadioButton2.Text;
            }

            Label5.Text = "";
            string selectedItems = String.Join(",", CheckBoxList1.Items.OfType<ListItem>().Where(i => i.Selected).Select(i => i.Text));         
            Label5.Text = "User Selected hobbies is: " + selectedItems;

            if(DropDownList1.SelectedValue == "")
            {
                Label6.Text = "please select a value";
            }
            else
            {
                Label6.Text = "Your selected city is:" + DropDownList1.SelectedValue;
            }
        }
    }
}