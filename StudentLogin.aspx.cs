using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudentLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["name"] = TextBox1.Text + " " + TextBox2.Text;
        Session["db"] = TextBox1.Text + TextBox2.Text+TextBox3.Text;
        Session["class"] = DropDownList1.Text;
        Session["roll"] = TextBox3.Text;
        Session["subject"] = DropDownList2.Text;
        Session["enroll"] = TextBox4.Text;
        Response.Redirect("exams/Instructions.aspx");
    }
}