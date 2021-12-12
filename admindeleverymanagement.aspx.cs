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
    public partial class admindeleverymanagement : System.Web.UI.Page
    {
        private string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }

        //go button
        protected void Button1_Click(object sender, EventArgs e)
        {
            GetDeleveryByID();
        }

        //add button
        protected void Button_Click(object sender, EventArgs e)
        {
            if (CheckIfDeleveryExists())
            {
                Response.Write("<script>alert('Docter with this ID already Exist. You cannot add another Docter with the same Docter ID');</script>");
            }
            else
            {
                AddNewDelevery();
            }
        }

        //update button
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (CheckIfDeleveryExists())
            {
                UpdateDelevery();

            }
            else
            {
                Response.Write("<script>alert('Delevery does not exist');</script>");
            }
        }

        //delete button
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (CheckIfDeleveryExists())
            {
                DeleteDelevery();

            }
            else
            {
                Response.Write("<script>alert('Delevery does not exist');</script>");
            }

        }

        // user defined function
        private void GetDeleveryByID()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from delevery_master_table where delevery_id='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0][1].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid delevery ID');</script>");
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }

        private void DeleteDelevery()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE from delevery_master_table WHERE delevery_id='" + TextBox1.Text.Trim() + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Delevery Deleted Successfully');</script>");
                clearForm();
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        private void UpdateDelevery()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE delevery_master_table SET delevery_name=@delevery_name WHERE delevery_id='" + TextBox1.Text.Trim() + "'", con);


                cmd.Parameters.AddWithValue("@delevery_name", TextBox2.Text.Trim());
               

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Delevery Updated Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        private void AddNewDelevery()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO delevery_master_table(delevery_id,delevery_name) values(@delevery_id,@delevery_name)", con);

                cmd.Parameters.AddWithValue("@delevery_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@delevery_name", TextBox2.Text.Trim());
                

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Delevery added Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        private bool CheckIfDeleveryExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open(); 
                }

                SqlCommand cmd = new SqlCommand("SELECT * from delevery_master_table where delevery_id='" + TextBox1.Text.Trim() + "';", con);
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