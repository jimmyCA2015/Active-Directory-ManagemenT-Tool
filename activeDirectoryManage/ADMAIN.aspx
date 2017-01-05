<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ADMAIN.aspx.cs" Inherits="ADMAIN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url(manage.jpg);background-size:100%,100%" > 
    <form id="form1" runat="server">
    <div>
        <asp:image ID="Image1" ImageUrl="logo.jpg"  runat="server" width="100%" Height="200px" />
        <asp:Label style="position:absolute;left:50px;top:220px;height:30px;font:bold;font-size:x-large;width:300px;color:red" Text="User Account Management" runat="server"></asp:Label>
        <asp:ImageButton src="user.jpg" style="position:absolute;left:50px;width:100px;top:270px;" runat="server" OnClick="Unnamed2_Click"></asp:ImageButton>
         <asp:Label ID="Label1" style="position:absolute;left:700px;top:220px;height:30px;font:bold;font-size:x-large;width:400px;color:red" Text="Computer Account Management" runat="server"></asp:Label>
         <asp:ImageButton ID="ImageButton1" src="computer.png" style="position:absolute;left:700px;width:100px;top:270px;" runat="server" OnClick="ImageButton1_Click"></asp:ImageButton>
    </div>
    </form>
</body>
</html>
