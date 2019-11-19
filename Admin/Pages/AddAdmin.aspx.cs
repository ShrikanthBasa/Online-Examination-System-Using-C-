using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Pages_AddAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("server=NITESH-PC\\SQLEXPRESS;initial catalog=Logins;integrated security=true");
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into [Admin](Name,Dept,UserName,pass) values(@name,@dept,@username,@pass)", con);
        cmd.Parameters.AddWithValue("@name", TextBox1.Text);
        cmd.Parameters.AddWithValue("@dept", DropDownList1.Text);
        cmd.Parameters.AddWithValue("@username", TextBox2.Text);
        cmd.Parameters.AddWithValue("@pass", TextBox3.Text);
        cmd.ExecuteNonQuery();
        con.Close();
        TextBox1.Text = null;
        TextBox2.Text = null;
        TextBox3.Text = null;
    }
}