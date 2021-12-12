<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="FoodShop.cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="all-page-title page-frice">
		<div class="container text-center">
			<div class="row">
				<div class="col-lg-12">
					<h1>CART</h1>
				</div>
			</div>
		</div>
	</div>
    	<div class="container heading-title text-center">
		<br><br><br>
		<h2 style="color: #CCCCCC">ITEMS</h2>
	  </div>
	  
	  <div class="container">
		<div class="row">
		  
		  <div class="col">
            <center>
                <asp:GridView Class="table table-light table-bordered" ID="GridView1" runat="server">
                    <EmptyDataTemplate>Cart is Empty</EmptyDataTemplate> 
                </asp:GridView>

            </center>
		  </div>
	  </div>
      <div class="row" style="align-content:flex-end">
          <div class="col">
            <asp:Label ID="Label1" runat="server" ForeColor="White" Font-Bold="True" Font-Size="Large" ></asp:Label>
          </div>
      </div>
      <div class="row">
		  <div class="col">
            <center>
                <asp:Button ID="Button2" runat="server" Text="Clear All" OnClick="Button2_Click" Height="63px" Width="156px" />
                 <asp:Button ID="Button1" runat="server" Text="Order Now" OnClick="Button1_Click" Height="63px" Width="156px" />
            </center>
		  </div>
		  <br><br><br>
		 </div>
</asp:Content>
