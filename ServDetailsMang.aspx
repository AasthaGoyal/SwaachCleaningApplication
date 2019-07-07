<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ServDetailsMang.aspx.cs" Inherits="CleaningApplication.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <link href="css/bootstrap.css" rel="stylesheet" />
<link href="css/style.css" rel="stylesheet"/>
<link href="css/responsive.css" rel="stylesheet"/>
        <h2> Services Detail Management</h2>
       <br />
          <asp:DropDownList ID="dpcategory" CssClass="form-control" runat="server" DataSourceID="SqlDataSource1" DataTextField="categoryName" DataValueField="categoryName" OnSelectedIndexChanged="dpcategory_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbcleaningConnectionString %>" SelectCommand="SELECT [categoryName] FROM [tbcategory]"></asp:SqlDataSource>
        <br />
        <asp:DropDownList class="form-control" ID="dpdetails" runat="server"></asp:DropDownList>
        <br />
        The price distribution:
      <asp:GridView ID="gdInfo" class="form-control" runat="server"></asp:GridView>
        <br />
        The Extras:
        <asp:GridView ID="gdExtras" class="form-control" runat="server"></asp:GridView>
    </form>
  
</asp:Content>
