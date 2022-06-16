<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication6.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            f_name<asp:TextBox ID="TextName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="user name mandatory" ControlToValidate="TextName" Display="Dynamic" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
        </div>
        <p>
            email<asp:TextBox ID="TextEmail" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextEmail" Display="Dynamic" ErrorMessage="incorrect email" ForeColor="#CC0066" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">email mandatory</asp:RegularExpressionValidator>
        </p>
        <p>
            password<asp:TextBox ID="TextPwd" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="enter string" ControlToValidate="TextPwd" Display="Dynamic" ForeColor="#66FF99" SetFocusOnError="True">enter crct pwd</asp:CustomValidator>
        </p>
        confirm<asp:TextBox ID="TextCon" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="CompareValidator" ControlToCompare="TextPwd" ControlToValidate="TextCon" Display="Dynamic" ForeColor="#0099CC" SetFocusOnError="True">same pwd</asp:CompareValidator>
        <p>
            age<asp:TextBox ID="TextAge" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="numbers" ControlToValidate="TextAge" Display="Dynamic" ForeColor="#66FF66" MaximumValue="50" MinimumValue="18" SetFocusOnError="True" Type="Integer">18 above</asp:RangeValidator>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="thank you"></asp:Label>
            <asp:Button ID="Button1" runat="server" Height="52px" OnClick="Button1_Click" style="margin-top: 47px" Text="Button" />
        </p>
    </form>
</body>
</html>
