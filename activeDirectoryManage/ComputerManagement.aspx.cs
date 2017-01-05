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



public partial class ComputerManagement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void text2_Click(object sender, EventArgs e)
    {

        if (text1.Text != String.Empty)
        {
           DirectoryEntry myLdapConnection = createDirectoryEntry();



            DirectorySearcher search = new DirectorySearcher(myLdapConnection);

            search.Filter = "(cn=" + "*" + text1.Text + "*" + ")";
            search.SizeLimit = int.MaxValue;
            search.PageSize = int.MaxValue;
            List<computer> list = new List<computer>();
            foreach (SearchResult result2 in search.FindAll())
            {

                computer c1 = new computer();
                c1.computerName = GetProperty(result2, "cn");
                c1.computerDescription = GetProperty(result2, "description");
                c1.operatingSystem = GetProperty(result2, "operatingsystem") + "     \\       " + "version:" + GetProperty(result2, "operatingsystemversion") + "      \\     " + "ServicePack:" + GetProperty(result2, "operatingsystemservicepack");


                list.Add(c1);
            }

            GridView1.DataSource = list;

            GridView1.DataBind();
        }
        
        else
        {
            DirectoryEntry myLdapConnection = createDirectoryEntry();



            DirectorySearcher search = new DirectorySearcher(myLdapConnection);

            //search.Filter = ("(objectCategory=computer)");
            search.SizeLimit = int.MaxValue;
            search.PageSize = int.MaxValue;
            List<computer> list = new List<computer>();
            foreach (SearchResult result2 in search.FindAll())
            {

                computer c1 = new computer();
                c1.computerName = GetProperty(result2, "cn");
                c1.computerDescription = GetProperty(result2, "description");
                c1.operatingSystem = GetProperty(result2, "operatingsystem") + "     \\       " + "version:" + GetProperty(result2, "operatingsystemversion") + "      \\     " + "ServicePack:" + GetProperty(result2, "operatingsystemservicepack");


                list.Add(c1);
            }

            GridView1.DataSource = list;

            GridView1.DataBind();
        }

    }
    static DirectoryEntry createDirectoryEntry()
    {
        // create and return new LDAP connection with desired settings  
        DirectoryEntry ldapConnection = new DirectoryEntry("RTSBS.RST.local");
        ldapConnection.Path = "LDAP://OU=SBSComputers,OU=Computers,OU=MyBusiness,DC=RST,DC=local";
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
    protected void Button1_Click(object sender, System.EventArgs e)
    {
        if (text11.Text != String.Empty)
        {
            DirectoryEntry myLdapConnection = createDirectoryEntry();



            DirectorySearcher search = new DirectorySearcher(myLdapConnection);

            search.Filter = "(description=" + "*" + text11.Text + "*" + ")";
            search.SizeLimit = int.MaxValue;
            search.PageSize = int.MaxValue;
            List<computer> list = new List<computer>();
            foreach (SearchResult result2 in search.FindAll())
            {

                computer c1 = new computer();
                c1.computerName = GetProperty(result2, "cn");
                c1.computerDescription = GetProperty(result2, "description");
                c1.operatingSystem = GetProperty(result2, "operatingsystem") + "     \\       " + "version:" + GetProperty(result2, "operatingsystemversion") + "      \\     " + "ServicePack:" + GetProperty(result2, "operatingsystemservicepack");


                list.Add(c1);
            }

            GridView1.DataSource = list;

            GridView1.DataBind();
        }

        else
        {
            DirectoryEntry myLdapConnection = createDirectoryEntry();



            DirectorySearcher search = new DirectorySearcher(myLdapConnection);

            //search.Filter = ("(objectCategory=computer)");
            search.SizeLimit = int.MaxValue;
            search.PageSize = int.MaxValue;
            List<computer> list = new List<computer>();
            foreach (SearchResult result2 in search.FindAll())
            {

                computer c1 = new computer();
                c1.computerName = GetProperty(result2, "cn");
                c1.computerDescription = GetProperty(result2, "description");
                c1.operatingSystem = GetProperty(result2, "operatingsystem") + "     \\       " + "version:" + GetProperty(result2, "operatingsystemversion") + "      \\     " + "ServicePack:" + GetProperty(result2, "operatingsystemservicepack");


                list.Add(c1);
            }

            GridView1.DataSource = list;

            GridView1.DataBind();
        }
    }
}