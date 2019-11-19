using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class exams_Test : System.Web.UI.Page
{
    string date = DateTime.Now.ToString("dd/MM/yyyy");
    int i;
    System.Data.DataSet ds = null;
    SqlConnection con = new SqlConnection("server=NITESH-PC\\SQLEXPRESS;initial catalog=StudentDB;integrated security=true");
    string dbname;
    protected void Page_Load(object sender, EventArgs e)
    {
        ErrLabel.Text = "";

        if (Session["Name"] == null)
        {
            Response.Redirect("/Home.aspx");
        }

        dbname = Session["db"].ToString();

        if (!SM1.IsInAsyncPostBack)
        {
            if (!IsPostBack)
            {
                Session["timeout"] = DateTime.Now.AddMinutes(10).ToString();
            }
        }

        if (!IsPostBack)
        {
            ViewState["i"] = 0;
            i = (int)ViewState["i"];
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * from "+dbname, con);
            ds = new DataSet();
            ad.Fill(ds, "ques");
            TextBox1.Text = ds.Tables[0].Rows[i]["ques"].ToString();
            TextBox2.Text = ds.Tables[0].Rows[i]["opt1"].ToString();
            TextBox3.Text = ds.Tables[0].Rows[i]["opt2"].ToString();
            TextBox4.Text = ds.Tables[0].Rows[i]["opt3"].ToString();
            TextBox5.Text = ds.Tables[0].Rows[i]["opt4"].ToString();
            QNoLabel.Text = (i + 1).ToString();
            con.Close();          
        }
    }

    public void EmptyCell()
    {
        cell1.Attributes.Add("style", "background-color:white");
        cell2.Attributes.Add("style", "background-color:white");
        cell3.Attributes.Add("style", "background-color:white");
        cell4.Attributes.Add("style", "background-color:white");
    }
    public void ChangeCol()
    {
        RadioButton1.Checked = false;
        RadioButton2.Checked = false;
        RadioButton3.Checked = false;
        RadioButton4.Checked = false;
        i = (int)ViewState["i"];
        SqlDataAdapter ad = new SqlDataAdapter("SELECT * from "+dbname, con);
        ds = new DataSet();
        ad.Fill(ds, "ques");
        String cmp = (ds.Tables[0].Rows[i]["selected"]).ToString();
        if(TextBox2.Text==cmp)
        {
            RadioButton1.Checked = true;
            cell1.Attributes.Add("style", "background-color:#90ee90");
        }
        if (TextBox3.Text == cmp)
        {
            RadioButton2.Checked = true;
            cell2.Attributes.Add("style", "background-color:#90ee90");
        }
        if (TextBox4.Text == cmp)
        {
            RadioButton3.Checked = true;
            cell3.Attributes.Add("style", "background-color:#90ee90");
        }
        if (TextBox5.Text == cmp)
        {
            RadioButton4.Checked = true;
            cell4.Attributes.Add("style", "background-color:#90ee90");
        }
    }
    public void FunCall()
    {
        i = (int)ViewState["i"];
        SqlDataAdapter ad = new SqlDataAdapter("SELECT * from "+dbname, con);
        ds = new DataSet();
        ad.Fill(ds, "ques");
        TextBox1.Text = ds.Tables[0].Rows[i]["ques"].ToString();
        TextBox2.Text = ds.Tables[0].Rows[i]["opt1"].ToString();
        TextBox3.Text = ds.Tables[0].Rows[i]["opt2"].ToString();
        TextBox4.Text = ds.Tables[0].Rows[i]["opt3"].ToString();
        TextBox5.Text = ds.Tables[0].Rows[i]["opt4"].ToString();
        QNoLabel.Text = (i + 1).ToString(); 
    }
    public void buttonCol()
    {
        SqlDataAdapter ad = new SqlDataAdapter("SELECT * from " + dbname, con);
        ds = new DataSet();
        ad.Fill(ds, "ques");
        if ((ds.Tables[0].Rows[0]["selected"]).ToString() != "not attempted")
        {
            Button1.Attributes.Add("style", "background-color:#00e6e6");
        }
        if ((ds.Tables[0].Rows[1]["selected"]).ToString() != "not attempted")
        {
            Button2.Attributes.Add("style", "background-color:#00e6e6");
        }
        if ((ds.Tables[0].Rows[2]["selected"]).ToString() != "not attempted")
        {
            Button3.Attributes.Add("style", "background-color:#00e6e6");
        }
        if ((ds.Tables[0].Rows[3]["selected"]).ToString() != "not attempted")
        {
            Button4.Attributes.Add("style", "background-color:#00e6e6");
        }
        if ((ds.Tables[0].Rows[4]["selected"]).ToString() != "not attempted")
        {
            Button5.Attributes.Add("style", "background-color:#00e6e6");
        }
        if ((ds.Tables[0].Rows[5]["selected"]).ToString() != "not attempted")
        {
            Button6.Attributes.Add("style", "background-color:#00e6e6");
        }
        if ((ds.Tables[0].Rows[6]["selected"]).ToString() != "not attempted")
        {
            Button7.Attributes.Add("style", "background-color:#00e6e6");
            Label2.Text = "Answered";
        }
        if ((ds.Tables[0].Rows[7]["selected"]).ToString() != "not attempted")
        {
            Button8.Attributes.Add("style", "background-color:#00e6e6");
        }
        if ((ds.Tables[0].Rows[8]["selected"]).ToString() != "not attempted")
        {
            Button9.Attributes.Add("style", "background-color:#00e6e6");
        }
        if ((ds.Tables[0].Rows[9]["selected"]).ToString() != "not attempted")
        {
            Button10.Attributes.Add("style", "background-color:#00e6e6");
        }
        Status();
    }

    public void Status()
    {
        int NOQ=(int)ViewState["i"];
        SqlDataAdapter ad = new SqlDataAdapter("SELECT * from " + dbname, con);
        ds = new DataSet();
        ad.Fill(ds, "ques");
        if((ds.Tables[0].Rows[NOQ]["selected"]).ToString() == "not attempted")
        {
            Label2.Attributes.Add("style", "background-color:#ccccff");
            Label2.Text = "Not Answered";
        }
        else
        {
            Label2.Attributes.Add("style", "background-color:#00e6e6");
            Label2.Text = "Answered";
        }
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        Session["opt"]= "";
        
        if(RadioButton1.Checked)
        {
            Session["opt"] = TextBox2.Text;
        }
        if(RadioButton2.Checked)
        {
            Session["opt"] = TextBox3.Text;
        }
        if(RadioButton3.Checked)
        {
            Session["opt"] = TextBox4.Text;
        }
        if(RadioButton4.Checked)
        {
            Session["opt"] = TextBox5.Text;
            
        }
        if (Session["opt"] == "")
        {
            ErrLabel.Text = "Please select an option!!";
        }
        else
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update "+dbname+" set selected=" + "'" + Session["opt"].ToString() + "'" + " where ques=" + "'" + TextBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;
        }
        ChangeCol();
        buttonCol();
      
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        RadioButton1.Checked = false;
        RadioButton2.Checked = false;
        RadioButton3.Checked = false;
        RadioButton4.Checked = false;
        EmptyCell();
        try
        {
            i = (int)ViewState["i"] - 1;
            ViewState["i"] = i;
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * from "+dbname, con);
            ds = new DataSet();
            ad.Fill(ds, "ques");
            TextBox1.Text = ds.Tables[0].Rows[i]["ques"].ToString();
            TextBox2.Text = ds.Tables[0].Rows[i]["opt1"].ToString();
            TextBox3.Text = ds.Tables[0].Rows[i]["opt2"].ToString();
            TextBox4.Text = ds.Tables[0].Rows[i]["opt3"].ToString();
            TextBox5.Text = ds.Tables[0].Rows[i]["opt4"].ToString();
            ChangeCol();
            buttonCol();
            QNoLabel.Text = (i + 1).ToString();
        }
        catch(Exception ea)
        {
            ViewState["i"] = 0;
            ErrLabel.Text = "No More Questions Below That!!";
            ChangeCol();
            buttonCol();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ViewState["i"] = 0;
        i=(int)ViewState["i"];
        FunCall();
        EmptyCell();
        ChangeCol();
        buttonCol();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ViewState["i"] = 1;
        i = (int)ViewState["i"];
        FunCall();
        EmptyCell();
        ChangeCol();
        buttonCol();
    }
    protected void Button3_Click1(object sender, EventArgs e)
    {
        ViewState["i"] = 2;
        i = (int)ViewState["i"];
        FunCall();
        EmptyCell();
        ChangeCol();
        buttonCol();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        ViewState["i"] = 3;
        i = (int)ViewState["i"];
        FunCall();
        EmptyCell();
        ChangeCol();
        buttonCol();
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        ViewState["i"] = 4;
        i = (int)ViewState["i"];
        FunCall();
        EmptyCell();
        ChangeCol();
        buttonCol();
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        ViewState["i"] = 5;
        i = (int)ViewState["i"];
        FunCall();
        EmptyCell();
        ChangeCol();
        buttonCol();
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        ViewState["i"] = 6;
        i = (int)ViewState["i"];
        FunCall();
        EmptyCell();
        ChangeCol();
        buttonCol();
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        ViewState["i"] = 7;
        i = (int)ViewState["i"];
        FunCall();
        EmptyCell();
        ChangeCol();
        buttonCol();
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        ViewState["i"] = 8;
        i = (int)ViewState["i"];
        FunCall();
        EmptyCell();
        ChangeCol();
        buttonCol();
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        ViewState["i"] = 9;
        i = (int)ViewState["i"];
        FunCall();
        EmptyCell();
        ChangeCol();
        buttonCol();
    }

    protected void Button13_Click(object sender, EventArgs e)
    {
        RadioButton1.Checked = false;
        RadioButton2.Checked = false;
        RadioButton3.Checked = false;
        RadioButton4.Checked = false;
        EmptyCell();
        try
        {
            i = (int)ViewState["i"] + 1;
            ViewState["i"] = i;
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * from "+dbname, con);
            ds = new DataSet();
            ad.Fill(ds, "ques");
            TextBox1.Text = ds.Tables[0].Rows[i]["ques"].ToString();
            TextBox2.Text = ds.Tables[0].Rows[i]["opt1"].ToString();
            TextBox3.Text = ds.Tables[0].Rows[i]["opt2"].ToString();
            TextBox4.Text = ds.Tables[0].Rows[i]["opt3"].ToString();
            TextBox5.Text = ds.Tables[0].Rows[i]["opt4"].ToString();
            ChangeCol();
            buttonCol();
            QNoLabel.Text = (i + 1).ToString();
        }
        catch(Exception ea)
        {
            ViewState["i"] = 9;
            ErrLabel.Text = "No more Questions please submit!!";
            ChangeCol();
            buttonCol();
        }
    }
    protected void timer1_tick(object sender, EventArgs e)
    {
        if (0 > DateTime.Compare(DateTime.Now, DateTime.Parse(Session["timeout"].ToString())))
        {
            lblTimer.Text = string.Format("00:{00}:{1}", ((Int32)DateTime.Parse(Session["timeout"].ToString()).Subtract(DateTime.Now).TotalMinutes).ToString(), ((Int32)DateTime.Parse(Session["timeout"].ToString()).Subtract(DateTime.Now).Seconds).ToString());
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