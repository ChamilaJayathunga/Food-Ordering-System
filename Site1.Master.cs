using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodShop
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (Session["role"].Equals(""))
                {
                    LinkButton2.Visible = true; // user login link button
                    LinkButton3.Visible = true; // sign up link button

                    LinkButton4.Visible = false; // logout link button
                    LinkButton5.Visible = false; // hello user link button


                    LinkButton6.Visible = true; // admin login link button
                    LinkButton13.Visible = true; // cart
                    LinkButton7.Visible = false; // docter management button
                    LinkButton8.Visible = false; // food management button
                    LinkButton9.Visible = false; //Delevery Management
                    LinkButton10.Visible = false; //order Management
                    LinkButton11.Visible = false; //shop Management
                    LinkButton12.Visible = false; //member Management

                }
                else if (Session["role"].Equals("user"))
                {
                    LinkButton2.Visible = false; // user login link button
                    LinkButton3.Visible = false; // sign up link button

                    LinkButton4.Visible = true; // logout link button
                    LinkButton5.Visible = true; // hello user link button
                    LinkButton5.Text = "Hello  "+Session["username"].ToString();


                    
                    LinkButton6.Visible = true; // admin login link button
                    LinkButton13.Visible = true; // cart
                    LinkButton7.Visible = false; // docter management button
                    LinkButton8.Visible = false; // food management button
                    LinkButton9.Visible = false; //Delevery Management
                    LinkButton10.Visible = false; //order Management
                    LinkButton11.Visible = false; //shop Management
                    LinkButton12.Visible = false; //member Management

                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton2.Visible = false; // user login link button
                    LinkButton3.Visible = false; // sign up link button

                    LinkButton4.Visible = true; // logout link button
                    LinkButton5.Visible = true; // hello user link button
                    LinkButton5.Text = "Hello Admin";


                    LinkButton6.Visible =false; // admin login link button
                    LinkButton7.Visible = true; // docter management button
                    LinkButton8.Visible = true; // food management button
                    LinkButton9.Visible = true; //Delevery Management
                    LinkButton10.Visible = true; //order Management
                    LinkButton11.Visible = true; //shop Management
                    LinkButton12.Visible = true; //member Management


                }
            }
            catch (Exception ex)
            {

            }
        }

       
        
      

        // view profile
        protected void LinkButton7_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("about.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }
        protected void LinkButton13_Click(object sender, EventArgs e)
        {
            Response.Redirect("cart.aspx");
        }
        protected void LinkButton7_Click1(object sender, EventArgs e)
        {
            Response.Redirect("admindoctermanagement.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminfoodmanagement.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("admindeleverymanagement.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminordermanagement.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminfoodshopmanagement.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminmembermanagement.aspx");
        }

        //logout button
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] ="";

            LinkButton2.Visible = true; // user login link button
            LinkButton3.Visible = true; // sign up link button

            LinkButton4.Visible = false; // logout link button
            LinkButton5.Visible = false; // hello user link button


            LinkButton6.Visible = true; // admin login link button
            LinkButton13.Visible = false; // cart
            LinkButton7.Visible = false; // docter management button
            LinkButton8.Visible = false; // food management button
            LinkButton9.Visible = false; //Delevery Management
            LinkButton10.Visible = false; //order Management
            LinkButton11.Visible = false; //shop Management
            LinkButton12.Visible = false; //member Management
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("userprofile.aspx");
        }
    }
}


       

       

       
   
