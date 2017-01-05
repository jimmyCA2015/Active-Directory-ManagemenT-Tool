using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.DirectoryServices;
using System.Data;
using System.Collections;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;


public partial class _Default : System.Web.UI.Page
{
   
 
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {
            
            Databind();
            
            
        }
    
   
    }
     
   protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)

    {

       
        
    
     if (e.SortExpression == "FirstName")
     {
         List<ADAccount> SortedList = adlist.currentList1.OrderBy(ADAccount => ADAccount.FirstName).ToList();
         if (SortedList != null)
         {

             adlist.currentList1 = SortedList;
             GridView1.DataSource = SortedList;
             GridView1.DataBind();


         }
     }
     if (e.SortExpression == "LastName")
     {
         List<ADAccount> SortedList = adlist.currentList1.OrderBy(ADAccount => ADAccount.LastName).ToList();
         if (SortedList != null)
         {

             adlist.currentList1 = SortedList;
             GridView1.DataSource = SortedList;
             GridView1.DataBind();


         }
     }
     if (e.SortExpression == "SamAccountName")
     {
         List<ADAccount> SortedList = adlist.currentList1.OrderBy(ADAccount => ADAccount.SamAccountName).ToList();
         if (SortedList != null)
         {

             adlist.currentList1 = SortedList;
             GridView1.DataSource = SortedList;
             GridView1.DataBind();


         }
     }
     if (e.SortExpression == "JobTitle")
     {
         List<ADAccount> SortedList =adlist. currentList1.OrderBy(ADAccount => ADAccount.JobTitle).ToList();
         if (SortedList != null)
         {

             adlist.currentList1 = SortedList;
             GridView1.DataSource = SortedList;
             GridView1.DataBind();


         }
     }
    

       
        

    }
private string GetSortDirection(string column)
{

    // By default, set the sort direction to ascending.
    string sortDirection = "ASC";

    // Retrieve the last column that was sorted.
    string sortExpression = ViewState["SortExpression"] as string;

    if (sortExpression != null)
    {
        // Check if the same column is being sorted.
        // Otherwise, the default value can be returned.
        if (sortExpression == column)
        {
            string lastDirection = ViewState["SortDirection"] as string;
            if ((lastDirection != null) && (lastDirection == "ASC"))
            {
                sortDirection = "DESC";
            }
        }
    }

    // Save new values in ViewState.
    ViewState["SortDirection"] = sortDirection;
    ViewState["SortExpression"] = column;

    return sortDirection;
}




protected void text2_Click(object sender, EventArgs e)
{
    if (text1.Text != String.Empty)
    {
        DirectoryEntry myLdapConnection = createDirectoryEntry();

        // create results objects from search object  

        DirectorySearcher search = new DirectorySearcher(myLdapConnection);
        search.Filter = "(givenName=" + "*"+text1.Text +"*"+ ")";
        List<ADAccount> list = new List<ADAccount>();

        foreach (SearchResult result2 in search.FindAll())
        {
            ADAccount c1 = new ADAccount();
            c1.FirstName = GetProperty(result2, "givenName");
            c1.LastName = GetProperty(result2, "sn");
            c1.SamAccountName = GetProperty(result2, "samaccountname");
            c1.JobTitle = GetProperty(result2, "title");
            c1.Street = GetProperty(result2, "streetaddress");
            c1.City = GetProperty(result2, "l");
            c1.PostalCode = GetProperty(result2, "postalcode");
            c1.TelephoneNumber = GetProperty(result2, "telephonenumber");
            c1.Mobile = GetProperty(result2, "mobile");
            c1.Mail = GetProperty(result2, "mail");
            list.Add(c1);
        }
        List<ADAccount> objListOrder = list;

        List<ADAccount> SortedList = objListOrder.OrderBy(ADAccount => ADAccount.FirstName).ToList();
        if (SortedList != null)
        {


            GridView1.DataSource = SortedList;
            adlist.currentList1 = SortedList;
            GridView1.DataBind();
        }
    }
    else
    {
        DirectoryEntry myLdapConnection = createDirectoryEntry();

        DirectorySearcher search = new DirectorySearcher(myLdapConnection);
        List<ADAccount> list = new List<ADAccount>();


        foreach (SearchResult result2 in search.FindAll())
        {

            ADAccount c1 = new ADAccount();
            c1.FirstName = GetProperty(result2, "givenName");
            c1.LastName = GetProperty(result2, "sn");
            c1.SamAccountName = GetProperty(result2, "samaccountname");
            c1.JobTitle = GetProperty(result2, "title");
            c1.Street = GetProperty(result2, "streetaddress");
            c1.City = GetProperty(result2, "l");
            c1.PostalCode = GetProperty(result2, "postalcode");
            c1.TelephoneNumber = GetProperty(result2, "telephonenumber");
            c1.Mobile = GetProperty(result2, "mobile");
            c1.Mail = GetProperty(result2, "mail");

            list.Add(c1);
        }
        adlist.currentList1 = list;
        GridView1.DataSource = list;

        GridView1.DataBind();
        
    }
    
    
}
protected void text3_Click(object sender, EventArgs e)
{
    if (text11.Text != String.Empty)
    {
        DirectoryEntry myLdapConnection = createDirectoryEntry();

        // create results objects from search object  

        DirectorySearcher search = new DirectorySearcher(myLdapConnection);
        search.Filter = "(sn=" + "*"+text11.Text +"*"+ ")";
        List<ADAccount> list = new List<ADAccount>();

        foreach (SearchResult result2 in search.FindAll())
        {
            ADAccount c1 = new ADAccount();
            c1.FirstName = GetProperty(result2, "givenName");
            c1.LastName = GetProperty(result2, "sn");
            c1.SamAccountName = GetProperty(result2, "samaccountname");
            c1.JobTitle = GetProperty(result2, "title");
            c1.Street = GetProperty(result2, "streetaddress");
            c1.City = GetProperty(result2, "l");
            c1.PostalCode = GetProperty(result2, "postalcode");
            c1.TelephoneNumber = GetProperty(result2, "telephonenumber");
            c1.Mobile = GetProperty(result2, "mobile");
            c1.Mail = GetProperty(result2, "mail");
            list.Add(c1);
        }
        List<ADAccount> objListOrder = list;

        List<ADAccount> SortedList = objListOrder.OrderBy(ADAccount => ADAccount.LastName).ToList();
        if (SortedList != null)
        {


            GridView1.DataSource = SortedList;
            adlist.currentList1 = SortedList;
            GridView1.DataBind();
        }
    }
    else
    {
        DirectoryEntry myLdapConnection = createDirectoryEntry();

        DirectorySearcher search = new DirectorySearcher(myLdapConnection);
        List<ADAccount> list = new List<ADAccount>();


        foreach (SearchResult result2 in search.FindAll())
        {

            ADAccount c1 = new ADAccount();
            c1.FirstName = GetProperty(result2, "givenName");
            c1.LastName = GetProperty(result2, "sn");
            c1.SamAccountName = GetProperty(result2, "samaccountname");
            c1.JobTitle = GetProperty(result2, "title");
            c1.Street = GetProperty(result2, "streetaddress");
            c1.City = GetProperty(result2, "l");
            c1.PostalCode = GetProperty(result2, "postalcode");
            c1.TelephoneNumber = GetProperty(result2, "telephonenumber");
            c1.Mobile = GetProperty(result2, "mobile");
            c1.Mail = GetProperty(result2, "mail");
            list.Add(c1);
        }
        adlist.currentList1 = list;
        GridView1.DataSource = list;

        GridView1.DataBind();

    }
}
protected void text4_Click(object sender, EventArgs e)
{
    if (text111.Text != String.Empty)
    {
        DirectoryEntry myLdapConnection = createDirectoryEntry();

        // create results objects from search object  

        DirectorySearcher search = new DirectorySearcher(myLdapConnection);
        search.Filter = "(title=" + "*"+text111.Text + "*" +")";
        List<ADAccount> list = new List<ADAccount>();

        foreach (SearchResult result2 in search.FindAll())
        {
            ADAccount c1 = new ADAccount();
            c1.FirstName = GetProperty(result2, "givenName");
            c1.LastName = GetProperty(result2, "sn");
            c1.SamAccountName = GetProperty(result2, "samaccountname");
            c1.JobTitle = GetProperty(result2, "title");
            c1.Street = GetProperty(result2, "streetaddress");
            c1.City = GetProperty(result2, "l");
            c1.PostalCode = GetProperty(result2, "postalcode");
            c1.TelephoneNumber = GetProperty(result2, "telephonenumber");
            c1.Mobile = GetProperty(result2, "mobile");
            c1.Mail = GetProperty(result2, "mail");
            list.Add(c1);
        }
        List<ADAccount> objListOrder = list;

        List<ADAccount> SortedList = objListOrder.OrderBy(ADAccount => ADAccount.JobTitle).ToList();
        if (SortedList != null)
        {
            GridView1.DataSource = SortedList;
            adlist.currentList1 = SortedList;
            GridView1.DataBind();
        }
    }
    else
    {
        DirectoryEntry myLdapConnection = createDirectoryEntry();

        DirectorySearcher search = new DirectorySearcher(myLdapConnection);
        List<ADAccount> list = new List<ADAccount>();


        foreach (SearchResult result2 in search.FindAll())
        {

            ADAccount c1 = new ADAccount();
            c1.FirstName = GetProperty(result2, "givenName");
            c1.LastName = GetProperty(result2, "sn");
            c1.SamAccountName = GetProperty(result2, "samaccountname");
            c1.JobTitle = GetProperty(result2, "title");
            c1.Street = GetProperty(result2, "streetaddress");
            c1.City = GetProperty(result2, "l");
            c1.PostalCode = GetProperty(result2, "postalcode");
            c1.TelephoneNumber = GetProperty(result2, "telephonenumber");
            c1.Mobile = GetProperty(result2, "mobile");
            c1.Mail = GetProperty(result2, "mail");
            list.Add(c1);
        }
        adlist.currentList1 = list;
        GridView1.DataSource = list;

        GridView1.DataBind();

    }
}
protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
{
    //Set the edit index.
    GridView1.EditIndex = e.NewEditIndex;




    this.GridView1.DataSource = adlist.currentList1;
    this.GridView1.DataBind();
    GridView1.Rows[e.NewEditIndex].Cells[1].Enabled = false;
    GridView1.Rows[e.NewEditIndex].Cells[2].Enabled = false;
    GridView1.Rows[e.NewEditIndex].Cells[3].Enabled = false;
    GridView1.Rows[e.NewEditIndex].Cells[4].Enabled = false;
    GridView1.Rows[e.NewEditIndex].Cells[5].Enabled = false;
    GridView1.Rows[e.NewEditIndex].Cells[6].Enabled = false;
    GridView1.Rows[e.NewEditIndex].Cells[7].Enabled = false;
    GridView1.Rows[e.NewEditIndex].Cells[8].Enabled = false;
    GridView1.Rows[e.NewEditIndex].Cells[9].Enabled = false;
    GridView1.Rows[e.NewEditIndex].Cells[10].Enabled = false;
}
protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
{
   
    GridViewRow row            = (GridViewRow)GridView1.Rows[e.RowIndex];
    String firstName           =((TextBox)(row.Cells[1].Controls[0])).Text;
    String lastName            =((TextBox)(row.Cells[2].Controls[0])).Text;
    String samAccountName      =((TextBox)(row.Cells[3].Controls[0])).Text;
    String jobTitle            =((TextBox)(row.Cells[4].Controls[0])).Text;
    String street              =((TextBox)(row.Cells[5].Controls[0])).Text;
    String city                =((TextBox)(row.Cells[6].Controls[0])).Text;
    String postalCode          =((TextBox)(row.Cells[7].Controls[0])).Text;
    String telephoneNumber     =((TextBox)(row.Cells[8].Controls[0])).Text;
    String mobile              =((TextBox)(row.Cells[9].Controls[0])).Text;
    String mail                =((TextBox)(row.Cells[10].Controls[0])).Text;
    //ScriptManager.RegisterStartupScript(Page, typeof(Page), "OpenWindow", "window.open('edit.aspx?firstname1=" + firstName + "&lastname1=" + lastName + "&samaccountname1=" + samAccountName + "&jobtitle1=" + jobTitle + "&street1=" + street + "&city1=" + city + "&postalcode1=" + postalCode + "&telephonenumber1=" + telephoneNumber + "&mobile1=" + mobile + "&mail1=" + mail + "','edit','resizable,scrollbars,status,left=500,top=300,width=1000,height=400');", true);

    Response.Redirect("edit.aspx?firstname1=" + firstName + "&lastname1=" + lastName + "&samaccountname1=" + samAccountName + "&jobtitle1=" + jobTitle + "&street1=" + street + "&city1=" + city + "&postalcode1=" + postalCode + "&telephonenumber1=" + telephoneNumber + "&mobile1=" + mobile + "&mail1=" + mail + "");
    
    GridView1.EditIndex = -1;
    for (int i = 0; i < adlist.currentList1.Count; i++)
    {
        if (adlist.currentList1[i].SamAccountName == samAccountName)
        {
            adlist.currentList1[i].FirstName = firstName;
            adlist.currentList1[i].LastName = lastName;
            adlist.currentList1[i].JobTitle = jobTitle;
            adlist.currentList1[i].Street = street;
            adlist.currentList1[i].City = city;
            adlist.currentList1[i].PostalCode = postalCode;
            adlist.currentList1[i].TelephoneNumber = telephoneNumber;
            adlist.currentList1[i].Mobile = mobile;
            adlist.currentList1[i].Mail = mail;
        }
    }

    this.GridView1.DataSource = adlist.currentList1;
    
    this.GridView1.DataBind();
    
}
protected void GridView1_PageIndexChanging(Object sender, GridViewPageEventArgs e)

    {
    // Call a helper method to display the current page number 
    // when the user navigates to a different page.
        GridView1.PageIndex = e.NewPageIndex;
        adlist.currentPage = e.NewPageIndex;
     
      this.GridView1.DataSource = adlist.currentList1;

      this.GridView1.DataBind();
    }
     protected void Databind()
    {
         
        GridView1.PageIndex = adlist.currentPage;
        
      
         this.GridView1.DataSource = adlist.currentList1;

        this.GridView1.DataBind();
            
        }
        

    
     protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
     {
         GridView1.EditIndex = -1;
         this.GridView1.DataSource = adlist.currentList1;

         this.GridView1.DataBind();
       
    

     }
 
     static DirectoryEntry createDirectoryEntry()
     {
         // create and return new LDAP connection with desired settings  
         DirectoryEntry ldapConnection = new DirectoryEntry("RTSBS.RST.local");
         ldapConnection.Path = "LDAP://OU=SBSUsers,OU=Users,OU=MyBusiness,DC=RST,DC=local";
         ldapConnection.AuthenticationType = AuthenticationTypes.Secure;

         return ldapConnection;
     }
     static string GetProperty(SearchResult searchResult, string PropertyName)
     {
         if (searchResult.Properties.Contains(PropertyName))
         {
             return searchResult.Properties[PropertyName][0].ToString();
         }
         else
         {
             return string.Empty;
         }
     }

     protected void a1_Click(object sender, System.EventArgs e)
     {
         
     }
}

        


    
        

       

        

      
    

   

        

