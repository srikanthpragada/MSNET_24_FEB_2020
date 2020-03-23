using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webdemo
{
    public partial class course : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                lblTime.Text = DateTime.Now.ToString();
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            int fee = Int32.Parse(ddlCourse.SelectedItem.Value);

            if (rbOnline.Checked)
                fee = fee + fee * 10 / 100;

            if (cbCourseMaterial.Checked)
                fee += 300;

            lblFee.Text = fee.ToString();
        }
    }
}