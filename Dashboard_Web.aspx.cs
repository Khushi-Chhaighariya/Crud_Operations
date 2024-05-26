using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MySql.Data.MySqlClient;

public partial class Dashboard_Web : System.Web.UI.Page
{
    public object TextBox1 { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)//agar kuch pahle data hai to loadrecord save ho jayga
        {
            LoadRecord();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        {
            string cs = "server=localhost;uid=root;pwd=root;database=curdopration";

            MySqlConnection con = new MySqlConnection(cs);

            con.Open();

            MySqlCommand cmd = new MySqlCommand("Insert into Student values('" + int.Parse(TextBox6.Text) + "','" + TextBox7.Text + "','" + DropDownList1.SelectedValue + "','" + double.Parse(TextBox8.Text) + "','" + TextBox9.Text + "')", con);

            cmd.ExecuteNonQuery();//data ko insert delete update krati
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted');", true);
            LoadRecord();
        }

    }
    //data gridview main dikhane k liya
    //loadRecord Hone k bad data grid view main show ho isliya
    void LoadRecord()
    {
        string cs = "server=localhost;uid=root;pwd=root;database=curdopration";
        MySqlConnection con = new MySqlConnection(cs);

        MySqlCommand comm = new MySqlCommand("select * from Student", con);
        MySqlDataAdapter d = new MySqlDataAdapter(comm);
        DataTable dt = new DataTable();//ek ek krke hi to row lani hai
        d.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();//data ko yha pr jor(+) diya bind


    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string cs = "server=localhost;uid=root;pwd=root;database=curdopration";
        MySqlConnection con = new MySqlConnection(cs);
        con.Open();
        MySqlCommand cmd = new MySqlCommand("update student set StudentName = '" + TextBox7.Text + "',Address = '" + DropDownList1.SelectedValue + "', Age = '" + double.Parse(TextBox8.Text) + "', Contact = '" + TextBox9.Text + "' where StudentID = '" + int.Parse(TextBox6.Text) + "'", con);
        cmd.ExecuteNonQuery();
        con.Close();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
        LoadRecord();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        string cs = "server=localhost;uid=root;pwd=root;database=curdopration";
        MySqlConnection con = new MySqlConnection(cs);
        con.Open();
        MySqlCommand cmd = new MySqlCommand("DELETE FROM student WHERE StudentID = '" + int.Parse(TextBox6.Text) + "'", con);
        //MySqlCommand cmd = new MySqlCommand("Delete FROM student where StudentID'" + int.Parse(TextBox6.Text) + "'" , con);
        cmd.ExecuteNonQuery();
        con.Close();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted');", true);
        LoadRecord();


    }

    //sari values string main hoti to int main krne k liya parse use krte
    //data ko search krna hai to uske liya gridview main jo table hai usi main se search krage
    protected void Button4_Click(object sender, EventArgs e)
    {
        string cs = "server=localhost;uid=root;pwd=root;database=curdopration";
        MySqlConnection con = new MySqlConnection(cs);
        MySqlCommand comm = new MySqlCommand("SELECT * FROM student WHERE StudentID = " + int.Parse(TextBox6.Text), con);

        MySqlDataAdapter d = new MySqlDataAdapter(comm);
        DataTable dt = new DataTable();
        d.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();

    }
}

/*
 * Quary:-
 * selete all:-
 * new MySqlCommand("select * from Student", con);
 
 * insert value:-
 new MySqlCommand("Insert into Student values('"+int.Parse(TextBox6.Text)+"','"+TextBox7.Text+"','"+DropDownList1.SelectedValue+"','"+double.Parse(TextBox8.Text)+"','"+TextBox9.Text+"')", con);

delete:-
new MySqlCommand("DELETE FROM student WHERE StudentID = '" + int.Parse(TextBox6.Text)+"'", con);

search:-
new MySqlCommand("SELECT * FROM student WHERE StudentID = " + int.Parse(TextBox6.Text), con);

update:-
new MySqlCommand("update student set StudentName = '" + TextBox7.Text + "',Address = '" + DropDownList1.SelectedValue + "', Age = '"+double.Parse(TextBox8.Text)+"', Contact = '" + TextBox9.Text + "' where StudentID = '" + int.Parse(TextBox6.Text) + "'",con);
 */