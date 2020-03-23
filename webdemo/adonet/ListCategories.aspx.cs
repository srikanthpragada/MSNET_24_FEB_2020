using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webdemo.adonet
{
    public partial class ListCategories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=msdb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from categories", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Response.Write(dr["catcode"] + ":" + dr["catdesc"] + "<br/>");
            }
            dr.Close();
            con.Close();
        }
    }
}