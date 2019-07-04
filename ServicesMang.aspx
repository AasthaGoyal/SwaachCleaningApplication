<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLogin.Master" AutoEventWireup="true" CodeBehind="ServicesMang.aspx.cs" Inherits="CleaningApplication.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server" class="form-control">
        <div class="container">
    <h2> Select a service to Modify</h2>
        <table class="form-control">
            <tr>
                <td style="width: 30%">Category&nbsp; Id:</td>
                <td >
                    <asp:TextBox ID="txtcategoryid" class="form-control" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 30%">Category Name:</td>
                <td >
                     <asp:TextBox ID="txtname" class="form-control" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 30%">Photo:</td>
                <td class="form-control">
                    <asp:Image ID="imgPhoto" runat="server" Height="151px" Width="170px" />
                    <br />
                    <asp:FileUpload ID="fpUpload" runat="server" />
                </td>
            </tr>
            <tr>
                <td style="width: 30%">Description:</td>
                <td > 
                    <asp:TextBox ID="txtDescription" class="form-control" runat="server" Height="58px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 30%">Importance Rank:
                    <br />
                </td>
                <td >
                     <asp:TextBox ID="txtrank" class="form-control" runat="server"></asp:TextBox>
                    <br />
                </td>
            </tr>
           <tr>
               <td>
                   <asp:Button ID="btnEdit" CssClass="form-control btn-success" runat="server" Text="Edit" OnClick="btnEdit_Click" />
               </td>
               <td>
                   <asp:Button ID="btnDelete" class=" btn-danger" runat="server" Text="Delete" Height="24px" Width="268px" />
               </td>
           </tr>
        </table>
        <br />
        <br />
        <asp:GridView ID="gdCategories" class="form-control" runat="server" AutoGenerateColumns="False" DataKeyNames="categoryid" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="gdCategories_SelectedIndexChanged" SelectionMethod="FullRowSelect"  BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
            <Columns>
                <asp:CommandField ButtonType="Image" ShowSelectButton="True" SelectImageUrl="~/images/background/arrow.png" >
                <ControlStyle Height="30px" Width="30px" />
                </asp:CommandField>
                <asp:BoundField DataField="categoryid" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="categoryid" />
                <asp:BoundField DataField="categoryName" HeaderText="Category Name" SortExpression="categoryName" />
                <asp:TemplateField HeaderText="Photo" SortExpression="categoryPhoto">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("categoryPhoto") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Image ID="Image1" width="60px" height="60px" runat="server" ImageUrl='<%# Bind("categoryPhoto") %>'/>
                        
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="categoryDesc" HeaderText="Description" SortExpression="categoryDesc" />
                <asp:BoundField DataField="rank" HeaderText="Rank" SortExpression="rank" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbcleaningConnectionString %>" SelectCommand="SELECT * FROM [tbcategory]"></asp:SqlDataSource>
   </div>
            </form>

</asp:Content>
