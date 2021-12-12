<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="FoodShop.menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="all-page-title page-frice">
		<div class="container text-center">
			<div class="row">
				<div class="col-lg-12">
					<h1>MENU</h1>
				</div>
			</div>
		</div>
	</div>




	<div class="container heading-title text-center">
		<br><br><br>
		<h2 style="color: #CCCCCC">KOTHTHU</h2>
	  </div>
	  
	  <div class="container">
		<div class="row">
		  
		  <div class="col-sm-4">
            <center>
			        <img src="images/IMG_20210521_154929.jpg" /><br>
                      <h2 style="color: #CCCCCC">MASALA PALANDI CHEESE KOTHTHU</h2>
			        <h4 style="color: #CCCCCC">Price : RS 800</h4>
                    <asp:Button ID="Button1" runat="server" Height="47px" OnClick="Button1_Click" Text="Add To Cart" Width="126px" />
                    <br><br>
            </center>
		  </div>
          
		
		 <div class="col-sm-4">
               <center>
		   <img src="images/tikka.jpg" /><br>
		   <h2 style="color: #CCCCCC">MASALA CHICKEN CHEESE KOTHTHU</h2>
		   <h4 style="color: #CCCCCC">Price : RS 700</h4>
		   <asp:Button ID="Button2" runat="server" Height="47px" OnClick="Button2_Click" Text="Add To Cart" Width="126px" /><br><br>
		  </div>
		  
		  
		  <div class="col-sm-4">
                <center>
            <img src="images/dophin.jpg" /><br>
			<h2 style="color: #CCCCCC">SPECIAL DOLPHIN CHEESE KOTHTHU</h2>
			<h4 style="color: #CCCCCC">Price : RS 550 </h4>
			<asp:Button ID="Button3" runat="server" Height="47px" OnClick="Button3_Click" Text="Add To Cart" Width="126px" />
		  </div>
       


            <div class="col-sm-4">
                  <center>
			<img src="images/palandi.jpg" />
			<h2 style="color: #CCCCCC">  PALANDI  CHEESE KOTHTHU</h2>
			<h4 style="color: #CCCCCC">Price : RS 700</h4>
			<asp:Button ID="Button4" runat="server" Height="47px" OnClick="Button4_Click" Text="Add To Cart" Width="126px" /><br><br>
		  </div>
		  
		  <div class="col-sm-4">
                <center>
              <img src="images/cheese%20koththu.jpg" />
			<h2 style="color: #CCCCCC">CHEESE  CHICKEN KOTHTHU</h2>
			<h4 style="color: #CCCCCC">Price : RS 550</h4>
			<asp:Button ID="Button5" runat="server" Height="47px" OnClick="Button5_Click" Text="Add To Cart" Width="126px" /><br><br>
		  </div>
		  
		   <div class="col-sm-4">
                 <center>
            <img src="images/mutton.jpg" />
			<h2 style="color: #CCCCCC">  MUTTON CHEESE KOTHTHU</h2>
		   <h4 style="color: #CCCCCC">Price : RS 1200</h4>
		   <asp:Button ID="Button6" runat="server" Height="47px" OnClick="Button6_Click" Text="Add To Cart" Width="126px" />
		   <br>
		  </div>

			<div class="col-sm-4">
                  <center>
                <img src="images/mix.jpg" />
			<h2 style="color: #CCCCCC">MIX CHEESE KOTHTHU</h2>
			<h4 style="color: #CCCCCC">Price : RS 1200</h4>
			<asp:Button ID="Button7" runat="server" Height="47px" OnClick="Button7_Click" Text="Add To Cart" Width="126px" /><br><br>
		  </div>
		  
		  <div class="col-sm-4">
                <center>
            <img src="images/IMG_20210521_154759.jpg" />
			<h2 style="color: #CCCCCC">CHICKEN KOTHTHU</h2>
			<h4 style="color: #CCCCCC">Price : RS 400</h4>
			<asp:Button ID="Button8" runat="server" Height="47px" OnClick="Button8_Click" Text="Add To Cart" Width="126px" /><br><br>
		  </div>
		
		 <div class="col-sm-4">
               <center>
            <img src="images/pork%20koththu.jpg" />
			<h2 style="color: #CCCCCC">PORK KOTHTHU</h2>
		   <h4 style="color: #CCCCCC">Price : RS 400</h4>
		   <asp:Button ID="Button9" runat="server" Height="47px" OnClick="Button9_Click" Text="Add To Cart" Width="126px" />
		  </div>
		  
		  
		  <div class="col-sm-4">
                <center>
              <img src="images/fish%20koththu.jpg" />
			<h2 style="color: #CCCCCC">FISH KOTHTHU</h2>
			<h4 style="color: #CCCCCC">Price : RS 400 </h4>
			<asp:Button ID="Button10" runat="server" Height="47px" OnClick="Button10_Click" Text="Add To Cart" Width="126px" />
		  </div>
		  
		  <div class="col-sm-4">
                <center>
              <img src="images/egg.jpg" />
			<h2 style="color: #CCCCCC">EGG KOTHTHU</h2>
			<h4 style="color: #CCCCCC">Price : RS 320</h4>
			<asp:Button ID="Button11" runat="server" Height="47px" OnClick="Button11_Click" Text="Add To Cart" Width="126px" />
		  </div>

			<div class="col-sm-4">
                  <center>
            <img src="images/vegetable.jpg" />
			<h2 style="color: #CCCCCC">VEGETABLE KOTHTHU</h2>
			<h4 style="color: #CCCCCC">Price : RS 250</h4>
			<asp:Button ID="Button12" runat="server" Height="47px" OnClick="Button12_Click" Text="Add To Cart" Width="126px" />
		  </div>
		  
		  
		 </div>
	  </div>



	<div class="container heading-title text-center">
		<br><br><br>
		<h2 style="color: #CCCCCC">FRIED RICE</h2>
	  </div>
	  
	  <div class="container">
		<div class="row">
	   
		  <div class="col-sm-4">
                <center>
              <img src="images/IMG_20210521_154711.jpg" />
			<h2 style="color: #CCCCCC">VEGETABLE</h2>
			<h4 style="color: #CCCCCC">Price : RS 300</h4>
			<asp:Button ID="Button13" runat="server" Height="47px" OnClick="Button13_Click" Text="Add To Cart" Width="126px" /><br><br>
		  </div>
		  
		  <div class="col-sm-4">
                <center>
            <img src="images/IMG_20210521_154659.jpg" />
			<h2 style="color: #CCCCCC">EGG</h2>
			<h4 style="color: #CCCCCC">Price : RS 350</h4>
			<asp:Button ID="Button14" runat="server" Height="47px" OnClick="Button14_Click" Text="Add To Cart" Width="126px" />
		  </div>
		
		 <div class="col-sm-4">
               <center>
             <img src="images/IMG_20210521_154646.jpg" />
			<h2 style="color: #CCCCCC">SEA FOOD</h2>
		   <h4 style="color: #CCCCCC">Price : RS 700</h4>
		   <asp:Button ID="Button15" runat="server" Height="47px" OnClick="Button15_Click" Text="Add To Cart" Width="126px" />
		  </div>
		  
		  
		  <div class="col-sm-4">
                <center>
              <img src="images/IMG_20210521_154627.jpg" />
			<h2 style="color: #CCCCCC">MONGOLIAN</h2>
			<h4 style="color: #CCCCCC">Price : RS 800 </h4>
			<asp:Button ID="Button16" runat="server" Height="47px" OnClick="Button16_Click" Text="Add To Cart" Width="126px" /><br><br>
		  </div>
		  
		  <div class="col-sm-4">
                <center>
              <img src="images/IMG_20210521_154617.jpg" />
			<h2 style="color: #CCCCCC">MIX FRIED RICE</h2>
			<h4 style="color: #CCCCCC">Price : RS 800</h4>
			<asp:Button ID="Button17" runat="server" Height="47px" OnClick="Button17_Click" Text="Add To Cart" Width="126px" />
		  </div>
		  
		   <div class="col-sm-4">
                 <center>
               <img src="images/nasigooreng.jpg" />
			<h2 style="color: #CCCCCC">NASIGORENG</h2>
		   <h4 style="color: #CCCCCC">Price : RS 800</h4>
		   <asp:Button ID="Button18" runat="server" Height="47px" OnClick="Button18_Click" Text="Add To Cart" Width="126px" />
		   <br>
		  </div>
		  
		  
		 </div>
	  </div>
	  

	<div class="container heading-title text-center">
		<br><br><br>
		<h2 style="color: #CCCCCC">RICE & CURRY</h2>
	  </div>
	  
	  <div class="container">
		<div class="row">
	   
		  <div class="col-sm-4">
                <center>
              <img src="images/fiishrice.jpg" />
			<h2 style="color: #CCCCCC">FISH</h2>
			<h4 style="color: #CCCCCC">Price : RS 250</h4>
			<asp:Button ID="Button19" runat="server" Height="47px" OnClick="Button19_Click" Text="Add To Cart" Width="126px" /><br><br>
		  </div>
		  
		  <div class="col-sm-4">
                <center>
              <img src="images/IMG_20210521_154535.jpg" />
			<h2 style="color: #CCCCCC">CHICKEN</h2>
			<h4 style="color: #CCCCCC">Price : RS 280</h4>
			<asp:Button ID="Button20" runat="server" Height="47px" OnClick="Button20_Click" Text="Add To Cart" Width="126px" />
		  </div>
		
		 <div class="col-sm-4">
               <center>
             <img src="images/IMG_20210522_180339.jpg" />
			<h2 style="color: #CCCCCC">PRAWNS</h2>
		   <h4 style="color: #CCCCCC">Price : RS 320</h4>
		   <asp:Button ID="Button21" runat="server" Height="47px" OnClick="Button21_Click" Text="Add To Cart" Width="126px" />
		  </div>
		  
		  
		  <div class="col-sm-4">
                <center>
              <img src="images/pork%201.jpg" />
			<h2 style="color: #CCCCCC">pork</h2>
			<h4 style="color: #CCCCCC">Price : RS 400 </h4>
			<asp:Button ID="Button22" runat="server" Height="47px" OnClick="Button22_Click" Text="Add To Cart" Width="126px" /><br><br>
		  </div>
		  
		  <div class="col-sm-4">
                <center>
              <img src="images/fish%20freid.jpg" />
			<h2 style="color: #CCCCCC">FRIED FISH</h2>
			<h4 style="color: #CCCCCC">Price : RS 350</h4>
			<asp:Button ID="Button23" runat="server" Height="47px" OnClick="Button23_Click" Text="Add To Cart" Width="126px" />
		  </div>
		  
		   <div class="col-sm-4">
                 <center>
               <img src="images/waw%20malu.jpg" />
			<h2 style="color: #CCCCCC">WAV MALU</h2>
		   <h4 style="color: #CCCCCC">Price : RS 350</h4>
		   <asp:Button ID="Button24" runat="server" Height="47px" OnClick="Button24_Click" Text="Add To Cart" Width="126px" />
		   <br>
		  </div>
		  
		  
		 </div>
	  </div>
	  
	  <div class="container heading-title text-center">
		<br><br><br>
		<h2 style="color: #CCCCCC">OTHERS</h2>
	  </div>
	  
	  <div class="container">
		<div class="row">
	   
		  <div class="col-sm-4">
                <center>
              <img src="images/egg%20roti.jpg" />
			<h2 style="color: #CCCCCC">EGG ROTI</h2>
			<h4 style="color: #CCCCCC">Price : RS 50</h4>
			<asp:Button ID="Button25" runat="server" Height="47px" OnClick="Button25_Click" Text="Add To Cart" Width="126px" /><br><br>
		  </div>
		  
		  <div class="col-sm-4">
                <center>
              <img src="images/parata.jpg" />
			<h2 style="color: #CCCCCC">PARATA</h2>
			<h4 style="color: #CCCCCC">Price : RS 25</h4>
			<asp:Button ID="Button26" runat="server" Height="47px" OnClick="Button26_Click" Text="Add To Cart" Width="126px" />
		  </div>
		
		 <div class="col-sm-4">
               <center>
             <img src="images/samosa.jpg" />
			<h2 style="color: #CCCCCC">EGG SHORTIES</h2>
		   <h4 style="color: #CCCCCC">Price : RS 40</h4>
		   <asp:Button ID="Button27" runat="server" Height="47px" OnClick="Button27_Click" Text="Add To Cart" Width="126px" />
		  </div>
		  
		  
		  <div class="col-sm-4">
                <center>
              <img src="images/vegetable%20roti.jpg" />
			<h2 style="color: #CCCCCC">VEGETABLE ROTI</h2>
			<h4 style="color: #CCCCCC">Price : RS 40 </h4>
			<asp:Button ID="Button28" runat="server" Height="47px" OnClick="Button28_Click" Text="Add To Cart" Width="126px" /><br><br>
		  </div>
		  
		  <div class="col-sm-4">
              <center>
              <img src="images/string.jpg" />
			<h2 style="color: #CCCCCC">STRING HOPPERS</h2>
			<h4 style="color: #CCCCCC">Price : RS 70</h4>
			<asp:Button ID="Button29" runat="server" Height="47px" OnClick="Button29_Click" Text="Add To Cart" Width="126px" />
		  </div>
		  
		   <div class="col-sm-4">
                 <center>
               <img src="images/hoppers.jpg" />
			<h2 style="color: #CCCCCC">HOPPERS</h2>
		   <h4 style="color: #CCCCCC">Price : RS 20</h4>
		   <asp:Button ID="Button30" runat="server" Height="47px" OnClick="Button30_Click" Text="Add To Cart" Width="126px" />
		   <br>
		  </div>

			<div class="col-sm-4">
                  <center>
                <img src="images/dhal%20curry.jpg" />
			<h2 style="color: #CCCCCC">DHAL CURRY</h2>
		   <h4 style="color: #CCCCCC">Price : RS 60</h4>
		   <asp:Button ID="Button31" runat="server" Height="47px" OnClick="Button31_Click" Text="Add To Cart" Width="126px" />
		   <br>
		  </div>

			<div class="col-sm-4">
                  <center>
                <img src="images/Sri-Lankan-Chicken-Curry-The-Flavor-Bender-Featured-Image-SQ-2%20(1).jpg" />
			<h2 style="color: #CCCCCC">CHICKEN CURRY</h2>
		   <h4 style="color: #CCCCCC">Price : RS 150</h4>
		   <asp:Button ID="Button32" runat="server" Height="47px" OnClick="Button32_Click" Text="Add To Cart" Width="126px" /><br><br>
		   <br>
		  </div>

			<div class="col-sm-4">
                  <center>
                <img src="images/pork%20curry.jpg" />
			<h2 style="color: #CCCCCC">PORK CURRY</h2>
		   <h4 style="color: #CCCCCC">Price : RS 400</h4>
		   <asp:Button ID="Button33" runat="server" Height="47px" OnClick="Button33_Click" Text="Add To Cart" Width="126px" />
		   <br>
		  </div>

			<div class="col-sm-4">
                  <center>
                <img src="images/Kerala-Prawn-Curry-3.jpg" />
			<h2 style="color: #CCCCCC">PRAWNS CURRY</h2>
		   <h4 style="color: #CCCCCC">Price : RS 400</h4>
		   <asp:Button ID="Button34" runat="server" Height="47px" OnClick="Button34_Click" Text="Add To Cart" Width="126px" /><br><br>
		   <br>
		  </div>

		 
		  
		 </div>
	  </div>
    
</asp:Content>
