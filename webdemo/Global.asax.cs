using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace webdemo
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application.Add("sessioncount", 0);
        }
        void Session_Start(object sender, EventArgs e)
        {
            Application["sessioncount"] = 
                Int32.Parse(Application["sessioncount"].ToString()) + 1;
        }

        void Session_End(object sender, EventArgs e)
        {
            Application["sessioncount"] =
                Int32.Parse(Application["sessioncount"].ToString()) - 1;
        }
    }
}