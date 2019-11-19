using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Pages_AddPhys : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if ((TextBox6.Text != TextBox2.Text) && (TextBox6.Text != TextBox3.Text) && (TextBox6.Text != TextBox4.Text) && (TextBox6.Text != TextBox5.Text))
        {
            Label7.Text = "Correct option doesn't match with any options";
        }
        else
        {
            SqlConnection con = new SqlConnection("server=SHRIKANTH-PC\\SQLEXPRESS;initial catalog=Questions;integrated security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into [Physics](question,Op1,Op2,Op3,Op4,Correct) values(@ques,@op11,@op22,@op33,@op44,@corr)", con);
            cmd.Parameters.AddWithValue("@ques", TextBox1.Text);
            cmd.Parameters.AddWithValue("@op11", TextBox2.Text);
            cmd.Parameters.AddWithValue("@op22", TextBox3.Text);
            cmd.Parameters.AddWithValue("@op33", TextBox4.Text);
            cmd.Parameters.AddWithValue("@op44", TextBox5.Text);
            cmd.Parameters.AddWithValue("@corr", TextBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            TextBox1.Text = null;
            TextBox2.Text = null;
            TextBox3.Text = null;
            TextBox4.Text = null;
            TextBox5.Text = null;
            TextBox6.Text = null;
            Label7.Text = null;
        }
    }
}