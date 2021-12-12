<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminordermanagement.aspx.cs" Inherits="FoodShop.adminordermanagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <!-- Start header -->
	<div class="all-page-title page-breadcrumb">

		<div class="container">
			<div class="row">
				<div class="col-lg-12">

    <div class="container">

    <div class="row">
         <div class="col-md-5">
            <div class="card" style="font-family: 'comic Sans MS'; background-color: rgba(128, 128, 128, 0.25); color: #CCCCCC;">
               <div class="card-body">



                

                  <div class="row">
                               <div class="col">
                                   <center>
                                       <h4 style="color: #CCCCCC">Order Details</h4>
                                      
                                         
                                         


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
                                    <div class="col-md-4">     
                                       <label>Order ID</label>
                                       <div class="form-group"> 
                                           <div class="input-group"> 

                                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="ID"></asp:TextBox>

                                           
                                        <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="GO" OnClick="Button1_Click" />
                                            
                                 </div>
                                       </div>
                                        </div>


                                    <div class="col-md-8">     
                                       <label>Order Name</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Order Name" ></asp:TextBox>

                                       </div>
                                    </div>

                             </div>
                              <br>


                             



                   <center>
                    <div class="row">
                               <div class="col-4">
                                   <div class="d-grid gap-2">
                                   <asp:button ID="Button" class="btn-btn-lg btn-block btn-success" runat="server" text="ADD" OnClick="Button_Click" />
                                    </div>
                                   </div>
                   


                     
                               <div class="col-4">
                                   <div class="d-grid gap-2">
                                   <asp:button ID="Button2" class="btn-btn-lg btn-block btn-warning" runat="server" text="UPDATE" OnClick="Button2_Click" />
                                   </div>
                               </div>
                   


                     
                               <div class="col-4">
                                   <div class="d-grid gap-2">
                                   <asp:button ID="Button3" class="btn-btn-lg btn-block btn-danger" runat="server" text="DELETE" OnClick="Button3_Click" />
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
                                       <h4 style="color: #CCCCCC">Order List</h4>
                                      
                                         
                                         


                                   </center>

                                </div>
                           </div>






                            <div class="row">
                               <div class="col">     
                                       <hr>
                                    </div>
                             </div>


                            <div class="row">

                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:foodshopDBConnectionString4 %>" SelectCommand="SELECT * FROM [order_master_table]"></asp:SqlDataSource>
                               <div class="col">     
                                   <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="order_id" DataSourceID="SqlDataSource1">
                                       <Columns>
                                           <asp:BoundField DataField="order_id" HeaderText="order_id" ReadOnly="True" SortExpression="order_id" />
                                           <asp:BoundField DataField="order_name" HeaderText="order_name" SortExpression="order_name" />
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
