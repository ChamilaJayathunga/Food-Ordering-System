<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminfoodmanagement.aspx.cs" Inherits="FoodShop.adminfoodmanagement1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script type="text/javascript">
      $(document).ready(function () {


          //$(document).ready(function () {
              //$('.table').DataTable();
         // });
      
          $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
          //$('.table1').DataTable();
      });

   </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <!-- Start header -->
	<div class="all-page-title page-breadcrumb">
		<div class="container">
			<div class="row">
				<div class="col-lg-12">




    <div class="container">

    <div class="row">
         <div class="col-md-12">
            <div class="card" style="font-family: 'comic Sans MS'; background-color: rgba(128, 128, 128, 0.25); color: #CCCCCC;">
               <div class="card-body">
                   


                

                  <div class="row">
                               <div class="col">
                                   <center>
                                       
                                       <h4 style="color: #CCCCCC">Food Details</h4>
   
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
                                       <label>Food ID</label>
                                       <div class="form-group"> 
                                           <div class="input-group"> 

                                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="ID" ></asp:TextBox>

                                           
                                        <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="GO" OnClick="Button1_Click" />
                                            
                                 </div>
                                       </div>
                                        </div>


                                    <div class="col-md-4">     
                                       <label>Food Name</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Food Name" ></asp:TextBox>

                                       </div>
                                    </div>


                                 <div class="col-md-4">     
                                       <label>Category</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Category" ></asp:TextBox>

                                       </div>
                                    </div>   

                             </div>
                             


                             
                                 <div class="row">
                                 
                                    <div class="col-md-4">     
                                       <label>Price</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Price" ></asp:TextBox>

                                       </div>
                                    </div>

                                     <div class="col-md-4">     
                                       <label>Supplier</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="supplier" ></asp:TextBox>

                                       </div>
                                    </div>   

                                     <div class="col-md-4">     
                                       <label>Obtained Date</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Obtained Date" TextMode="Date"></asp:TextBox>

                                       </div>
                                    </div>


                             </div>
                              


                            <div class="row">
                                  
                                       <div class="col-md-4">     
                                       <label>Food Flavor</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server" placeholder="Food Flavor" ></asp:TextBox>

                                       </div>
                                    </div>   

                                <div class="col-md-4">     
                                       <label>Expire Date</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" placeholder="Expire Date" TextMode="Date" ></asp:TextBox>

                                       </div>
                                    </div>   
                                    
                                <div class="col-md-4">     
                                       <label>Food Cost</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox9" runat="server" placeholder="Food Cost" ></asp:TextBox>

                                       </div>
                                    </div>   
                                

                             </div>


                            <div class="row">
                                  
                                       <div class="col-md-4">     
                                       <label>Food Unit</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server" placeholder="Food Unit" ></asp:TextBox>

                                       </div>
                                    </div>   

                                <div class="col-md-8">     
                                       <label>Food Discription</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox11" runat="server" placeholder="Food Discription"  ></asp:TextBox>

                                       </div>
                                    </div>   
                                    
                                 
                                

                             </div>



                            <div class="row">

                                    <div class="col-md-6">     
                                       <label>Actual Stock</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox12" runat="server" placeholder="Actual Stock" ></asp:TextBox>

                                       </div>
                                    </div>  
                                  
                                       <div class="col-md-6">     
                                       <label>Current Stock</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox13" runat="server" placeholder="Current Stock" ></asp:TextBox>

                                       </div>
                                    </div>   

                             
                                

                             </div>
                              


                   <center>

                    <div class="row">
                               <div class="col-4">
                                   <div class="d-grid gap-2">
                                   <asp:button ID="Button" class="btn-btn-lg btn-block btn-success" runat="server" text="ADD" OnClick="Button_Click" />
                                    </div>
                                   </div>
                   


                     
                               <div class="col-4">
                                   <div class="d-grid gap-2">
                                   <asp:button ID="Button2" class="btn-btn-lg btn-block btn-warning" runat="server" text="UPDATE" OnClick="Button2_Click1" />
                                   </div>
                               </div>
                   


                     
                               <div class="col-4">
                                   <div class="d-grid gap-2">
                                   <asp:button ID="Button3" class="btn-btn-lg btn-block btn-danger" runat="server" text="DELETE" OnClick="Button3_Click1"  />
                                       </div>
                               </div>
                  </div>

        </center>
                  
               </div>
            </div>
            <a href="homepage.aspx" style="color: #CCCCCC"><< Back to Home</a><br>
            <br>
         </div>
         <br>
        <br>
    

        
        <div class="col-md-13">

            

                <div class="card" style="font-family: 'comic Sans MS'; background-color: rgba(128, 128, 128, 0.25); color: #CCCCCC;">
                       <div class="card-body">
                            
                           <center>



                            <div class="row">
                               <div class="col">
                                   <center>
                                       <h4 style="color: #CCCCCC">Food List</h4>
                                      
                                         
                                         


                                   </center>

                                </div>
                           </div>






                            <div class="row">
                               <div class="col">     
                                       <hr>
                                    </div>
                             </div>

                          
                            <div class="row">
                               
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:foodshopDBConnectionString4 %>" SelectCommand="SELECT * FROM [food_table]"></asp:SqlDataSource>
                               <div class="col">
                                    
                                   <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="food_id" DataSourceID="SqlDataSource2" Width="711px">
                                       <Columns>
                                           <asp:BoundField DataField="food_id" HeaderText="food_id" ReadOnly="True" SortExpression="food_id" />
                                           <asp:BoundField DataField="food_name" HeaderText="food_name" SortExpression="food_name" />
                                           <asp:BoundField DataField="obtained_date" HeaderText="obtained_date" SortExpression="obtained_date" />
                                           <asp:BoundField DataField="expire_date" HeaderText="expire_date" SortExpression="expire_date" />
                                           <asp:BoundField DataField="food_cost" HeaderText="food_cost" SortExpression="food_cost" />
                                           <asp:BoundField DataField="food_unit" HeaderText="food_unit" SortExpression="food_unit" />
                                           <asp:BoundField DataField="food_discription" HeaderText="food_discription" SortExpression="food_discription" />
                                           <asp:BoundField DataField="actual_stock" HeaderText="actual_stock" SortExpression="actual_stock" />
                                           <asp:BoundField DataField="current_stock" HeaderText="current_stock" SortExpression="current_stock" />
                                       </Columns>
                                   </asp:GridView>
                                   
                                    </div>
                             </div>


                          
                                    
                             </div>




                         </div>
                </div>




        </div>
            




        </div>
    </center>
                     
                    </div>
			</div>
		</div>
	</div>
	<!-- End header -->

</asp:Content>
