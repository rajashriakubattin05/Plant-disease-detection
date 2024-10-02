using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace pdd
{
    public partial class farmer : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Session["farmermob"] as String))
            {
                Response.Redirect("farmer_login.aspx");
            }
            else
            {
                loadonlinefarmers();
            }
        }



        public void loadonlinefarmers()
        {
            
             dataconnection d = new dataconnection();
            SqlConnection con= d.connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandText = "SELECT DISTINCT * FROM logintbl l INNER JOIN farmertbl f ON l.mobile = f.mobile WHERE l.mobile != @self";
           // cmd.CommandText = "select distinct * from logintbl l, farmertbl f where l.mobile=f.mobile and l.mobile !=@self";
            cmd.Parameters.AddWithValue("@self", Session["farmermob"].ToString());
            SqlDataReader dr = cmd.ExecuteReader();
            logedinfarmer.DataSource = dr;
            logedinfarmer.DataBind();

        }


        protected void lbtnlogout_Click(object sender, EventArgs e)
        {
            dataconnection d = new dataconnection();
            SqlConnection con= d.connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandText = "delete from logintbl where mobile=@mobile";
            cmd.Parameters.AddWithValue("@mobile",Session["farmermob"].ToString());
            cmd.ExecuteNonQuery();
            cmd.Dispose();


        }

        protected void logedinfarmer_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string rmobile = e.CommandArgument.ToString();
            panelchat.Visible = true;
            Session["rmobile"] = rmobile;
            loadchat(Session["farmermob"].ToString(), rmobile);
        }


        public void loadchat(String from, String to)
        { 
            dataconnection d = new dataconnection();
            SqlConnection con = d.connect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from chattbl where (to_chat=@to and from_chat=@from) or(from_chat=@to and to_chat=@from) order by chat_date";
            cmd.Parameters.AddWithValue("@to", to);
            cmd.Parameters.AddWithValue("@from", from);
            SqlDataReader dr = cmd.ExecuteReader();
            repchat.DataSource = dr;
            repchat.DataBind();
        }




        protected void btnsendchat_Click(object sender, EventArgs e)
        {
            String to_chat = Session["rmobile"].ToString();
            String from_chat = Session["farmermob"].ToString();
            DateTime dt = System.DateTime.Now;
            dataconnection d = new dataconnection();
            SqlConnection con = d.connect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into chattbl(to_chat,from_chat,chatmsg,chat_date)values(@to,@from,@chat,@date)";
            cmd.Parameters.AddWithValue("@to", to_chat);
            cmd.Parameters.AddWithValue("@from", from_chat);
            cmd.Parameters.AddWithValue("@chat", txtchat.Text.Trim());
            cmd.Parameters.AddWithValue("@date", dt);
            cmd.ExecuteNonQuery();
            txtchat.Text = "";
            txtchat.Focus();
            loadchat(Session["farmermob"].ToString(), Session["rmobile"].ToString());
        }
    }
}