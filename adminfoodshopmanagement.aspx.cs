using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace FoodShop
{
    public partial class adminfoodshopmanagement : System.Web.UI.Page
    {

        private string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }

        //go Button
        protected void Button4_Click(object sender, EventArgs e)
        {
            getNames();
        }


        //issue
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (CheckIfFoodExist() == "true" && CheckIfMemberExist() == "true")
            {

                if (CheckIfIssueEntryExist())
                {
                    Response.Write("<script>alert('This Member already has this Food');</script>");
                }
                else
                {
                    issueFood();
                }

            }
            else
            {
                Response.Write("<script>alert('Wrong Book ID or Member ID');</script>");
            }
        }

        //Return
        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                if (CheckIfFoodExist() == "true" && CheckIfMemberExist() == "true")
                {

                    if (CheckIfIssueEntryExist())
                    {
                        returnFood();
                    }
                    else
                    {
                        Response.Write("<script>alert('This Entry does not exist');</script>");
                    }

                }
                else
                {
                    Response.Write("<script>alert('Wrong Food ID or Member ID');</script>");
                }
            }
        }


        //user define Function
        void returnFood()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                SqlCommand cmd = new SqlCommand("Delete from food_issue_table WHERE food_id='" + TextBox4.Text.Trim() + "' AND member_id='" + TextBox3.Text.Trim() + "'", con);
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {

                    cmd = new SqlCommand("update food_table set current_stock = current_stock+1 WHERE food_id='" + TextBox4.Text.Trim() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    Response.Write("<script>alert('Food Returned Successfully');</script>");
                    GridView1.DataBind();

                    con.Close();

                }
                else
                {
                    Response.Write("<script>alert('Error - Invalid details');</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }





        void issueFood()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO food_issue_table(member_id,food_id,member_name,food_name,order_date,delivery_date) values(@member_id,@food_id,@member_name,@food_name,@order_date,@delivery_date)", con);

                cmd.Parameters.AddWithValue("@member_id", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@food_id", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@member_name", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@food_name", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@order_date", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@delivery_date", TextBox6.Text.Trim());

                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("update food_table set current_stock = current_stock-1 WHERE food_id='" + TextBox4.Text.Trim() + "'", con);

                cmd.ExecuteNonQuery();

                con.Close();
                Response.Write("<script>alert('Food Issued Successfully');</script>");

                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        string CheckIfFoodExist()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select * from food_table WHERE food_id='" + TextBox4.Text.Trim() + "' AND current_stock >0", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    return "true";
                }
                else
                {
                    return "true";
                }
            }
            catch (Exception ex)
            {
                return "true";
            }

        }


        string CheckIfMemberExist()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select full_name from member_master_table WHERE member_id='" + TextBox3.Text.Trim() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    return "true";
                }
                else
                {
                    return "true";
                }
            }
            catch (Exception ex)
            {
                return "true";
            }

        }


        bool CheckIfIssueEntryExist()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select * from food_issue_table WHERE member_id='" + TextBox3.Text.Trim() + "' AND food_id='" + TextBox4.Text.Trim() + "'", con);
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
                return false;
            }

        }



        void getNames()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select food_name from food_table WHERE food_id='" + TextBox4.Text.Trim() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0]["food_name"].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Wrong Food ID');</script>");
                }

                cmd = new SqlCommand("select full_name from member_master_table WHERE member_id='" + TextBox3.Text.Trim() + "'", con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    TextBox1.Text = dt.Rows[0]["full_name"].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Wrong User ID');</script>");
                }


            }
            catch (Exception ex)
            {

            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    //Check your condition here
                    DateTime dt = Convert.ToDateTime(e.Row.Cells[5].Text);
                    DateTime today = DateTime.Today;
                    if (today > dt)
                    {
                        e.Row.BackColor = System.Drawing.Color.PaleVioletRed;
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}