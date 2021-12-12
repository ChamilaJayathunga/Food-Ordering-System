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
    public partial class cart : System.Web.UI.Page
    {
        private string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        int total=0;
        protected void Page_Load(object sender, EventArgs e)
        {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    string strSql = "SELECT COUNT(*) FROM cart;";
                    SqlCommand command = new SqlCommand(strSql, con);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    
                    if(count>0)
                    {
                        SqlCommand cmd = new SqlCommand("select Product,Price from cart; ", con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        GridView1.DataSource = dr;
                        GridView1.DataBind();
                        con.Close();
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }

                        SqlCommand query = new SqlCommand("select Product,Price from cart; ", con);
                        SqlDataReader data = query.ExecuteReader();
                        while (data.Read())
                            {
                                total += Convert.ToInt32(data["Price"]);
                            }
                        con.Close();
                        Label1.Text = "Total : "+total.ToString();
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                        Button1.Visible=false;
                        Button2.Visible = false;
                }
                    
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            
            SqlCommand query = new SqlCommand("Insert into order_master_table Select Number,Product from cart; ", con);
            SqlDataReader data = query.ExecuteReader();
            con.Close();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand query1 = new SqlCommand("delete from cart; ", con);
            SqlDataReader data1 = query1.ExecuteReader();
            Response.Write("<script>alert(' Order Submited ');</script>");
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand query2 = new SqlCommand("delete from cart; ", con);
            SqlDataReader data1 = query2.ExecuteReader();
            Response.Write("<script>alert(' All Cleared ');</script>");
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
}