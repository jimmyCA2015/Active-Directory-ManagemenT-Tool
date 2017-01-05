<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ComputerManagement.aspx.cs" Inherits="ComputerManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
    <div>
         <asp:ScriptManager ID="ScriptManager1" runat="server" />
        
        <fieldset style="background-color:lightgreen"> 
         <asp:image ID="Image1" ImageUrl="logo.jpg"  runat="server" width="40%" Height="200px" />

         <h1 style="text-align:center;position:relative;width:60%;float:right;font-size:60px;height:200px;">Computer Account Admin Management</h1><fieldset style="border-color:red;position:relative;float:left;width:100%"><h2 style="color:red" >This web app helps HR department to modify employee information stored on active directory.Please use with caution.If you have any concerns,please contact IT Department immediately.</h2></fieldset>
         <br /><br />
        <asp:Label ID="Label1" style="position:relative;float:left;width:10%" Text="Quick Search By Computer Name" runat="server"></asp:Label> <asp:textbox ID="text1" style="position:relative;float:left;width:15%" runat="server"></asp:textbox><asp:button ID="text2" style="position:relative;float:left;width:10%" runat="server" Text="search" OnClick="text2_Click"></asp:button><asp:Label ID="blank1" Width="65%" runat="server"></asp:Label><br />
         <asp:Label ID="Label2"  style="position:relative;float:left;width:10%" Text="Quick Search By Owner Name" runat="server"></asp:Label> <asp:textbox ID="text11" style="position:relative;float:left;width:15%" runat="server"></asp:textbox> <asp:button ID="Button1" style="position:relative;float:left;width:10%" runat="server" Text="search" OnClick="Button1_Click"  ></asp:button><asp:Label ID="blank2" Width="65%" runat="server"></asp:Label><br />
           <asp:UpdatePanel ID="wow" runat="server">
            
           <ContentTemplate>
         <asp:GridView style="position:relative;float:left" ID="GridView1" runat="server" AllowSorting="True" AutoGenerateEditButton="True"  >  
                    
        </asp:GridView>
            </ContentTemplate>
         </asp:UpdatePanel>
        
      </fieldset>
    </div>
    </form>
</body>
</html>
