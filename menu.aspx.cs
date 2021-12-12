using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FoodShop
{
    public partial class menu : System.Web.UI.Page
    {
        private string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "MASALA PALANDI CHEESE KOTHTHU");
                cmd.Parameters.AddWithValue("@Price", "800");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "MASALA CHICKEN CHEESE KOTHTHU");
                cmd.Parameters.AddWithValue("@Price", "700");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "SPECIAL DOLPHIN CHEESE KOTHTHU");
                cmd.Parameters.AddWithValue("@Price", "550");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "PALANDI CHEESE KOTHTHU");
                cmd.Parameters.AddWithValue("@Price", "700");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "CHEESE CHICKEN KOTHTHU");
                cmd.Parameters.AddWithValue("@Price", "550");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "MUTTON CHEESE KOTHTHU");
                cmd.Parameters.AddWithValue("@Price", "1200");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "MIX CHEESE KOTHTHU");
                cmd.Parameters.AddWithValue("@Price", "1200");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "CHICKEN KOTHTHU");
                cmd.Parameters.AddWithValue("@Price", "400");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "PORK KOTHTHU");
                cmd.Parameters.AddWithValue("@Price", "400");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "FISH KOTHTHU");
                cmd.Parameters.AddWithValue("@Price", "400");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button11_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "EGG KOTHTHU");
                cmd.Parameters.AddWithValue("@Price", "320");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button12_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "VEGETABLE KOTHTHU");
                cmd.Parameters.AddWithValue("@Price", "250");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button13_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "VEGETABLE RICE");
                cmd.Parameters.AddWithValue("@Price", "300");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button14_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "EGG RICE");
                cmd.Parameters.AddWithValue("@Price", "350");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button15_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "SEA FOOD RICE");
                cmd.Parameters.AddWithValue("@Price", "700");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button16_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "MONGOLIAN RICE");
                cmd.Parameters.AddWithValue("@Price", "800");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button17_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "MIX FRIED RICE");
                cmd.Parameters.AddWithValue("@Price", "800");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button18_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "NASIGORENG");
                cmd.Parameters.AddWithValue("@Price", "800");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button19_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "FISH RICE AND CURRY");
                cmd.Parameters.AddWithValue("@Price", "250");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button20_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "CHICKEN RICE AND CURRY");
                cmd.Parameters.AddWithValue("@Price", "280");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button21_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "PRAWNS RICE AND CURRY");
                cmd.Parameters.AddWithValue("@Price", "320");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button22_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "PORK RICE AND CURRY");
                cmd.Parameters.AddWithValue("@Price", "400");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button23_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "FRIED FISH RICE AND CURRY");
                cmd.Parameters.AddWithValue("@Price", "350");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button24_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "WAV MALU RICE AND CURRY");
                cmd.Parameters.AddWithValue("@Price", "350");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button25_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "EGG ROTI");
                cmd.Parameters.AddWithValue("@Price", "50");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button26_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "PARATA");
                cmd.Parameters.AddWithValue("@Price", "25");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button27_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "EGG SHORTIES");
                cmd.Parameters.AddWithValue("@Price", "40");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button28_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "VEGETABLE ROTI");
                cmd.Parameters.AddWithValue("@Price", "40");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button29_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "STRING HOPPERS");
                cmd.Parameters.AddWithValue("@Price", "70");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button30_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "HOPPERS");
                cmd.Parameters.AddWithValue("@Price", "20");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button31_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "DHAL CURRY");
                cmd.Parameters.AddWithValue("@Price", "60");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button32_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "CHICKEN CURRY");
                cmd.Parameters.AddWithValue("@Price", "150");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button33_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "PORK CURRY");
                cmd.Parameters.AddWithValue("@Price", "400");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button34_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO cart(Product,Price) values(@Product,@Price)", con);
                cmd.Parameters.AddWithValue("@Product", "PRAWNS CURRY");
                cmd.Parameters.AddWithValue("@Price", "400");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}