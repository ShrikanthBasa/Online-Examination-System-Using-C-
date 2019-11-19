using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Pages_AddChem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if ((TextBox12.Text != TextBox8.Text) && (TextBox12.Text != TextBox9.Text) && (TextBox12.Text != TextBox10.Text) && (TextBox12.Text != TextBox11.Text))
        {
            Label1.Text = "Correct option doesn't match with any options";
        }
        else
        {
            SqlConnection con = new SqlConnection("server=NITESH-PC\\SQLEXPRESS;initial catalog=Questions;integrated security=true");
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into [Chemistry](question,Op1,Op2,Op3,Op4,Correct) values(@ques,@op11,@op22,@op33,@op44,@corr)", con);
        cmd.Parameters.AddWithValue("@ques", TextBox7.Text);
        cmd.Parameters.AddWithValue("@op11", TextBox8.Text);
        cmd.Parameters.AddWithValue("@op22", TextBox9.Text);
        cmd.Parameters.AddWithValue("@op33", TextBox10.Text);
        cmd.Parameters.AddWithValue("@op44", TextBox11.Text);
        cmd.Parameters.AddWithValue("@corr", TextBox12.Text);
        cmd.ExecuteNonQuery();
        con.Close();
        TextBox7.Text = null;
        TextBox8.Text = null;
        TextBox9.Text = null;
        TextBox10.Text = null;
        TextBox11.Text = null;
        TextBox12.Text = null;
        Label1.Text = null;
        }
    }
}