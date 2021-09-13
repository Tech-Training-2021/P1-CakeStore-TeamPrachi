using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CakeStoreWebApplication
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["username"] != null)
                {
                    LinkButton1.Visible = false;
                    LinkButton2.Visible = false;
                    LinkButton3.Visible = true;
                    LinkButton7.Visible = true;
                    LinkButton7.Text = "Hello " + Session["username"].ToString();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script> alert('" + ex.Message + "'); </script>");
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginpage.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("signupPage.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('You are now logged out');</script>");
            Session["username"] = "";
            LinkButton1.Visible = true; 
            LinkButton2.Visible = true;
            LinkButton3.Visible = false; 
            LinkButton7.Visible = false; 

        }
    }
}