<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ServiceDetails.aspx.cs" Inherits="CleaningApplication.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="page-title" style="background-image:url(images/background/3.jpg)">
    	<div class="auto-container">
        	<h2> <asp:Label ID="lblname" runat="server" ></asp:Label></h2>
        </div>
    </section>
    <!--End Page Title-->
   <br />
   <h4 style="font-weight:bold"> Customize according to your own needs:</h4>
    <br />
    <table style="width:100%">
        <tr>
            <td style="width:30%"> Number of Bedrooms:</td>
            <td style="width:70%"> <asp:DropDownList class="form-control" ID="dpBedrooms" runat="server"></asp:DropDownList></td>
        </tr>
    </table>
</asp:Content>
