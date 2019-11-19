using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class exams_Summary : System.Web.UI.Page
{
    string date = DateTime.Now.ToString("dd/MM/yyyy");
    SqlDataAdapter da;
    DataSet ds = new DataSet();
    StringBuilder htmlTable = new StringBuilder();
    SqlConnection con = new SqlConnection("server=NITESH-PC\\SQLEXPRESS;initial catalog=StudentDB;integrated security=true");
    string dbname;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["name"]==null)
        {
            Response.Redirect("FeedBack.aspx");
        }

        dbname = Session["db"].ToString();

        SqlCommand cmd = new SqlCommand("SELECT * FROM "+dbname, con);
        da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        htmlTable.Append("<table border='15px solid'>");
        htmlTable.Append("<tr style='background-color:orange; color: black;'><th>No</th><th>Quesion</th><th>Option a</th><th>Option b</th><th>Options c</th><th>Option d</th><th>Your Option</th></tr>");

        if (!object.Equals(ds.Tables[0], null))
        {
            if (ds.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    htmlTable.Append("<tr style='color: Black;text-align:center'>");
                    htmlTable.Append("<td>" + (i+1) + "</td>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["ques"] + "</td>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["Opt1"] + "</td>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["Opt2"] + "</td>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["Opt3"] + "</td>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["Opt4"] + "</td>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["selected"] + "</td>");
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand comm = new SqlCommand("select * from "+dbname, con);
        SqlDataReader rd = comm.ExecuteReader();
        while(rd.Read())
        {
            string cor=rd["corr"].ToString();
            string sel=rd["selected"].ToString();
            if(cor==sel)
            {
                Session["m"] = Convert.ToInt32(Session["m"]) + 1;
            }
        }
        con.Close();

        SqlConnection conn = new SqlConnection("server=NITESH-PC\\SQLEXPRESS;initial catalog=Logins;integrated security=true");
        conn.Open();
        SqlCommand cmd = new SqlCommand("insert into [students](Date,Name,Class,RollNo,Subject,EnrollNo,Marks) values(@date,@name,@class,@roll,@subj,@enroll,@marks)", conn);
        cmd.Parameters.AddWithValue("@date", date);
        cmd.Parameters.AddWithValue("@name", Session["name"]);
        cmd.Parameters.AddWithValue("@class", Session["class"]);
        cmd.Parameters.AddWithValue("@roll", Session["roll"]);
        cmd.Parameters.AddWithValue("@subj", Session["subject"]);
        cmd.Parameters.AddWithValue("@enroll", Session["enroll"]);
        if (Convert.ToInt32(Session["m"]) > 0)
        {
            cmd.Parameters.AddWithValue("@marks", Session["m"]);
        }
        else
        {
            cmd.Parameters.AddWithValue("@marks", 0);
        }
        cmd.ExecuteNonQuery();
        conn.Close();
        Session["m"] = 0;
        Session["FeedName"] = Session["name"].ToString();
        Session["name"] = null;
        Response.Redirect("FeedBack.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        
    }
    protected void timer1_tick(object sender, EventArgs e)
    {
        if (0 > DateTime.Compare(DateTime.Now, DateTime.Parse(Session["timeout"].ToString())))
        {
            lblTimer.Text ="Remaining Time :" + string.Format("00:{00}:{1}", ((Int32)DateTime.Parse(Session["timeout"].ToString()).Subtract(DateTime.Now).TotalMinutes).ToString(), ((Int32)DateTime.Parse(Session["timeout"].ToString()).Subtract(DateTime.Now).Seconds).ToString());
        }
        else
        {
            con.Open();
            SqlCommand comm = new SqlCommand("select * from "+dbname, con);
            SqlDataReader rd = comm.ExecuteReader();
            while (rd.Read())
            {
                string cor = rd["corr"].ToString();
                string sel = rd["selected"].ToString();
                if (cor == sel)
                {
                    Session["m"] = Convert.ToInt32(Session["m"]) + 1;
                }
            }
            con.Close();

            SqlConnection conn = new SqlConnection("server=NITESH-PC\\SQLEXPRESS;initial catalog=Logins;integrated security=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into [students](Date,Name,Class,RollNo,Subject,EnrollNo,Marks) values(@date,@name,@class,@roll,@subj,@enroll,@marks)", conn);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@name", Session["name"]);
            cmd.Parameters.AddWithValue("@class", Session["class"]);
            cmd.Parameters.AddWithValue("@roll", Session["roll"]);
            cmd.Parameters.AddWithValue("@subj", Session["subject"]);
            cmd.Parameters.AddWithValue("@enroll", Session["enroll"]);
            if (Convert.ToInt32(Session["m"]) > 0)
            {
                cmd.Parameters.AddWithValue("@marks", Session["m"]);
            }
            else
            {
                cmd.Parameters.AddWithValue("@marks", 0);
            }
            cmd.ExecuteNonQuery();
            conn.Close();
            Session["m"] = 0;
            Session["FeedName"] = Session["name"].ToString();
            Session["name"] = null;
            Response.Redirect("FeedBack.aspx");
        }
    }
}