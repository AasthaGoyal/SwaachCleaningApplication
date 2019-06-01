<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="CleaningApplication.WebForm6" %>
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
   
	<div >


	<h3> Contact Us</h3>
	<br />
	
	<asp:TextBox class="form-control" runat="server" type="text"  Id="txtname" placeholder="Enter Your Name" required/>
	<br />
	<asp:TextBox class="form-control" runat="server" type="text"  Id="txtEmail" placeholder="Enter Your Email" required/>
	<br />
	<asp:TextBox class="form-control" runat="server" type="text"  Id="txtPhoneNo" placeholder="Enter Your Phone No" />
	<br />
	<asp:TextBox class="form-control" runat="server" type="text"  Id="txtMessage" placeholder="Enter Your Message" required/>
	<br />
	<asp:Button ID="btnSubmit" stye="" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
	<br />
	<asp:Label ID="lblMessage" runat="server" ></asp:Label>
			</div>
    
</asp:Content>
