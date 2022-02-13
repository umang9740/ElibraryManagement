using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class usersignup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        // validation start
        if(TextBox1.Text=="" || TextBox2.Text=="" || TextBox3.Text=="" || TextBox4.Text=="" || TextBox5.Text=="" || TextBox6.Text=="" || TextBox7.Text=="" || TextBox8.Text=="" || TextBox9.Text=="" || DropDownList1.SelectedItem.Value=="")
        {
            Response.Write("<script>alert('Plese anter All Filleds')</script>");
        }
    }
}