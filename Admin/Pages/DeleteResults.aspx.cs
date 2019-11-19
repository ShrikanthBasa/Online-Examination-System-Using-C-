using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Pages_DeleteResults : System.Web.UI.Page
{
    SqlDataAdapter da;
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String cls = DropDownList1.Text;
        String dt = TextBox1.Text;
        SqlConnection con = new SqlConnection("server=NITESH-PC\\SQLEXPRESS;initial catalog=Logins;integrated security=true");
        SqlCommand cmd = new SqlCommand("delete from students where Date=" + "'" + dt + "'" + "and Class=" + "'" + cls + "'", con);
        da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        Label1.Text = "Successfully Deleted";
    }
}