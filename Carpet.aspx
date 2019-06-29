<%@ Page Title="" Language="C#" MasterPageFile="~/ServicesNested.master" AutoEventWireup="true" CodeBehind="Carpet.aspx.cs" Inherits="CleaningApplication.WebForm9" %>

<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">
    <asp:DropDownList ID="dpCarpet" CssClass="form-control" runat="server"></asp:DropDownList>
	<br />
	Enter the Area Sq Meters:
	<asp:TextBox ID="txtarea" class="form-control" runat="server"  ></asp:TextBox>
	<br />
     <asp:CheckBox ID="cbExtra" class="form-control" runat="server" Text="Stair Cleaning - $25" />
    <br />
    <asp:Button ID="btnClick" class="form-control btn-primary" runat="server" Text="Check Price" OnClick="btnClick_Click" />
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
           

            <asp:table ID="myTable" runat="server" class="form-control" BorderStyle="Solid" >
	  <asp:tableRow Width="100%">
		  <asp:tablecell width="90%" style="text-align:left"> <b>Items:</b></asp:tablecell>
		  <asp:tablecell width="10%" style=" font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif; font-size: medium; font-weight: bold; text-transform: capitalize; text-align:right"> <b>Price: </b> </asp:tablecell>
	  </asp:tableRow>
	 
  </asp:table>
	<hr />
	<br />
	<asp:Table ID="total" runat="server" CssClass="form-control" BackColor="#CC0000" Font-Bold="True" ForeColor="White">
		<asp:TableRow Width="100%">
			<asp:TableCell Width="90%"  style="text-align:left">
				Total Price:
			</asp:TableCell>
			<asp:TableCell Width="10%"  style="text-align:right">
				<asp:Label ID="lblTotal" runat="server"></asp:Label>
			</asp:TableCell>

		</asp:TableRow>
	</asp:Table>
        </ContentTemplate>

        <Triggers>
             <asp:AsyncPostBackTrigger ControlID="btnClick" EventName="Click" />
         </Triggers>
    </asp:UpdatePanel>

    
	
    <br />
     <asp:Button ID="btnBook" class="btn-success" runat="server" width="50%" Text="Add to cart" />
    
   
</asp:Content>
