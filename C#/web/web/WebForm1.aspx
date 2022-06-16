<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" >F_name</asp:Label>
        <asp:TextBox ID="F_name" runat="server"></asp:TextBox>

         <asp:Label ID="Label2" runat="server" >L_name</asp:Label>
        <asp:TextBox ID="L_name" runat="server"></asp:TextBox>

        <asp:Label ID="Label5" runat="server">Full_Name</asp:Label>
        <asp:TextBox ID="Full_Name" runat="server"></asp:TextBox>

        <asp:Button ID="SubmitButton" runat="server" Text="Button" />
       
    </form>  
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
</html>
