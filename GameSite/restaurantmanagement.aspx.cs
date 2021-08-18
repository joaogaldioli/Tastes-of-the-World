using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameSite
{
    public partial class restaurantmanagement : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }
        // Add button clicked
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (checkIfRestaurantExists())
            {
                Response.Write("<script>alert('Restaurant with this ID already exists. Please use another ID');</script>");
            }
            else
            {
                addNewRestaurant();
            }
        }
        // Update button clicked
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (checkIfRestaurantExists())
            {
                updateRestaurant();

            }
            else
            {
                Response.Write("<script>alert('Restaurant does not exist');</script>");
            }
        }
        // Delete button clicked
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (checkIfRestaurantExists())
            {
                deleteRestaurant();

            }
            else
            {
                Response.Write("<script>alert('Restaurant does not exist');</script>");
            }
        }
        // GO button click
        protected void Button1_Click(object sender, EventArgs e)
        {
            getRestaurantByID();
        }



        // user defined function
        void getRestaurantByID()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM restaurant_master_tbl WHERE restaurant_id='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0][1].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid Restaurant ID');</script>");
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }


        void deleteRestaurant()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE FROM restaurant_master_tbl WHERE restaurant_id='" + TextBox1.Text.Trim() + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Restaurant Deleted Successfully');</script>");
                clearBoxes();
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void updateRestaurant()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE restaurant_master_tbl SET restaurant_name=@restaurant_name WHERE restaurant_id='" 
                    + TextBox1.Text.Trim() + "'", con);

                cmd.Parameters.AddWithValue("@restaurant_name", TextBox2.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Restaurant Updated Successfully');</script>");
                clearBoxes();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }


        void addNewRestaurant()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO restaurant_master_tbl(restaurant_id,restaurant_name) values(@restaurant_id,@restaurant_name)", con);

                cmd.Parameters.AddWithValue("@restaurant_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@restaurant_name", TextBox2.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Restaurant Added Successfully');</script>");
                clearBoxes();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }



        bool checkIfRestaurantExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from restaurant_master_tbl WHERE restaurant_id='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }

        void clearBoxes()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}
