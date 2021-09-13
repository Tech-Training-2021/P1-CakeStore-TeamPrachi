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
    public partial class signupPage : System.Web.UI.Page
    {
        string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkuser())
                Response.Write("<script>alert('UserName already Exist. Try Again ');</script>");
            else
            {
                signUp();
                Response.Redirect("loginpage.aspx");
            }
                

        }

        bool checkuser()
        {
            try
            {
                SqlConnection conn = new SqlConnection(constr);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("select * from UserTbl where userId = '"+TextBox8.Text.Trim()+"' ", conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Response.Write("<script> alert('" + ex.Message + "'); </script>");
                return false;
            }
        }

        void signUp()
        {
            try
            {
                SqlConnection conn = new SqlConnection(constr);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("addUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fullName", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@dob", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@contactNo", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@email", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@state", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@city", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@pincode", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@fullAddress", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@userId", TextBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@password", TextBox9.Text.Trim());

                cmd.ExecuteNonQuery();
                conn.Close();
                Response.Write("<script>alert('Sign Up Successful. Go to Login');</script>");

            }
            catch (Exception ex)
            {
                Response.Write("<script> alert('" + ex.Message + "'); </script>");
            }
        }

    }
}