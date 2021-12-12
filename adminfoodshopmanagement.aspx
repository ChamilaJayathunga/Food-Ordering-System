<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminfoodshopmanagement.aspx.cs" Inherits="FoodShop.adminfoodshopmanagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Start header -->
	<div class="all-page-title page-breadcrumb">
		<div class="container">
			<div class="row">
				<div class="col-lg-12">



    
    <div class="container-fluid">

    <div class="row">
         <div class="col-md-5">
            <div class="card" style="font-family: 'comic Sans MS'; background-color: rgba(128, 128, 128, 0.25); color: #CCCCCC;">
               <div class="card-body">



                

                  <div class="row">
                               <div class="col">
                                   <center>
                                       <h4 style="color: #CCCCCC">Food Are Issuing</h4>
                                      
                                         
                                         


                                   </center>

                                </div>
                           </div>



                               <div class="row">
                               <div class="col">
                                   <center>
                                       <img width="120px" src="Images/logo.png" />
                                   </center>

                                </div>
                           </div>


                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>






                            <div class="row">
                     <div class="col-md-6">
                        <label>Member ID</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Member ID"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Food ID</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Food ID"></asp:TextBox>
                              <asp:Button class="btn btn-primary" ID="Button4" runat="server" Text="Go" OnClick="Button4_Click" />
                           </div>
                        </div>
                     </div>
                  </div>

                                 
                              <br>


                             




                   <div class="row">
                     <div class="col-md-6">
                        <label>Member Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Member Name" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Food Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Food Name" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                   <br>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Order Date</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Order Date" TextMode="Date"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Delevery Date</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Delevery Date" TextMode="Date"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                   <br>
                   <center>
                  <div class="row">
                      
                     <div class="col-6">
                         <div class="d-grid gap-2">
                        <asp:Button ID="Button2" class="btn btn-lg btn-block btn-primary" runat="server" Text="Issue" OnClick="Button2_Click" />
                        </div>
                     </div>
                     <div class="col-6">
                        <div class="d-grid gap-2">
                        <asp:Button ID="Button1" class="btn btn-lg btn-block btn-success" runat="server" Text="Return" OnClick="Button1_Click" />
                         </div>
                     </div>
                   
                  </div>
                  </center>
               </div>
            </div>
            <a href="homepage.aspx" style="color: #CCCCCC"><< Back to Home</a><br>
            <br>
         </div>
         <div class="col-md-7">
            <div class="card" style="font-family: 'comic Sans MS'; background-color: rgba(128, 128, 128, 0.25); color: #CCCCCC;">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4 style="color: #CCCCCC">Issued Food List</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:foodshopDBConnectionString4 %>" SelectCommand="SELECT * FROM [food_issue_table]"></asp:SqlDataSource>

                     <div class="col">
                        <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="576px">
                            <Columns>
                                <asp:BoundField DataField="food_id" HeaderText="food_id" SortExpression="food_id" />
                                <asp:BoundField DataField="food_name" HeaderText="food_name" SortExpression="food_name" />
                                <asp:BoundField DataField="member_id" HeaderText="member_id" SortExpression="member_id" />
                                <asp:BoundField DataField="order_date" HeaderText="order_date" SortExpression="order_date" />
                                <asp:BoundField DataField="delivery_date" HeaderText="delivery_date" SortExpression="delivery_date" />
                            </Columns>
                         </asp:GridView>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
   </div>

                  
                    </div>
			</div>
		</div>
	</div>
	<!-- End header -->

</asp:Content>
