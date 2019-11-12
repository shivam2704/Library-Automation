<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="add books.aspx.cs" Inherits="add_books"%>
 
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>





<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">


<%--<form id="form1" action="#">--%>
            
               <h1 style="text-align:center; color:black">Add New Books </h1>
        <table >
         <tr>
         <td> Accession No </td>
                <td> : </td>
                <td>
                    <asp:TextBox ID="txtbook_id" runat="server" Width="156px" CssClass="txt"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td> Book Name </td>
                <td> : </td>
                <td>
                    <asp:TextBox ID="txtbook_name" runat="server" Width="156px" CssClass="txt"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Book Author </td>
                <td> : </td>
                <td>
                    <asp:TextBox ID="txtbook_author" runat="server" Width="156px" CssClass="txt"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td> Publisher </td>
                <td> : </td>
                <td>
                    <asp:TextBox ID="txtbook_publi" runat="server" Width="156px" CssClass="txt"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td> Book Type </td>
                <td> : </td>
                <td>
                    <asp:DropDownList ID="ddlbook_type" runat="server" Width="156px">
                        <asp:ListItem>Computer Science</asp:ListItem>
                        <asp:ListItem>Literarure</asp:ListItem>
                        <asp:ListItem>History</asp:ListItem>
                        <asp:ListItem>English</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Copies
                </td>
                <td> : </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="156px" CssClass="txt"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Language
                </td>
                <td> : </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="156px" CssClass="txt"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="btnadd_book" runat="server" Text="Add Book" CssClass="btn" OnClick="btnadd_book_Click" />
                </td>
                
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lbladd_book" runat="server" Text="Book Added" Visible="False" 
                        Font-Bold="True" ForeColor="Lime"></asp:Label>
                </td>
            </tr>
            </table>
        <div>
        <table>
            <tr>
                <td align="right">
                    <asp:Button ID="btn_back" runat="server" CssClass="btn" Text="Go Back" OnClick="btn_back_Click" />
                </td>
            </tr>
        </table>
    </div>
<%-- </form>--%>
 

</asp:Content>

