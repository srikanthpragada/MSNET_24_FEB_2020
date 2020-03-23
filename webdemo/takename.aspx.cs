using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webdemo
{
    public partial class takename : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // Take name from textbox and save it as cookie
            HttpCookie cookie = new HttpCookie("person", txtName.Text);
            cookie.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Add(cookie);
            Response.Redirect("CookieDemo.aspx");
        }
    }
}