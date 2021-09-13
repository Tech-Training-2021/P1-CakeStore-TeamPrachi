using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CakeStoreWebApplication
{
    public partial class loginpage : System.Web.UI.Page
    {
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(constr);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("Select * from UserTbl where userId='"+TextBox1.Text.Trim()+ "' AND password='"+TextBox2.Text.Trim()+"'", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    { 
                        Session["username"] = reader.GetValue(8).ToString();
                    }
                    Response.Redirect("homepage.aspx");
                }
                else
                    Response.Write("<script>alert('Invalid Credentials. Try Again.');</script>");
            }
            catch(Exception ex)
            {
                Response.Write("<script> alert('" + ex.Message + "'); </script>");
            }
        }
    }
}