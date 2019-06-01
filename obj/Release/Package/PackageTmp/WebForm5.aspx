<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="CleaningApplication.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>

	  <link href="css/bootstrap.css" rel="stylesheet">
<link href="css/style.css" rel="stylesheet">
<link href="css/responsive.css" rel="stylesheet">
<!--<link href="css/color.css" rel="stylesheet">-->

<link rel="shortcut icon" href="images/favicon.png" type="image/x-icon">
<link rel="icon" href="images/favicon.png" type="image/x-icon">

<!-- Responsive -->
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0">
   
</head>
<body>
	<h1>
		<asp:Label ID="Label1" runat="server" style="font-family:'Eras ITC'" Text="Swaach Cleaning Services" Font-Bold="True" Font-Size="X-Large"></asp:Label></h1>
	<form id="form1" runat="server">
		<div>
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
	<asp:Button ID="btnSubmit" class="form-control btn-primary" runat="server" Text="Button" OnClick="btnSubmit_Click" />
	<br />
	<asp:Label ID="lblMessage" runat="server" ></asp:Label>
		</div>
	</form>
</body>
</html>
