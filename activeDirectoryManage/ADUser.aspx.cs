using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.DirectoryServices;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

            Databind();


        }


    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //Set the edit index.
        GridView1.EditIndex = e.NewEditIndex;




        this.GridView1.DataSource = adlist.currentList2;
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

        GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
        String firstName = ((TextBox)(row.Cells[1].Controls[0])).Text;
        String lastName = ((TextBox)(row.Cells[2].Controls[0])).Text;
        String samAccountName = ((TextBox)(row.Cells[3].Controls[0])).Text;
        String jobTitle = ((TextBox)(row.Cells[4].Controls[0])).Text;
        String street = ((TextBox)(row.Cells[5].Controls[0])).Text;
        String city = ((TextBox)(row.Cells[6].Controls[0])).Text;
        String postalCode = ((TextBox)(row.Cells[7].Controls[0])).Text;
        String telephoneNumber = ((TextBox)(row.Cells[8].Controls[0])).Text;
        String mobile = ((TextBox)(row.Cells[9].Controls[0])).Text;
        String mail = ((TextBox)(row.Cells[10].Controls[0])).Text;
        //ScriptManager.RegisterStartupScript(Page, typeof(Page), "OpenWindow", "window.open('edit.aspx?firstname1=" + firstName + "&lastname1=" + lastName + "&samaccountname1=" + samAccountName + "&jobtitle1=" + jobTitle + "&street1=" + street + "&city1=" + city + "&postalcode1=" + postalCode + "&telephonenumber1=" + telephoneNumber + "&mobile1=" + mobile + "&mail1=" + mail + "','edit','resizable,scrollbars,status,left=500,top=300,width=1000,height=400');", true);

        Response.Redirect("edit2.aspx?firstname1=" + firstName + "&lastname1=" + lastName + "&samaccountname1=" + samAccountName + "&jobtitle1=" + jobTitle + "&street1=" + street + "&city1=" + city + "&postalcode1=" + postalCode + "&telephonenumber1=" + telephoneNumber + "&mobile1=" + mobile + "&mail1=" + mail + "");

        GridView1.EditIndex = -1;
        for (int i = 0; i < adlist.getEmployee().Count; i++)
        {
            List<ADAccount> temp = adlist.getEmployee();
            if (temp[i].SamAccountName == samAccountName)
            {
                temp[i].FirstName = firstName;
                temp[i].LastName = lastName;
                temp[i].JobTitle = jobTitle;
                temp[i].Street = street;
                temp[i].City = city;
                temp[i].PostalCode = postalCode;
                temp[i].TelephoneNumber = telephoneNumber;
                temp[i].Mobile = mobile;
                temp[i].Mail = mail;
            }
        }

        this.GridView1.DataSource = adlist.getEmployee();

        this.GridView1.DataBind();



    }
    
    protected void Databind()
    {


        adlist.currentList2 =adlist.getEmployee();
        
        this.GridView1.DataSource = adlist.currentList2;

        this.GridView1.DataBind();

    }



    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        this.GridView1.DataSource = adlist.currentList2;

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