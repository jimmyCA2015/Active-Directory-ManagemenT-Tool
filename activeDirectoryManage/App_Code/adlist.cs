using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.DirectoryServices;
using System.Data;

/// <summary>
/// Summary description for adlist
/// </summary>
public class adlist
{
    private static List<ADAccount> Listcurrent=getUser();
    private static List<ADAccount> Listcurrent2=getEmployee();
    private static int currentPageIndex;
    
    public static List<ADAccount> currentList1
    {
        get { return Listcurrent; }
        set {  Listcurrent= value; }
        
    }
    public static List<ADAccount> currentList2
    {
        get { return Listcurrent2; }
        set { Listcurrent2 = value; }

    }
    public static int currentPage
    {
        get { return currentPageIndex; }
        set { currentPageIndex = value; }

    }
    static   List<ADAccount> getUser()
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
        return list;
    }
   public static List<ADAccount> getEmployee()
    {
        DirectoryEntry myLdapConnection = createDirectoryEntry();
        DirectorySearcher search = new DirectorySearcher(myLdapConnection);
        List<ADAccount> list = new List<ADAccount>();

        search.Filter = "(samaccountname=" + currentUser.getUser + ")";

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
        return list;
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

}