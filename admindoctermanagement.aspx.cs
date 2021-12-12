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
   
    public partial class admindoctermanagement : System.Web.UI.Page
    {
        private string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }

        //add button click
        protected void Button_Click(object sender, EventArgs e)
        {
            if (checkIfDocterExists())
            {
                Response.Write("<script>alert('Docter with this ID already Exist. You cannot add another Docter with the same Docter ID');</script>");
            }
            else
            {
                addNewDocter();
            }
        }

        // update button click
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (checkIfDocterExists())
            {
                updateDocter();

            }
            else
            {
                Response.Write("<script>alert('Docter does not exist');</script>");
            }
        }

        //delete button Click
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (checkIfDocterExists())
            {
                deleteDocter();

            }
            else
            {
                Response.Write("<script>alert('Docter does not exist');</script>");
            }
        }

        //go button Click
        protected void Button1_Click(object sender, EventArgs e)
        {
            getDocterByID();
        }




        // user defined function
        private void getDocterByID()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from docter_master_table where docter_id='" + TextBox1.Text.Trim() + "';", con);
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
                }
                else
                {
                    Response.Write("<script>alert('Invalid Docter ID');</script>");
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }

        private void deleteDocter()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE from docter_master_table WHERE docter_id='" + TextBox1.Text.Trim() + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Docter Deleted Successfully');</script>");
                clearForm();
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        private void updateDocter()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE docter_master_table SET docter_name=@docter_name,address=@address,email=@email,phone_number=@phone_number,bmi_list=@bmi_list WHERE docter_id='" + TextBox1.Text.Trim() + "'", con);



                cmd.Parameters.AddWithValue("@docter_name", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@address", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@email", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@phone_number", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@bmi_list", TextBox6.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Docter Updated Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        private void addNewDocter()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO docter_master_table(docter_id,docter_name,address,email,phone_number,bmi_list) values(@docter_id,@docter_name,@address,@email,@phone_number,@bmi_list)", con);

                cmd.Parameters.AddWithValue("@docter_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@docter_name", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@address", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@email", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@phone_number", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@bmi_list", TextBox6.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Docter added Successfully');</script>");
                clearForm();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        private bool checkIfDocterExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from docter_master_table where docter_id='" + TextBox1.Text.Trim() + "';", con);
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