<%@ Page Title="" Language="C#" MasterPageFile="~/ServicesNested.master" AutoEventWireup="true" CodeBehind="2.aspx.cs" Inherits="CleaningApplication.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cont1" runat="server">
    <h2> <asp:Label ID="lblname"  runat="server" ></asp:Label></h2>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Cont2" runat="server">
    	<h3>Services/<asp:Label ID="lblname2"  runat="server" ></asp:Label></h3>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Cont3" runat="server">
    <p> <asp:label runat="server" id="lblDesc"></asp:label></p>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">

</asp:Content>
