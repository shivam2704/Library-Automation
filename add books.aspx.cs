using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class add_books : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnadd_book_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        con.Open();

        String str ="insert into books(title,author_name,publisher,booktype) values(@name,@author_name,@publisher,@booktype)";
        SqlCommand cmd = new SqlCommand(str, con);
         cmd.Parameters.AddWithValue("@name",txtbook_name.Text);
         cmd.Parameters.AddWithValue("@author_name", txtbook_author.Text);
         cmd.Parameters.AddWithValue("@publisher", txtbook_publi.Text);
         cmd.Parameters.AddWithValue("@booktype", ddlbook_type.SelectedItem.ToString());
        //cmd.CommandType = CommandType.Text;
        //cmd.CommandText = "select password from admin
         int i=cmd.ExecuteNonQuery();
        if(i==1)
        {
            lbladd_book.Visible = true;
        }
        con.Close();

        Response.Redirect(Request.Url.AbsoluteUri);
   
    }
    protected void btn_back_Click(object sender, EventArgs e)
    {
      }


}