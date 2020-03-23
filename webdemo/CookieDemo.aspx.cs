using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webdemo
{
    public partial class CookieDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie person = Request.Cookies["person"];
            if (person == null)
                Response.Redirect("takename.aspx");
            else
                lblMessage.Text = "Welcome " + person.Value;

            Session.Add("name", "value");
            Application.Add("", "");

        }
    }
}