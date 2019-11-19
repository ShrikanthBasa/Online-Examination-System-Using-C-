using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["AdminName"] = null;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string user = TextBox1.Text.ToString();
            string password = TextBox2.Text.ToString();
            SqlConnection con = new SqlConnection("server=NITESH-PC\\SQLEXPRESS;initial catalog=Logins;integrated security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Admin", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd["UserName"].ToString() == user && rd["pass"].ToString() == password)
                {
                    rd.Close();
                    Session["AdminName"] = TextBox1.Text;
                    Response.Redirect("Pages/AdminHome.aspx");
                }
            }
            con.Close();
        }
        catch(Exception e1)
        {
            Response.Write(e1);
        }
           
    }
}