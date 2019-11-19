using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Pages_ChemData : System.Web.UI.Page
{
    SqlDataAdapter da;
    DataSet ds = new DataSet();
    StringBuilder htmlTable = new StringBuilder();
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("server=NITESH-PC\\SQLEXPRESS;initial catalog=Questions;integrated security=true");
        SqlCommand cmd = new SqlCommand("SELECT * FROM Chemistry", con);
        da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        htmlTable.Append("<table border='1'>");
        htmlTable.Append("<tr style='background-color:green; color: White;'><th>Quesion</th><th>Option a</th><th>Option b</th><th>Options c</th><th>Optiond</th><th>Correct</th></tr>");

        if (!object.Equals(ds.Tables[0], null))
        {
            if (ds.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    htmlTable.Append("<tr style='color: Black;text-align:center'>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["Question"] + "</td>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["Op1"] + "</td>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["Op2"] + "</td>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["Op3"] + "</td>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["Op4"] + "</td>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["Correct"] + "</td>");
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
}