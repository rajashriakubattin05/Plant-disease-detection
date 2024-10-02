using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace pdd
{
    public partial class farmer_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnreg_Click(object sender, EventArgs e)
        {
            Response.Redirect("newfarmer.aspx");
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            dataconnection d = new dataconnection();
            SqlConnection con = d.connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection=con;
            con.Open();
            cmd.CommandText = "select * from farmertbl where mobile=@mobile and pass=@pass";
            cmd.Parameters.Add("@mobile", txtmobile.Text.Trim());
            cmd.Parameters.Add("@pass", txtpass.Text.Trim());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Dispose();
                cmd.Dispose();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con;
                cmd1.CommandText = "insert into logintbl(mobile,datet)values(@mobile,@datet)";
                cmd1.Parameters.AddWithValue("@mobile", txtmobile.Text);
                cmd1.Parameters.AddWithValue("@datet", System.DateTime.Now);
                cmd1.ExecuteNonQuery();
                Session["farmermob"] = txtmobile.Text;
                Response.Redirect("farmer_home.aspx");
               
            }
            else
            {
                Response.Write("<script>alert('Invalid Credentials'</script>)");
                txtmobile.Text = "";
            }
        }
    }
}