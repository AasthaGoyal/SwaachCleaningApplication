<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="WebForm13.aspx.cs" Inherits="CleaningApplication.WebForm13" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">

  
        <asp:ScriptManager ID="ToolkitScriptManager1" runat="server" ></asp:ScriptManager>
        <cc1:Rating D="Rating1" AutoPostBack="true" OnChanged="OnRatingChanged" runat="server"
    StarCssClass="Star" WaitingStarCssClass="WaitingStar" EmptyStarCssClass="Star"
    FilledStarCssClass="FilledStar" TargetControlId="lblRatingStatus" >
        </cc1:Rating>
       
     
        <br />
        <asp:Label ID="lblRatingStatus" runat="server" ></asp:Label>
    </form>

</asp:Content>  
