<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="usersignup.aspx.cs" Inherits="FoodShop.usersignup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    <%--<!-- Start header -->
	<div class="all-page-title page-breadcrumb">
		<div class="container">
			<div class="row">
				<div class="col-lg-12">
					<%--  --%>--%>
				
    <br> <br> <br><br><br>

    <div class="container">
        <div class="row">
            <div class="col-md-8 mx-auto">
            
                <div class="card" style="font-family: 'comic Sans MS'; background-color: rgba(0, 0, 0, 0.40); color: #CCCCCC;">
                       <div class="card-body">
                            

                           <div class="row">
                               <div class="col">
                                   <center>
                                       <img width="150px" src="Images/generaluser.png"/>

                                       <div class="clear-loading spinner">
		                                <span></span>
	                                    </div>
                                   </center>

                                </div>
                           </div>


                            <div class="row">
                               <div class="col">
                                   <center>
                                       <h4 style="color: #C0C0C0">Member Sign Up</h4>
                                   </center>
                                   <br>

                                </div>
                           </div>


                            <div class="row">
                               <div class="col">     
                                       </hr>
                                    </div>
                             </div>


                           <div class="row">
                                    <div class="col-md-6"> 
                                   
                                       <label>Full Name</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Full Name"></asp:TextBox>

                                       </div>
                                        </div>


                                    <div class="col-md-6">     
                                       <label>Date OF Birth</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Date OF Birth" TextMode="Date"></asp:TextBox>

                                       </div>
                                    </div>

                             </div>


                           <div class="row">
                                    <div class="col-md-6">     
                                       <label>Phone Number</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Phone Number" TextMode="Number"></asp:TextBox>

                                       </div>
                                        </div>


                                    <div class="col-md-6">     
                                       <label>Email ID</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Email ID" TextMode="Email"></asp:TextBox>

                                       </div>
                                    </div>

                             </div>






                            <div class="row">
                                    <div class="col-md-4">     
                                       <label>State</label>
                                       <div class="form-group">    
                                           <asp:DropDownList class ="form-control" ID="DropDownList1" runat="server">

                                               <asp:ListItem Text="Sri Lanka" Value="Sri Lanka" />
                                               <asp:ListItem Text="Amarica" Value="Amarica" />
                                               <asp:ListItem Text="Chaina" Value="Chaina" />
                                               <asp:ListItem Text="Japan" Value="Japan" />
                                               <asp:ListItem Text="India" Value="India" />
                                               <asp:ListItem Text="Australia" Value="Australia" />
                                               <asp:ListItem Text="Koria" Value="Koria" />
                                               <asp:ListItem Text="Singapore" Value="Singapore" />
                                               <asp:ListItem Text="Malesiya" Value="Malesiya" />
                                               <asp:ListItem Text="Thaiwan" Value="Thaiwan" />
                                               <asp:ListItem Text="Bangaladesh" Value="Bangaladesh" />
                                               <asp:ListItem Text="South Koria" Value="South Koria" />

                                           </asp:DropDownList>

                                       </div>
                                        </div>


                                    <div class="col-md-4">     
                                       <label>City</label>
                                       <div class="form-group">    
                                           <asp:TextBox class="form-control" ID="TextBox6" runat="server" placeholder="City"></asp:TextBox>

                                       </div>
                                    </div>


                                 <div class="col-md-4">     
                                       <label>PIN Code</label>
                                       <div class="form-group">    
                                           <asp:TextBox class="form-control" ID="TextBox7" runat="server" placeholder="PIN Code" TextMode="Number"></asp:TextBox>

                                       </div>
                                    </div>

                             </div>



                            <div class="row">
                                    <div class="col">     
                                       <label>Full Address</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Full Address" TextMode="MultiLine" Rows="2"></asp:TextBox>

                                       </div>
                                        </div>

                             </div>




                           <div class="row">
                               
                               <div class="col">
                                   <center>
                                   <span class="badge rounded-pill bg-info text-dark">Login Credentials</span>
                                   </center>
                               </div>
                                
                           </div>
                                 






                                  <div class="row">
                                    <div class="col-md-6">     
                                       <label><i class="fa fa-user" aria-hidden="true"></i>  Member ID</label>
                                       <div class="form-group">    
                                           <asp:TextBox class="form-control" ID="TextBox8" runat="server" placeholder="User ID"></asp:TextBox>

                                       </div>
                                        </div>
                                      

                                    <div class="col-md-6">     
                                       <label><i class="fa fa-unlock-alt" aria-hidden="true"></i>  Password</label>
                                       <div class="form-group">    
                                           <asp:TextBox class="form-control" ID="TextBox9" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>

                                       </div>
                                    </div>

                                    </div>
                          
                          




                           <div class="row">
                               <div class="col">

                                 
                                    <div class="form-group"> 
                                     <div class="d-grid gap-2">
                                         <center>
                                        <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="<--------------------SIGN UP-------------------->" OnClick="Button1_Click" />
                                        </center>
                                    </div>
                                   </div>
                                   <br>



                                   
                                    
                                    </div>
                                   <br/>



                                    
                             </div>




                         </div>
                </div>
               
                <a href="homepage.aspx" style="color: #C0C0C0"><< Back to Home</a>

            </div>
        </div>
    </div>


                    </div>
			</div>
		</div>
	</div>
	<!-- End header -->

    

</asp:Content>
