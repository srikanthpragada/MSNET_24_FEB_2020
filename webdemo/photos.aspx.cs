using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webdemo
{
    public partial class photos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string filename;
            if (FileUpload1.HasFile)
            {
                //convert virtual path to physical path
                filename = Request.MapPath("photos/" + FileUpload1.FileName);
                FileUpload1.SaveAs(filename); // save file in the server
                lblMessage.Text = "File Uploaded Successfully : " + filename;
            }
            else
                lblMessage.Text = "Please select a file to upload!";
        }

        protected void lbShowPhotos_Click(object sender, EventArgs e)
        {
            string folder = Request.MapPath("/photos");
            DirectoryInfo dir = new DirectoryInfo(folder);
            FileInfo[] files = dir.GetFiles();
            string names = "";
            foreach(FileInfo file in files)
            {
                names += $"<img src='/photos/{file.Name}' style='width:100px;height:100px'/><p></p>";
            }
            lblMessage.Text = names;
        }
    }
}