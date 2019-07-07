<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ServiceEook.aspx.cs" Inherits="CleaningApplication.WebForm14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">

    
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    <asp:Label ID="lblmessage" runat="server" Text="Label"></asp:Label>
    <asp:Table ID="tbItems" runat="server"></asp:Table>

        </form>
</asp:Content>
