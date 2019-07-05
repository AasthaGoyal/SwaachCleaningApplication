<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm9.aspx.cs" Inherits="CleaningApplication.WebForm9" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            
            <ajaxToolkit:Rating ID="Rating1" runat="server"
                 MaxRating="5"
    CurrentRating="2"
    CssClass="ratingStar"
    StarCssClass="ratingItem"
    WaitingStarCssClass="Saved"
    FilledStarCssClass="Filled"
    EmptyStarCssClass="Empty"></ajaxToolkit:Rating>
        </div>
    </form>
</body>
</html>
