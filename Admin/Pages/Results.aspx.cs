using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Pages_Results : System.Web.UI.Page
{
    SqlDataAdapter da;
    DataSet ds = new DataSet();
    StringBuilder htmlTable = new StringBuilder();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String cls = DropDownList1.Text;
        SqlConnection con = new SqlConnection("server=NITESH-PC\\SQLEXPRESS;initial catalog=Logins;integrated security=true");
        //con.ConnectionString = ;
        SqlCommand cmd = new SqlCommand("SELECT * FROM students where Class="+"'"+cls+"'"+"order by RollNo", con);
        da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        htmlTable.Append("<table border='1'>");
        htmlTable.Append("<tr style='background-color:green; color: White;'><th>Date</th><th>Name</th><th>Class</th><th>RollNo</th><th>Subject</th><th>Enroll</th><th>Marks</th></tr>");

        if (!object.Equals(ds.Tables[0], null))
        {
            if (ds.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    htmlTable.Append("<tr style='color: Black;text-align:center'>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["Date"] + "</td>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["Name"] + "</td>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["Class"] + "</td>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["RollNo"] + "</td>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["Subject"] + "</td>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["EnrollNo"] + "</td>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["Marks"] + "</td>");
                    htmlTable.Append("</tr>");
                }
                htmlTable.Append("</table>");
                PlaceHolder1.Controls.Add(new Literal { Text = htmlTable.ToString() });
            }
            else
            {
                htmlTable.Append("<tr>");
                htmlTable.Append("<td align='center' colspan='4'>There is no Record.</td>");
                htmlTable.Append("</tr>");
            }
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}