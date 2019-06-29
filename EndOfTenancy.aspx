<%@ Page Title="" Language="C#" MasterPageFile="~/ServicesNested.master" AutoEventWireup="true" CodeBehind="EndOfTenancy.aspx.cs" Inherits="CleaningApplication.WebForm8" %>


<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">
   
	Number of Bedrooms:
	<asp:DropDownList class="form-control" ID="dpBedrooms" runat="server"  ></asp:DropDownList>
	<br />
	Number of Bathrooms:
	<asp:DropDownList class="form-control" ID="dpBathrooms" runat="server"></asp:DropDownList>
	<asp:CheckBox ID="cbExtraToilet" runat="server" Text="Extra Toilet - $30"  />
	<br />
	Number of Garages:
	<asp:DropDownList class="form-control" ID="dpGarages" runat="server"></asp:DropDownList>
	<br />
	<b> Number of Bedrooms for window cleaning:</b>
	   <asp:CheckBoxList runat="server" ID="cbWindows" ></asp:CheckBoxList>
	<br />
	Number of Bedrooms for Ceiling cleaning:
	<asp:DropDownList class="form-control" ID="dpCeiling" runat="server"></asp:DropDownList>
	<br />
   <b> Extras:</b>
	<asp:CheckBoxList ID="cbExtras" runat="server" ></asp:CheckBoxList>
	<br />
	<asp:Button ID="btnclick" class="btn-primary form-control" runat="server" Text="Check Price" OnClick="btnclick_Click"  />
	 
    <hr />
	<br />
	
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
             <asp:AsyncPostBackTrigger ControlID="btnclick" EventName="Click" />
         </Triggers>
	</asp:UpdatePanel>
	   <hr />
    
   
    <asp:Button ID="btnBook" class="btn-success" runat="server" width="50%" Text="Add to cart" />
        
</asp:Content>
