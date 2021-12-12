<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="FoodShop.adminlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    



  <!-- Start header -->
	<div class="all-page-title page-breadcrumb">
		<div class="container">
			<div class="row">
				<div class="col-lg-12">
					<%--  --%>


    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
            
                <div class="card" style="font-family: 'comic Sans MS'; background-color: rgba(128, 128, 128, 0.25); color: #CCCCCC;">
                       <div class="card-body">
                       <h1 style="font-family: 'comic Sans MS'">Rasa Bojun</h1><br>
                            

                           <div class="row">
                               <div class="col">
                                   <center>
                                       <img width="170px" src="Images/adminuser.png" />
                                       <div class="clear-loading spinner">
		                                <span></span>
	                                    </div>
                                   </center>

                                </div>
                           </div>


                            <div class="row">
                               <div class="col">
                                   <center>
                                       <h3 style="color: #CCCCCC">Admin Login</h3>
                                   </center>

                                </div>
                           </div>


                            <div class="row">
                               <div class="col">     
                                       </hr>
                                    </div>
                             </div>


                           <div class="row">
                               <div class="col">
                                        <label><i class="fa fa-user" aria-hidden="true"></i>  Admin ID</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Admin ID"></asp:TextBox>

                                       </div>


                                     <label><i class="fa fa-unlock-alt" aria-hidden="true"></i>  Password</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>

                                       </div>
                                        <br>

                                   
                                    <div class="form-group"> 
                                     <div class="d-grid gap-2">
                                        <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="[------------------LOGIN-----------------]" OnClick="Button1_Click" />
                                    </div>
                                   </div>
                                   <br>



                                   
                                    
                                    </div>
                                   <br/>



                                    </div>
                             </div>




                        </div> 
               
               
                <a href="homepage.aspx" style="color: #CCCCCC"><< Back to Home</a>
                
               
            </div>
        </div>
    </div>



               </div>
			</div>
		</div>
	</div>
	<!-- End header -->--%>

</asp:Content>
