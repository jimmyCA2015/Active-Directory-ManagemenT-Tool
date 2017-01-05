<%@ Page Language="C#" AutoEventWireup="true" CodeFile="edit2.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

   <body >
      
   
    <form id="form1" runat="server">
    <div>
        <fieldset style="background-color:lightblue" >
       <asp:label id="label1" runat="server"> FirstName</asp:label>
       <asp:textbox id="Textbox1" runat="server" style="position:absolute;left:120px" ReadOnly="true"></asp:textbox>
        <br /> <br />
       <asp:label id="label2" runat="server">LastName</asp:label>
       <asp:textbox id="Textbox2" runat="server" style="position:absolute;left:120px" ReadOnly="true"></asp:textbox>
        <br /> <br />
       <asp:label id="label3" runat="server">SamAccount</asp:label>
       <asp:textbox id="Textbox3" runat="server" style="position:absolute;left:120px" ReadOnly="true"></asp:textbox>
        <br /> <br />
        <asp:label id="label4" runat="server">JobTitle</asp:label>
       <asp:textbox id="Textbox4" runat="server" style="position:absolute;left:120px" ReadOnly="true"></asp:textbox>
        <br /> <br />
         <asp:label id="label5" runat="server">StreetAddress</asp:label>
       <asp:textbox id="Textbox5" runat="server" style="position:absolute;left:120px"></asp:textbox>
        <br /> <br />
         <asp:label id="label6" runat="server">City</asp:label>
       <asp:textbox id="Textbox6" runat="server" style="position:absolute;left:120px"></asp:textbox>
        <br /> <br />
         <asp:label id="label7" runat="server">PostalCode</asp:label>
       <asp:textbox id="Textbox7" runat="server" style="position:absolute;left:120px"></asp:textbox>
        <br /> <br />
         <asp:label id="label8" runat="server">Telephone</asp:label>
       <asp:textbox id="Textbox8" runat="server" style="position:absolute;left:120px" ></asp:textbox>
        <br /> <br />
         <asp:label id="label9" runat="server">Mobile</asp:label>
       <asp:textbox id="Textbox9" runat="server" style="position:absolute;left:120px" ></asp:textbox>
        <br /> <br />

         <asp:label id="label10" runat="server">Mail</asp:label>
       <asp:textbox id="Textbox10" runat="server" style="position:absolute;left:120px" ReadOnly="true"></asp:textbox>
        <br /> <br />
      <asp:Button ID="button1" Text="update" runat="server" OnClick="button1_Click" autopostback="true"/>
       <asp:Button ID="button2" Text="cancel" runat="server" OnClick="button2_Click" />

        </fieldset>  
         
    </div>
    </form>
</body>

</html>
