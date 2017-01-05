using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.DirectoryServices;

public partial class _Default : System.Web.UI.Page
{
    public static String firstname1;
    public static String lastname1;
    public static String samaccountname1;
    public static String jobtitle1;
    public static String street1;
    public static String city1;
    public static String postalcode1;
    public static String telephonenumber1;
    public static String mobile1;
    public static String mail1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            HttpRequest q = Request;
            firstname1 = q.QueryString["firstname1"];
            lastname1 = q.QueryString["lastname1"];
            samaccountname1 = q.QueryString["samaccountname1"];
            jobtitle1 = q.QueryString["jobtitle1"];
            street1 = q.QueryString["street1"];
            city1 = q.QueryString["city1"];
            postalcode1 = q.QueryString["postalcode1"];
            telephonenumber1 = q.QueryString["telephonenumber1"];
            mobile1 = q.QueryString["mobile1"];
            mail1 = q.QueryString["mail1"];
            Textbox1.Text = firstname1;
            Textbox2.Text = lastname1;
            Textbox3.Text = samaccountname1;
            Textbox4.Text = jobtitle1;
            Textbox5.Text = street1;
            Textbox6.Text = city1;
            Textbox7.Text = postalcode1;
            Textbox8.Text = telephonenumber1;
            Textbox9.Text = mobile1;
            Textbox10.Text = mail1;
        }
    }
    protected void button1_Click(object sender, EventArgs e)
    {
        DirectoryEntry myLdapConnection = createDirectoryEntry();

        // create results objects from search object  

        DirectorySearcher search = new DirectorySearcher(myLdapConnection);
        search.Filter = "(samaccountname=" + samaccountname1 + ")";

        SearchResult result = search.FindOne();
        if (result != null)
        {
            // create new object from search result  

            DirectoryEntry entryToUpdate = result.GetDirectoryEntry();





            if (telephonenumber1 != String.Empty)
            {

                entryToUpdate.Properties["telephoneNumber"].Value = Textbox8.Text;
            }
            if (telephonenumber1 == String.Empty)
            {
                entryToUpdate.Properties["telephoneNumber"].Value = null;
            }


            if (street1 != String.Empty)
            {
                entryToUpdate.Properties["streetaddress"].Value = Textbox5.Text;
            }
            if (street1 == String.Empty)
            {
                entryToUpdate.Properties["streetaddress"].Value = null;
            }
            if (city1 != String.Empty)
            {
                entryToUpdate.Properties["l"].Value = Textbox6.Text;
            }
            if (city1 == String.Empty)
            {
                entryToUpdate.Properties["l"].Value = null;
            }
            if (postalcode1 != String.Empty)
            {
                entryToUpdate.Properties["postalcode"].Value = Textbox7.Text;

            }
            if (postalcode1 == String.Empty)
            {
                entryToUpdate.Properties["postalcode"].Value = null;

            }
            if (mobile1 != String.Empty)
            {
                entryToUpdate.Properties["mobile"].Value = Textbox9.Text;
            }
            if (mobile1 == String.Empty)
            {
                entryToUpdate.Properties["mobile"].Value = null;
            }




            entryToUpdate.CommitChanges();


        }
        for (int i = 0; i < adlist.getEmployee().Count; i++)
        {
           
            if (adlist.currentList2[i].SamAccountName == Textbox3.Text)
            {
                adlist.currentList2[i].FirstName = Textbox1.Text;
                adlist.currentList2[i].LastName = Textbox2.Text;
                adlist.currentList2[i].JobTitle = Textbox4.Text;
                adlist.currentList2[i].Street = Textbox5.Text;
                adlist.currentList2[i].City = Textbox6.Text;
                adlist.currentList2[i].PostalCode = Textbox7.Text;
                adlist.currentList2[i].TelephoneNumber = Textbox8.Text;
                adlist.currentList2[i].Mobile = Textbox9.Text;
                adlist.currentList2[i].Mail = Textbox10.Text;
            }
        }
        Response.Redirect("ADUser.aspx");
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
    protected void button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("ADUser.aspx");

    }
}