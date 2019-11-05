using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class LoginPage : System.Web.UI.Page
{
    MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=librarydata;User Id=root;password='Sql@123Sql'");
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Label1.Visible = false;
        Label2.Visible = false;
        TextBox1.Visible = false;
        TextBox2.Visible = false;
        ImageButton3.Visible = false;
        Response.Redirect("infouser.aspx");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Label1.Visible = true;
        Label2.Visible = true;
        TextBox1.Visible = true;
        TextBox2.Visible = true;
        ImageButton3.Visible = true;
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select password from admin where name='" + TextBox1.Text + "'";
            cmd.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;

            DataSet ds = new DataSet();
            da.Fill(ds);

            String ps;
            //uname = ds.Tables[0].Rows[0]["name"].ToString();
            ps = ds.Tables[0].Rows[0]["password"].ToString();
            con.Close();

            if (TextBox2.Text == ps)
            {
                Session["username"] = TextBox1.Text;
                Response.Redirect("infoadmin.aspx");
            }
            else
            {
                Label3.Text = "Wrong password";
            }
        }
        catch (Exception err)
        {
            Console.WriteLine(err);
            Label3.Text = "Uneregistered Admin";
        }
    }
}