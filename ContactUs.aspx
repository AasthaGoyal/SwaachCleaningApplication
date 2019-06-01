<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="CleaningApplication.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	 <link href="css/bootstrap.css" rel="stylesheet">
<link href="css/style.css" rel="stylesheet">
<link href="css/responsive.css" rel="stylesheet">
<!--<link href="css/color.css" rel="stylesheet">-->

<link rel="shortcut icon" href="images/favicon.png" type="image/x-icon">
<link rel="icon" href="images/favicon.png" type="image/x-icon">

<!-- Responsive -->
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0">
   

	<style>
		#map {
		height: 400px;  /* The height is 400 pixels */
		width: 100%;  /* The width is the width of the web page */
	   }
	</style>
	 

	<section class="in-touch-section" style="background-image:url(images/background/5.jpg)">
		<div class="auto-container">
			<div class="sec-title light">
				<h2>Get Touch With Us</h2>
				<div class="separator"></div>
			</div>
			<div class="row clearfix">
			
				<!--In Touch Block-->
				<div class="in-touch-block col-lg-4 col-md-4 col-sm-12">
					<div class="inner-box">
						<h3>Visit Our Place</h3>
						<ul>
							<li>
								<asp:Label ID="lblAddress" runat="server" ></asp:Label></li>
							
						</ul>
						<a href="https://www.google.com/maps/place/555+Richardson+Rd,+Mount+Roskill,+Auckland+1041/@-36.9197206,174.7327171,17z/data=!3m1!4b1!4m5!3m4!1s0x6d0d467eed12a785:0x7645b4142ec52985!8m2!3d-36.9197249!4d174.7349058" class="link">Find Us On Map</a>
					</div>
				</div>
				
				<!--In Touch Block-->
				<div class="in-touch-block col-lg-4 col-md-4 col-sm-12">
					<div class="inner-box">
						<h3>Phone & Mail</h3>
						<ul>
							<li>
								<asp:Label ID="lblPhone" runat="server" ></asp:Label></li>
							<li>
								<asp:Label ID="lblEmail" runat="server" ></asp:Label></li>
						</ul>
						<a href="mailto:swaachclean@gmail.com" class="link">Request Quote</a>
					</div>
				</div>
				
				<!--In Touch Block-->
				<div class="in-touch-block col-lg-4 col-md-4 col-sm-12">
					<div class="inner-box">
						<h3>Opening Hours</h3>
						<ul>
							<li>
								<asp:Label ID="lblTimings" runat="server" ></asp:Label></li>
						</ul>
						<a href="tel: 02040050006" class="link">24 Hrs Emergency</a>
					</div>
				</div>
				
			</div>
		</div>
	</section>
	<!--End In Touch Section-->

							
	<!--Contact Page Section-->
	<section class="contact-page-section">
		
		<div class="auto-container">
			<div class="row clearfix">
				
				<!--Form Column-->
				<div class="form-column col-lg-6 col-md-12 col-sm-12">
					<div class="inner-column">
						<!--Contact Form-->
						<div class="contact-form">
							
								<div class="row clearfix">
									<div class="form-group col-lg-12 col-md-12 col-sm-12">
										<label>Name</label>
										<asp:TextBox runat="server" type="text"  Id="txtName" placeholder="Enter Your Name" />
									</div>
									
									<div class="form-group col-md-6 col-sm-6">
										<label>Email</label>
										<asp:TextBox runat="server" type="email"   id="txtEmail" placeholder="Email Address" />
									</div>
									
									<div class="form-group col-md-6 col-sm-6">
										<label>Phone</label>
										<asp:TextBox runat="server" type="text"   id="txtPhoneNo" placeholder="Phone" />
									</div>
									
									<div class="form-group col-md-12 col-sm-12">
										<label>Youe Message</label>
									   
										<asp:TextBox runat="server" ID="txtMessage" placeholder="Your words goes here..." Height="112px"/>
									</div>
									
								<div class="form-group col-md-12 col-sm-12">
									<asp:Button ID="btnSubmit" class="btn-primary" runat="server" Text="Submit" Causes validation = "false" OnClick="btnSubmit_Click" />
								
									   
									<asp:Label ID="lblMessage" runat="server" ForeColor="#CC0000" Font-Bold="True" ></asp:Label>
										</div>  
								</div>
									
							
						</div>
							
						<!--End Contact Form-->
					</div>
				</div>
						
				<!--Content Column-->
				<div class="content-column col-lg-6 col-md-12 col-sm-12">
					<div class="inner-column">
						<!--Sec Title-->
						<div class="sec-title">
							<div class="icon-box">
								<span class="icon flaticon-broom"></span>
							</div>
							<h2>Contact Persons</h2>
							<div class="separator"></div>
						</div>
						<div class="text">You can talk directly with any department you want to talk to, Feel free to contact us, dont be shy.</div>
						<div class="row clearfix">
						
							<asp:Repeater ID="RepStaff" runat="server">
								<HeaderTemplate>

								</HeaderTemplate>
								<ItemTemplate>
									<!--Person Block-->
							<div class="person-block col-lg-6 col-md-6 col-sm-12">
								<div class="inner-box">
									<div class="image">
										<img id="photo" src="<%#Eval("photo") %>" style="width:80px; height:80px" alt="" />
									</div>
									<h3>
										<asp:Label ID="lblName" runat="server" Text='<%#Eval("fullname") %>'></asp:Label></h3>
									<div class="title">
										<asp:Label ID="lblPosition" runat="server" Text='<%#Eval("position") %>'></asp:Label></div>
									<ul>
										<li>
											<asp:Label ID="lblPhoneNo" runat="server" Text='<%#Eval("phoneNo") %>'></asp:Label></li>
										<li>
											<asp:Label ID="lblEmailid" runat="server" Text='<%#Eval("emailid") %>'></asp:Label></li>
									</ul>
								</div>
							</div>
								</ItemTemplate>
								<FooterTemplate>

								</FooterTemplate>
							</asp:Repeater>
							
							
							
							
						</div>
					</div>
				</div>
				
			</div>
		</div>
	</section>
	<!--End Contact Page Section-->
	
	<section class="map-section">
		<!--Map Outer-->
		<div class="map-outer">
			<div class="google-map"
				id="contact-google-map" 
				data-map-lat="44.231172" 
				data-map-lng="-76.485954" 
				data-icon-path="images/icons/map-marker.png" 
				data-map-title="Alabama, USA" 
				data-map-zoom="12" 
				data-markers='{
					"marker-1": [42.231172, -84.485954, "<h4>Branch Office</h4><p>4/99 Alabama, USA</p>"]
						}'>

			</div>
		</div>
	</section>
	<!--End Map Section-->
	
	<script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAHzPSV2jshbjI8fqnC_C4L08ffnj5EN3A"></script>
<script src="js/gmaps.js"></script>
<script src="js/map-script.js"></script>
</asp:Content>
