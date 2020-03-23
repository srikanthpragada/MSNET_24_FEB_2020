using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webdemo
{
    public partial class interest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double amount = Double.Parse(txtAmount.Text);
                double rate = Double.Parse(txtRate.Text);
                double interest = amount * rate / 100;
                lblInterest.Text = interest.ToString();
            }
            catch(FormatException ex)
            {
                lblInterest.Text = "Invalid Input. Please enter valid numbers!";
            }
        }
    }
}