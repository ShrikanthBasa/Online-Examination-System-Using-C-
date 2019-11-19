using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class exams_Instructions : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["name"]==null)
        {
            Response.Redirect("/Home.aspx");
        }
        Label1.Text = "You have selected " + Session["subject"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("server=NITESH-PC\\SQLEXPRESS;initial catalog=StudentDB;integrated security=true");
        string dbname = Session["db"].ToString();
        con.Open();
        SqlCommand cmd = new SqlCommand("create table " + dbname + "(Ques varchar(1000),opt1 varchar(500),opt2 varchar(500),opt3 varchar(500),opt4 varchar(500),Corr varchar(500),selected varchar(500))", con);
        cmd.ExecuteNonQuery();
        SqlConnection con2 = new SqlConnection("server=NITESH-PC\\SQLEXPRESS;initial catalog=Questions;integrated security=true");
        con2.Open();
        SqlCommand cmd2 = new SqlCommand("select top 10 * from physics order by newid()", con2);
        SqlDataReader rd = cmd2.ExecuteReader();
        while (rd.Read())
        {
            SqlCommand cmd3 = new SqlCommand("insert into [" + dbname + "](Ques,opt1,opt2,opt3,opt4,corr,selected) values(@q,@o1,@o2,@o3,@o4,@cor,@sel)", con);
            cmd3.Parameters.AddWithValue("@q", rd["Question"]);
            cmd3.Parameters.AddWithValue("@o1", rd["Op1"]);
            cmd3.Parameters.AddWithValue("@o2", rd["Op2"]);
            cmd3.Parameters.AddWithValue("@o3", rd["Op3"]);
            cmd3.Parameters.AddWithValue("@o4", rd["Op4"]);
            cmd3.Parameters.AddWithValue("@cor", rd["Correct"]);
            cmd3.Parameters.AddWithValue("@sel", "not attempted");
            cmd3.ExecuteNonQuery();
        }
        con.Close();
        con2.Close();
        Response.Redirect("Test.aspx");
    }
}