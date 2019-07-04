<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="WebForm9.aspx.cs" Inherits="CleaningApplication.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
    <style>
    i 
{
      clear:both;
      margin-bottom:1em;
      border-bottom:1px solid #eee;
}
/* ****************** RatingStar ****************** */
.ratingStar
{
      white-space:nowrap;
      margin:1em;
      height:14px;
}
.ratingStar .ratingItem {
    font-size: 0pt;
    width: 13px;
    height: 12px;
    margin: 0px;
    padding: 0px;
    display: block;
    background-repeat: no-repeat;
      cursor:pointer;
}
.ratingStar .Filled {
    background-image: url(images/clients/filledStar.png);
}
.ratingStar .Empty {
    background-image: url(images/clients/emptyStar.png);
}
.ratingStar .Saved {
    background-image: url(images/clients/redStar.png);
}

        </style>

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <ajaxToolkit:Rating ID="Rating1" runat="server"  MaxRating="5"
                            CurrentRating="1"
                            CssClass="ratingStar"
                            StarCssClass="ratingItem"
                            WaitingStarCssClass="Saved"
                            FilledStarCssClass="Filled"
                            EmptyStarCssClass="Empty" AutoPostBack="True" OnChanged="Rating1_Changed"></ajaxToolkit:Rating>
 
    
    <asp:Label ID="labelCaption1" runat="server" Text="Selected value: " />
<asp:Label ID="labelValue1" runat="server" Text=""></asp:Label>
        </form>
</asp:Content>
