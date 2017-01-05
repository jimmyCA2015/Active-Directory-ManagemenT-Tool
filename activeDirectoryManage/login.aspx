<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="_Default" %>


<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">


<head id="Head1" runat="server">
<link href="style.css" rel="stylesheet" type="text/css" media="all" />

<title></title>





</head>


<body>
  <div class="message warning">
   <div class="inset">

<!--<asp:image ID="Image2" ImageUrl="logo.jpg" runat="server" width="50%" Height="400px" />-->


    <div class="login-head">
        <h1>Login Form</h1>
        <div class="alert-close"> </div>             
    </div>
<form id="form1" runat="server">
 <li>
<asp:TextBox ID="txtUsername" TEXT="USERNAME"  class="text"  runat="server"></asp:TextBox><a href="#" class=" icon user"></a>
 </li>
    <div class="clear"></div>
 <li>
<asp:TextBox ID="txtPassword" TEXT="********" runat="server" ></asp:TextBox><a href="#" class="icon lock"></a>
 </li>
    <div class="clear"></div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <div class="submit">
<asp:Button ID="btnlogin" runat="server" Text="Login" onclick="btnlogin_Click" class="submit1" />


<asp:Button ID="btnCancel"  Text="Cancel"  runat="server" style="position:relative; left:-70px"  onclick="btnCancel_Click" class="submit2"/>
       
       </div>
    <br />
    <br />
    <fieldset style="border-color:red">
<asp:Label ID="loginStat" runat="server" Text=""></asp:Label>
</fieldset>
        </form>
       </div>
      </div>
    <div class="clear"> </div>

<br />



<br /><br />


</body>
</html>