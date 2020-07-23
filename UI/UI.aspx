<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UI.aspx.cs" Inherits="UI_UI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="txtaddress" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="Mobile"></asp:Label>
        <asp:TextBox ID="txtmob" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button"  OnClick="Button1_Click"       />
    </div>
    </form>
</body>
</html>
