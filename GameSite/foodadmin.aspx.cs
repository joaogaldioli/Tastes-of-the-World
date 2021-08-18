using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameSite
{
    public partial class foodadmin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        static string global_filepath;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillRestaurantValue();
            }

            GridView1.DataBind();
        }

        // go button click
        protected void Button4_Click(object sender, EventArgs e)
        {
            getFoodByID();
        }


        // Update button clicked
        protected void Button3_Click(object sender, EventArgs e)
        {
            updateFoodByID();
        }
        // Delete button clicked
        protected void Button2_Click(object sender, EventArgs e)
        {
            deleteFoodByID();
        }
        // add button click
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkIfFoodExists())
            {
                Response.Write("<script>alert('Food Already Exists, Try Adding Another');</script>");
            }
            else
            {
                addNewFood();
            }
        }



        // user defined functions

        void deleteFoodByID()
        {
            if (checkIfFoodExists())
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("DELETE FROM food_admin_tbl WHERE food_id='" + TextBox1.Text.Trim() + "'", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('Food Deleted Successfully');</script>");

                    GridView1.DataBind();

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('Invalid Food ID');</script>");
            }
        }

        void updateFoodByID()
        {

            if (checkIfFoodExists())
            {
                try
                {
                    string cuisine = "";
                    foreach (int i in ListBox1.GetSelectedIndices())
                    {
                        cuisine = cuisine + ListBox1.Items[i] + ",";
                    }
                    cuisine = cuisine.Remove(cuisine.Length - 1);
                    /*
                    string filepath = "~/food_inventory/food1";
                    string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
                    if (filename == "" || filename == null)
                    {
                        filepath = global_filepath;

                    }
                    else
                    {
                        FileUpload1.SaveAs(Server.MapPath("food_inventory/" + filename));
                        filepath = "~/food_inventory/" + filename;
                    }
                    */
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    // ADD IMAGE LINKS LATER
                    SqlCommand cmd = new SqlCommand("UPDATE food_admin_tbl SET food_name=@food_name, cuisine=@cuisine, restaurant_name=@restaurant_name, " +
                        " date_added=@date_added, food_cost=@food_cost, food_description=@food_description WHERE food_id='" + TextBox1.Text.Trim() + "'", con);

                    cmd.Parameters.AddWithValue("@food_name", TextBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@cuisine", cuisine);
                    cmd.Parameters.AddWithValue("@restaurant_name", DropDownList1.SelectedItem.Value);
                    cmd.Parameters.AddWithValue("@date_added", TextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@food_cost", TextBox8.Text.Trim());
                    cmd.Parameters.AddWithValue("@food_description", TextBox6.Text.Trim());

                    cmd.ExecuteNonQuery();
                    con.Close();
                    GridView1.DataBind();
                    Response.Write("<script>alert('Food Updated Successfully');</script>");


                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid Food ID');</script>");
            }
        }


        void getFoodByID()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM food_admin_tbl WHERE food_id='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0]["food_name"].ToString();
                    TextBox3.Text = dt.Rows[0]["date_added"].ToString();
                    TextBox8.Text = dt.Rows[0]["food_cost"].ToString().Trim();
                    TextBox6.Text = dt.Rows[0]["food_description"].ToString();

                    DropDownList1.SelectedValue = dt.Rows[0]["restaurant_name"].ToString().Trim();

                    ListBox1.ClearSelection();
                    string[] cuisine = dt.Rows[0]["cuisine"].ToString().Trim().Split(',');
                    for (int i = 0; i < cuisine.Length; i++)
                    {
                        for (int j = 0; j < ListBox1.Items.Count; j++)
                        {
                            if (ListBox1.Items[j].ToString() == cuisine[i])
                            {
                                ListBox1.Items[j].Selected = true;

                            }
                        }
                    }

                    // DO IMAGE LINK HERE

                }
                else
                {
                    Response.Write("<script>alert('Invalid Food ID');</script>");
                }

            }
            catch (Exception ex)
            {

            }
        }

        void fillRestaurantValue()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT restaurant_name FROM restaurant_master_tbl;", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownList1.DataSource = dt;
                DropDownList1.DataValueField = "restaurant_name";
                DropDownList1.DataBind();

            }
            catch (Exception ex)
            {

            }
        }

        bool checkIfFoodExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM food_admin_tbl WHERE food_id='" + TextBox1.Text.Trim() + "' OR food_name='" + TextBox2.Text.Trim() + "';", con);
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

        void addNewFood()
        {
            try
            {
                string cuisine = "";
                foreach (int i in ListBox1.GetSelectedIndices())
                {
                    cuisine = cuisine + ListBox1.Items[i] + ",";
                }
                cuisine = cuisine.Remove(cuisine.Length - 1);

                /*
                string filepath = "~/food_inventory/foods1.png";
                string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
                FileUpload1.SaveAs(Server.MapPath("food_inventory/" + filename));
                filepath = "~/food_inventory/" + filename;
                */

                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                // IMAGE LINK HERE AS WELL
                SqlCommand cmd = new SqlCommand("INSERT INTO food_admin_tbl(food_id,food_name,restaurant_name,food_cost,date_added,cuisine,food_description) VALUES(@food_id,@food_name,@restaurant_name,@food_cost,@date_added,@cuisine,@food_description)", con);

                cmd.Parameters.AddWithValue("@food_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@food_name", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@cuisine", cuisine);
                cmd.Parameters.AddWithValue("@restaurant_name", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@date_added", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@food_cost", TextBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@food_description", TextBox6.Text.Trim());
                // image link here

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Food added successfully.');</script>");
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}