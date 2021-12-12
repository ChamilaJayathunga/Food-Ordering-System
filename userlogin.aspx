<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="FoodShop.userlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

					

     
    <br><br><br>

                     <div class="container" style="background-position: center center; font-family: 'comic Sans MS'; ">
                        
                         
        
        <div class="row">
            <div class="col-md-6 mx-auto">
            
                <div class="card" style="background-position: center center; background-color: rgba(0, 0, 0, 0.25);">
                       <div class="card-body">
                            <h1 style="font-family:'comic Sans MS'">Rasa Bojun</h1>
                            
                           <div class="row">
                               <div class="col">
                                   <center>
                                       <img width="160px" src="Images/generaluser.png" />
                                       <div class="clear-loading spinner">
		                                <span></span>
	                                    </div>
                                      
                                       
                                   </center>

                                </div>
                           </div>
                          

                            <div class="row">
                               <div class="col">
                                   <center>
                                       <h2 style="color: #C0C0C0">MEMBER LOGIN</h2>
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
                                   
                                        <label style="color: #C0C0C0"><i class="fa fa-user" aria-hidden="true"></i>  Member ID</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Member ID"></asp:TextBox>

                                       </div>


                                     <label style="color: #C0C0C0"><i class="fa fa-unlock-alt" aria-hidden="true"></i>  Password</label>
                                       <div class="form-group">    
                                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>

                                       </div>
                                        <br>

                                   <center>
                                    <div class="form-group"> 
                                     <div class="d-grid gap-2">
                                        <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="<------------------LOGIN------------------>" OnClick="Button1_Click" />
                                    </div>
                                   </div>
                                  



                                    <div class="form-group"> 
                                       
                                        <a href="usersignup.aspx">

                                            <div class="d-grid gap-2">
                                            <input class="btn btn-info btn-block btn-lg" id="Button2" type="button" value="<-----------------SIGN UP----------------->"  />
                                            </div>
                                        </a>
                                    
                                    </div>



                                   <div class="form-group"> 
                                       
                                        <a href="adminlogin.aspx">

                                            <div class="d-grid gap-2">
                                            <input class="btn btn-warning btn-block btn-lg" id="Button3" type="button" value="<---------System Administration--------->" />
                                            </div>
                                        </a>
                                    
                                    </div>
                                 

                                     </center>
                                    <a href="fogotpassword.aspx"  style="color: #bef1f1">Fogot Password</a>

                                    </div>
                             </div>




                         </div>
                </div>




                 
                <a href="homepage.aspx" style="font-family: 'comic Sans MS'; color: #CCCCCC;"><< Back to Home</a>
                
               
            </div>
        </div>
    </div>
    <br>








    
              


</asp:Content>
