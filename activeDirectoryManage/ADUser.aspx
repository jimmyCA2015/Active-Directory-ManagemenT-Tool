<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ADUser.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

    <body style="height: 450px"  >
    <form id="form1" runat="server">
    <div>
         <asp:ScriptManager ID="ScriptManager1" runat="server" />
        
       <fieldset style="background-color:lightgreen"> 
         <asp:image ID="Image1" ImageUrl="logo.jpg"  runat="server" width="40%" Height="200px" />

         <h1 style="text-align:center;position:relative;width:60%;float:right;font-size:60px;height:200px;">AD Account Admin Management</h1><fieldset style="border-color:red;position:relative;float:left;width:100%"><h2 style="color:red" >This web app helps HR department to modify employee information stored on active directory.Please use with caution.If you have any concerns,please contact IT Department immediately.</h2></fieldset>
       
        
        
            
       <asp:UpdatePanel ID="wow" runat="server">
            
           <ContentTemplate>
         <asp:GridView style="position:relative;float:left;margin-top:50PX" ID="GridView1" runat="server" AutoGenerateEditButton="True"   OnRowEditing="GridView1_RowEditing"  OnRowUpdating="GridView1_RowUpdating"   OnRowCancelingEdit="GridView1_RowCancelingEdit"   >  
                    
        </asp:GridView>
            </ContentTemplate>
         </asp:UpdatePanel>
        
      </fieldset>
    </div>
    </form>
</body>

</html>
