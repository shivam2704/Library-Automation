<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    
    <asp:Label ID="Label1" runat="server" Text="Label"> Accession no : </asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:Button CssClass="button" ID="Button1" runat="server" Text="add" PostBackUrl="~/add books.aspx"/>
<asp:Button CssClass="button" ID="Button2" runat="server" Text="update" PostBackUrl="~/" />
<asp:Button CssClass="button" ID="Button3" runat="server" Text="delete" PostBackUrl="~/"/>


    
</asp:Content>

