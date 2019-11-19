using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Pages_AdminHome : System.Web.UI.Page
{
    SqlDataAdapter da;
    DataSet ds = new DataSet();
    DataSet ds1 = new DataSet();
    DataSet ds2 = new DataSet();
    DataSet ds3 = new DataSet();
    DataSet ds4 = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("server=NITESH-PC\\SQLEXPRESS;initial catalog=Questions;integrated security=true");
        SqlCommand cmd = new SqlCommand("SELECT * FROM Physics", con);
        da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Open();
        cmd.ExecuteNonQuery();
        int Pcount = ds.Tables[0].Rows.Count;
        con.Close();

        SqlConnection con1 = new SqlConnection("server=NITESH-PC\\SQLEXPRESS;initial catalog=Questions;integrated security=true");
        SqlCommand cmd1 = new SqlCommand("SELECT * FROM Chemistry", con1);
        da = new SqlDataAdapter(cmd1);
        da.Fill(ds1);
        con.Open();
        cmd.ExecuteNonQuery();
        int Qcount = ds1.Tables[0].Rows.Count+Pcount;
        con.Close();
        Label1.Text = Qcount.ToString();

        SqlConnection con2 = new SqlConnection("server=NITESH-PC\\SQLEXPRESS;initial catalog=Logins;integrated security=true");
        SqlCommand cmd2 = new SqlCommand("select * from students", con2);
        da = new SqlDataAdapter(cmd2);
        da.Fill(ds2);
        con.Open();
        cmd.ExecuteNonQuery();
        Label3.Text = (ds2.Tables[0].Rows.Count).ToString();
        con.Close();

        SqlConnection con3 = new SqlConnection("server=NITESH-PC\\SQLEXPRESS;initial catalog=Logins;integrated security=true");
        SqlCommand cmd3 = new SqlCommand("select * from Admin", con3);
        da = new SqlDataAdapter(cmd3);
        da.Fill(ds3);
        con.Open();
        cmd.ExecuteNonQuery();
        Label4.Text = (ds3.Tables[0].Rows.Count).ToString();
        con.Close();

        SqlConnection con4 = new SqlConnection("server=NITESH-PC\\SQLEXPRESS;initial catalog=Logins;integrated security=true");
        SqlCommand cmd4 = new SqlCommand("select * from students", con4);
        da = new SqlDataAdapter(cmd4);
        da.Fill(ds4);
        con.Open();
        cmd.ExecuteNonQuery();
        Label2.Text = (ds4.Tables[0].Rows.Count).ToString();
        con.Close();
    }
}