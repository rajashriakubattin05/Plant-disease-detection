using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;

namespace pdd
{
    public partial class farmer_home : 
        System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnupload_Click(object sender, EventArgs e)
        {
            dataconnection d=new dataconnection();
            String ifile, ext;
            ifile = FileUpload1.FileName;
            ext = Path.GetExtension(ifile);
            if (ext == ".jpg" || ext == ".jpeg" || ext == ".bmp" || ext == ".png")
            {
                DateTime dt = d.getdatetime();
                String newfilename=d.genfilename()+ext;
                SqlConnection con = d.connect();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into ddtbl(farmermob,imgfile,adate)values(@mobile,@file,@date)";
                cmd.Parameters.AddWithValue("@mobile",Session["farmermob"].ToString());
                cmd.Parameters.AddWithValue("@file", newfilename);
                cmd.Parameters.AddWithValue("@date",dt);
                cmd.ExecuteNonQuery();
                FileUpload1.SaveAs(Server.MapPath(newfilename));
                Response.Write("<script>alert('File Uploaded Please Click On Detect Button')</script>");
            }
            else
            {
                Response.Write("<script>alert('Please Select Image File Only')</script>");
            }

        }
    }
}