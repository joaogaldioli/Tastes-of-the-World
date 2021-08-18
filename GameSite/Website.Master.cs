using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameSite
{
    public partial class Website : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"] == null)
                {
                    // User Login Button
                    LinkButton1.Visible = true;
                    // Sign Up Link Button
                    LinkButton2.Visible = true;
                    // Logout button
                    LinkButton3.Visible = false;
                    // Hello User Button
                    LinkButton7.Visible = false;
                    // Admin Login
                    LinkButton6.Visible = true;

                    // All other admin links
                    LinkButton8.Visible = false;

                    LinkButton9.Visible = false;

                    LinkButton10.Visible = false;

                    LinkButton11.Visible = false;

                    LinkButton12.Visible = false;
                }
                else if (Session["role"].Equals("user"))
                {
                    // User Login Button
                    LinkButton1.Visible = false;
                    // Sign Up Link Button
                    LinkButton2.Visible = false;
                    // Logout button
                    LinkButton3.Visible = true;
                    // Hello User Button
                    LinkButton7.Visible = true;
                    // Get user_id
                    LinkButton7.Text = "Hello " + Session["user_id"].ToString();
                    // Admin Login
                    LinkButton6.Visible = true;

                    // All other admin links
                    LinkButton8.Visible = false;

                    LinkButton9.Visible = false;

                    LinkButton10.Visible = false;

                    LinkButton11.Visible = false;

                    LinkButton12.Visible = false;
                }

                else if (Session["role"].Equals("admin"))
                {
                    // User Login Button
                    LinkButton1.Visible = false;
                    // Sign Up Link Button
                    LinkButton2.Visible = false;
                    // Logout button
                    LinkButton3.Visible = true;
                    // Hello User Button
                    LinkButton7.Visible = true;
                    // Get user_id
                    LinkButton7.Text = "Hello Admin";
                    // Admin Login
                    LinkButton6.Visible = false;

                    // All other admin links
                    LinkButton8.Visible = true;

                    LinkButton9.Visible = true;

                    LinkButton10.Visible = true;

                    LinkButton11.Visible = true;

                    LinkButton12.Visible = true;
                }
            }
            catch(Exception ex)
            {

            }
        }

        protected void AdminLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }
        protected void RestaurantManagement_Click(object sender, EventArgs e)
        {
            Response.Redirect("restaurantmanagement.aspx");
        }

        protected void OrderManagement_Click(object sender, EventArgs e)
        {
            Response.Redirect("organizationmanagement.aspx");
        }

        protected void CuisineInventory_Click(object sender, EventArgs e)
        {
            Response.Redirect("menuinventory.aspx");
        }

        protected void FoodManagement_Click(object sender, EventArgs e)
        {
            Response.Redirect("foodadmin.aspx");
        }

        protected void MemberManagement_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminmembermanagement.aspx");
        }

        protected void UserLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void SignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session["user_id"] = "";
            Session["full_name"] = "";
            Session["role"] = "";
            Session["status"] = "";

            // User Login Button
            LinkButton1.Visible = true;
            // Sign Up Link Button
            LinkButton2.Visible = true;
            // Logout button
            LinkButton3.Visible = false;
            // Hello User Button
            LinkButton7.Visible = false;
            // Admin Login
            LinkButton6.Visible = true;

            // All other admin links
            LinkButton8.Visible = false;

            LinkButton9.Visible = false;

            LinkButton10.Visible = false;

            LinkButton11.Visible = false;

            LinkButton12.Visible = false;

            Response.Redirect("homepage.aspx");
        }

    }
}