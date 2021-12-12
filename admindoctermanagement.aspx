<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="admindoctermanagement.aspx.cs" Inherits="FoodShop.admindoctermanagement" %>

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
                                       
                                       <h2 style="color: #CCCCCC;">Docter Details</h2>
   
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
                                       <label>Docter ID</label>
                                       <div class="form-group"> 
                                           <div class="input-group"> 

                                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="ID"></asp:TextBox>

                                           
                                        <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="GO" OnClick="Button1_Click" />
                                            
                                 </div>
                                       </div>
                                        </div>


                                    <div class="col-md-8">     
                                       <label>Docter Name</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Docter Name" ></asp:TextBox>

                                       </div>
                                    </div>

                             </div>
                             


                             
                                 <div class="row">
                                  <div class="col-md-6">     
                                       <label>Address</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Address" ></asp:TextBox>

                                       </div>
                                    </div>   
                        

                                    <div class="col-md-6">     
                                       <label>Email</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Email" TextMode="Email"></asp:TextBox>

                                       </div>
                                    </div>



                             </div>
                              


                                  <div class="row">
                                  <div class="col-md-6">     
                                       <label>Phone Number</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Phone Number" TextMode="Phone"></asp:TextBox>

                                       </div>
                                    </div>   
                        

                                    <div class="col-md-6">     
                                       <label>BMI list</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="BMI list" ></asp:TextBox>

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
            <a href="homepage.aspx" style="color: #CCCCCC;"><< Back to Home</a><br>
            <br>
         </div>
         <br>
        <br>
    

        <div class="col-md-12">

            

                <div class="card" style="font-family: 'comic Sans MS'; background-color: rgba(128, 128, 128, 0.25); color: #CCCCCC;">
                       <div class="card-body">
                            




                            <div class="row">
                               <div class="col">
                                   <center>
                                       <h2 style="color: #CCCCCC;">Docter List</h2>
                                      
                                         
                                         


                                   </center>

                                </div>
                           </div>






                            <div class="row">
                               <div class="col">     
                                       <hr>
                                    </div>
                             </div>


                            <div class="row">
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:foodshopDBConnectionString %>" SelectCommand="SELECT * FROM [docter_master_table]"></asp:SqlDataSource>
                               <div class="col">     
                                   <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="docter_id" DataSourceID="SqlDataSource1">
                                       <Columns>
                                           <asp:BoundField DataField="docter_id" HeaderText="docter_id" ReadOnly="True" SortExpression="docter_id" />
                                           <asp:BoundField DataField="docter_name" HeaderText="docter_name" SortExpression="docter_name" />
                                           <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                                           <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                                           <asp:BoundField DataField="phone_number" HeaderText="phone_number" SortExpression="phone_number" />
                                           <asp:BoundField DataField="bmi_list" HeaderText="bmi_list" SortExpression="bmi_list" />
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
