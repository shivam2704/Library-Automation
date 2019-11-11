using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class LoginPage : System.Web.UI.Page
{
   
    
    
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
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            
            
            String str = "select password from admin where name='" + TextBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(str,con);
           // cmd.Parameters.AddWithValue("@pass","beontime");
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select password from admin where name='" + TextBox1.Text + "'";
            cmd.ExecuteNonQuery();
           // Response.Write("success");

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                String ps;
                //uname = ds.Tables[0].Rows[0]["name"].ToString();
                ps = ds.Tables[0].Rows[0]["password"].ToString();



                if (TextBox2.Text == ps)
                {

                    Session["username"] = TextBox1.Text;//for session control
                    Response.Redirect("infoadmin.aspx");//this redirects page
                }
                else
                {
                    Label3.Text = "Wrong password";
                }
            }
            else
            {
                Label3.Text = "Unregistered Admin";
            }
            con.Close();
        }
        catch (Exception err)
        {
            Console.WriteLine(err);
        }
    }
}