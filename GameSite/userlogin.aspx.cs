using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameSite
{
    public partial class userlogin : System.Web.UI.Page
    {

        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Login Button Click event
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                
                    SqlCommand cmd = new SqlCommand("SELECT * FROM user_info_tbl WHERE user_id='"+TextBox1.Text.Trim()+
                        "' AND password='"+TextBox2.Text.Trim()+"';", con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Session["user_id"] = dr.GetValue(0).ToString();
                            Session["full_name"] = dr.GetValue(2).ToString();
                            Session["role"] = "user";
                            Session["account_status"] = dr.GetValue(10).ToString();
                        }
                        Response.Redirect("homepage.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid Login, Please Try Again');</script>");
                    }
                    
                
            }
            catch(Exception ex)
            {

            }
            //Response.Write("<script>alert('Button clicked');</script>");
        }
    }
}