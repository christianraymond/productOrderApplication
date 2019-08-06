using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductOrderApplication
{
    public partial class RecordCustomerDetails : System.Web.UI.Page
    {
        protected System.Web.UI.HtmlControls.HtmlInputFile File1;
        protected System.Web.UI.HtmlControls.HtmlInputButton Submit1;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            message.Text = "Hello " + username.Text + " ! ";
            message.Text = message.Text + " <br/> You have successfuly Registered with the following details.";
            ShowSurname.Text = surname.Text;
            if (RadioButton1.Checked)
            {
                ShowResidential.Text = RadioButton1.Text;
            }
            else ShowResidential.Text = RadioButton2.Text;
            var address = "";
            if (CheckBox1.Checked)
            {
                address = CheckBox1.Text + " ";
            }
            if (CheckBox2.Checked)
            {
                address += CheckBox2.Text + " ";
            }
            ShowCity.Text = address;
            ShowUserNameLabel.Text = "First Name";
            ShowSurnameLabel.Text = "Surname";
            ShowResidentialLabel.Text = "Address type";
            ShowCityLabel.Text = "Area type";
            username.Text = "";
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;                
        }
    }
}