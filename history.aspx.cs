using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace pdd
{
    public partial class history : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Session["farmermob"] as String))
            {
                Response.Redirect("farmer_login.aspx");
            }
            else
            {
                loadownhistory(Session["farmermob"].ToString());
            }
        }



        public void loadownhistory(String farmermobile)
        {
            dataconnection d = new dataconnection();
            SqlConnection con = d.connect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from farmertbl ft, ddtbl dt where ft.mobile=dt.farmermob and ft.mobile=@mobile";
            cmd.Parameters.Add("@mobile", farmermobile);
            SqlDataReader dr = cmd.ExecuteReader();
            gvhistory.DataSource = dr;
            gvhistory.DataBind();
        }
    }
}