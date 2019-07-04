<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="CleaningApplication.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">

  
    <h1 class="text-center"> Login</h1>
    <br />
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <table class="container form-control">
        <tr>
            <td style="height: 21px; width:15%"> <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label><br /> </td>
       
        <td style="height: 21px; width:70%">
            <asp:TextBox class="form-control" ID="txtUsername" runat="server" placeholder="Enter Username"></asp:TextBox>
            <br />
        </td>
        <td style="height: 21px; width:20%">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* Username required" ControlToValidate="txtUsername" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
       <br />
          </td>
         </tr>
        
           <tr>
            <td style="height: 21px; width:15%"> <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label> 
                <br />
            </td>
       
        <td style="height: 21px; width:70%">
            <asp:TextBox class="form-control" ID="txtPassword" runat="server" placeholder="Enter Password"></asp:TextBox>
            <br />
        </td>
        <td style="height: 21px; width:20%">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="* Password required" ControlToValidate="txtPassword" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        <br />
        </td>
         </tr>
        <br />
        <tr > <td colspan="3"><asp:Button ID="btnLogin" runat="server" Text="Login" class="form-control btn-success" OnClick="btnLogin_Click"/></td></tr>
        <tr> <td colspan="3" class="text-center"> <asp:Label ID="lblmessage" runat="server" Font-Bold="True" ForeColor="#009900" ></asp:Label></td></tr>
    </table>
    
          </form>
</asp:Content>
