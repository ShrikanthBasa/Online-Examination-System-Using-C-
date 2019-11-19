using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class exams_FeedBack : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       if(Session["FeedName"]==null)
       {
           Response.Redirect("/Home.aspx");
       }
       TextBox1.Text = Session["FeedName"].ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string profes="";
        if(RadioButton1.Checked)
        {
            profes="Student";
        }
         if(RadioButton2.Checked)
        {
            profes="Teacher";
        }
         if(RadioButton1.Checked)
        {
            profes="Other";
        }
         SqlConnection con = new SqlConnection("server=NITESH-PC\\SQLEXPRESS;initial catalog=FeedBacks;integrated security=true");
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into [Feeds](Name,Email,Mobile,Prof,Rating,Msg) values(@name,@mail,@mob,@pro,@rate,@ms)", con);
        cmd.Parameters.AddWithValue("@name", TextBox1.Text);
        cmd.Parameters.AddWithValue("@mail", TextBox2.Text);
        cmd.Parameters.AddWithValue("@mob", TextBox3.Text);
        cmd.Parameters.AddWithValue("@pro", profes);
        cmd.Parameters.AddWithValue("@rate", Label1.Text+"-"+Label2.Text);
        cmd.Parameters.AddWithValue("@ms", TextBox4.Text);
        cmd.ExecuteNonQuery();
        con.Close();
        Session["FeedName"] = null;
        Response.Redirect("/Home.aspx");
    }
}