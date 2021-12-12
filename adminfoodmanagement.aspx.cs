using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodShop
{
    public partial class adminfoodmanagement1 : System.Web.UI.Page
    {
        private string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }


        //go button
        protected void Button1_Click(object sender, EventArgs e)
        {
            GetFoodByID();
        }



        //add button
        protected void Button_Click(object sender, EventArgs e)
        {
            if (CheckIfFoodExists())
            {
                Response.Write("<script>alert('Food with this ID already Exist. You cannot add another Food with the same Food ID');</script>");
            }
            else
            {
                AddNewFood();
            }
        }

     

        //update button
        protected void Button2_Click1(object sender, EventArgs e)
        {
            if (CheckIfFoodExists())
            {
                UpdateFood();

            }
            else
            {
                Response.Write("<script>alert('Food does not exist');</script>");
            }
        }


        //delete button
        protected void Button3_Click1(object sender, EventArgs e)
        {
            if (CheckIfFoodExists())
            {
                DeleteFood();

            }
            else
            {
                Response.Write("<script>alert('Food does not exist');</script>");
            }
        }

     

        // user defined function
        private void GetFoodByID()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from food_table where food_id='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0][1].ToString();
                    TextBox3.Text = dt.Rows[0][2].ToString();
                    TextBox4.Text = dt.Rows[0][3].ToString();
                    TextBox5.Text = dt.Rows[0][4].ToString();
                    TextBox6.Text = dt.Rows[0][5].ToString();
                    TextBox7.Text = dt.Rows[0][6].ToString();
                    TextBox8.Text = dt.Rows[0][7].ToString();
                    TextBox9.Text = dt.Rows[0][8].ToString();
                    TextBox10.Text = dt.Rows[0][9].ToString();
                    TextBox11.Text = dt.Rows[0][10].ToString();
                    TextBox12.Text = dt.Rows[0][11].ToString();
                    TextBox13.Text = dt.Rows[0][12].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid Food ID');</script>");
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }

        private void DeleteFood()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE from food_table WHERE food_id='" + TextBox1.Text.Trim() + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Food Deleted Successfully');</script>");
                clearForm();
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        private void UpdateFood()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE food_table SET food_name=@food_name,category=@category,price=@price,supplier=@supplier,obtained_date=@obtained_date,food_flavor=@food_flavor,expire_date=@expire_date,food_cost=@food_cost,food_unit=@food_unit,food_discription=@food_discription,actual_stock=@actual_stock,current_stock=@current_stock WHERE food_id='" + TextBox1.Text.Trim() + "'", con);


                cmd.Parameters.AddWithValue("@food_name", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@category", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@price", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@supplier", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@obtained_date", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@food_flavor", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@expire_date", TextBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@food_cost", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@food_unit", TextBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@food_discription", TextBox11.Text.Trim());
                cmd.Parameters.AddWithValue("@actual_stock", TextBox12.Text.Trim());
                cmd.Parameters.AddWithValue("@current_stock", TextBox13.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Food Updated Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        private void AddNewFood()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO food_table(food_id,food_name,category,price,supplier,obtained_date,food_flavor,expire_date,food_cost,food_unit,food_discription,actual_stock,current_stock) values(@food_id,@food_name,@category,@price,@supplier,@obtained_date,@food_flavor,@expire_date,@food_cost,@food_unit,@food_discription,@actual_stock,@current_stock)", con);

                cmd.Parameters.AddWithValue("@food_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@food_name", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@category", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@price", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@supplier", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@obtained_date", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@food_flavor", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@expire_date", TextBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@food_cost", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@food_unit", TextBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@food_discription", TextBox11.Text.Trim());
                cmd.Parameters.AddWithValue("@actual_stock", TextBox12.Text.Trim());
                cmd.Parameters.AddWithValue("@current_stock", TextBox13.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Food added Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        private bool CheckIfFoodExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from food_table where food_id='" + TextBox1.Text.Trim() + "';", con);
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

        private void clearForm()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }


}
