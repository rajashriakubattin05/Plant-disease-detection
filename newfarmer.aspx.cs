using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace pdd
{
    public partial class newfarmer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("farmer_login.aspx");
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            dataconnection d = new dataconnection();
            SqlConnection con = d.connect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection=con;
            cmd.CommandText = "select * from farmertbl where mobile=@mobile";
            cmd.Parameters.Add("@mobile", txtmobile.Text.Trim());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Response.Write("<script>alert('Mobile Number already Registored'</script>)");
                txtmobile.Text = "";
                txtmobile.Focus();
            }
            else
            {
                dr.Dispose();
                cmd.CommandText = "insert into farmertbl(fname,mobile,pass)values(@fname,@mobile,@pass)";
                cmd.Parameters.Add("@fname", txtfullname.Text.Trim());
                cmd.Parameters.Add("@pass", txtpass.Text.Trim());
                cmd.ExecuteNonQuery();
                



                Response.Redirect("farmer_login.aspx");

            }
        }
    }
}