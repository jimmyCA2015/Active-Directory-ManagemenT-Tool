<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ADManagement.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       <script type="text/javascript" >
        function resizeWindow() {
            // you can get height and width from serverside as well      
           
           
            myWindow = window.open("edit.aspx", "", "width=100, height=100");
            myWindow.resizeTo(400, 400);
            myWindow.moveTo(500, 500);
            // Resizes the new window
            myWindow.focus();
        }

       </script>
    <title></title>
</head>
<body style="height: 450px"  >
    <form id="form1" runat="server">
    <div>
         <asp:ScriptManager ID="ScriptManager1" runat="server" />
        
        <fieldset style="background-color:lightgreen"> 
         <asp:image ID="Image1" ImageUrl="logo.jpg"  runat="server" width="40%" Height="200px" />

         <h1 style="text-align:center;position:relative;width:60%;float:right;font-size:60px;height:200px;">AD Account Admin Management</h1><fieldset style="border-color:red;position:relative;float:left;width:100%"><h2 style="color:red" >This web app helps HR department to modify employee information stored on active directory.Please use with caution.If you have any concerns,please contact IT Department immediately.</h2></fieldset>
         <br /><br />
        <asp:Label style="position:relative;float:left;width:10%" Text="Quick Search By First Name" runat="server"></asp:Label> <asp:textbox ID="text1" style="position:relative;float:left;width:15%" runat="server"></asp:textbox><asp:button ID="text2" style="position:relative;float:left;width:10%" runat="server" Text="search" OnClick="text2_Click" ></asp:button><asp:Label ID="blank1" Width="65%" runat="server"></asp:Label><br />
       
        <asp:Label  style="position:relative;float:left;width:10%" Text="Quick Search By Last Name" runat="server"></asp:Label> <asp:textbox ID="text11" style="position:relative;float:left;width:15%" runat="server"></asp:textbox> <asp:button ID="Button1" style="position:relative;float:left;width:10%" runat="server" Text="search" OnClick="text3_Click" ></asp:button><asp:Label ID="blank2" Width="65%" runat="server"></asp:Label><br />
        
        <asp:Label   style="position:relative;float:left;width:10%" Text="Quick Search By Job Title" runat="server"></asp:Label> <asp:textbox ID="text111" style="position:relative;float:left;width:15%" runat="server"></asp:textbox> <asp:button ID="Button2" style="position:relative;float:left;width:10%" runat="server" Text="search" OnClick="text4_Click" ></asp:button>  <asp:Label ID="blank3" Width="65%" runat="server"></asp:Label><br />
        
        
           <asp:UpdatePanel ID="wow" runat="server">
            
           <ContentTemplate>
         <asp:GridView style="position:relative;float:left" ID="GridView1" runat="server" AllowSorting="True" AutoGenerateEditButton="True" OnSorting="GridView1_Sorting"  OnRowEditing="GridView1_RowEditing"  OnRowUpdating="GridView1_RowUpdating"   OnRowCancelingEdit="GridView1_RowCancelingEdit"  onpageindexchanging="GridView1_PageIndexChanging"  AllowPaging="true" PageSize="30">  
                    
        </asp:GridView>
            </ContentTemplate>
         </asp:UpdatePanel>
        
      </fieldset>
    </div>
    </form>
</body>
</html>
