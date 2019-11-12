<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<style>

   .button{
	display: inline-block;
	color: #666;
	background-color: #eee;
	text-transform: uppercase;
	letter-spacing: 2px;
	font-size: 12px;
	padding: 10px 30px;
	border-radius: 5px;
	-moz-border-radius: 5px;
	-webkit-border-radius: 5px;
	border: 1px solid rgba(0,0,0,0.3);
	border-bottom-width: 3px;
}

	.button:hover {
		background-color: #e3e3e3;
		border-color: rgba(0,0,0,0.5);
	}
	
	.button:active {
		background-color: #CCC;
		border-color: rgba(0,0,0,0.9);
	}

    .abc {
        text-align:center;
        margin-top:20px;
    }
</style>
    
   <div class ="abc">
<asp:Button CssClass="button" ID="Button1" runat="server" Text="add" PostBackUrl="~/add books.aspx"/>
<asp:Button CssClass="button" ID="Button2" runat="server" Text="update" PostBackUrl="~/" />
<asp:Button CssClass="button" ID="Button3" runat="server" Text="delete" PostBackUrl="~/"/>
       </div>

    
</asp:Content>

