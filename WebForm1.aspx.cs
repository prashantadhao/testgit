using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace DataBaseDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\\COLLEGE WORK\\TECSEDEMO\\P15-1109\\DataBaseDemo\\DataBaseDemo\\App_Data\\Database1.mdf;Integrated Security=True"].ConnectionString);
            con.Open();

           // string ins = "insert into student(rollno, name, lname) values(@uroll, @uname, @ulname)";

            string ins = "insert into student(rollno, name, lname) values('"+TextBox1.Text+"', '"+TextBox2.Text+"', '"+TextBox3.Text+"')";
            SqlCommand cmd = new SqlCommand(ins,con);
            
        /*    cmd.Parameters.AddWithValue("@uroll", TextBox1.Text );
            cmd.Parameters.AddWithValue("@uname", TextBox2.Text);
            cmd.Parameters.AddWithValue("@ulname", TextBox3.Text);*/

            cmd.ExecuteNonQuery();
            Response.Write("Data Inserted Sucessfuly");

            con.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Display.aspx");
        }

        
    }
}