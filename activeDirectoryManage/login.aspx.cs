using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtUsername.Attributes.Add("onFocus", "this.value = '';");




        txtUsername.Attributes.Add("onblur", "if (this.value == '') {this.value = 'USERNAME';}");

        txtPassword.Attributes.Add("onFocus", "this.value = '';");




        txtPassword.Attributes.Add("onblur", "if (this.value == '') {this.value = '********';}");
    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        bool validated = false;
        for (int i = 0; i < 10; i++)
        {
            if (txtUsername.Text == System.Web.Configuration.WebConfigurationManager.AppSettings["UserName" + i] && txtPassword.Text == System.Web.Configuration.WebConfigurationManager.AppSettings["Password" + i])
            {
                
                currentUser.getUser=txtUsername.Text;
                validated = true;
                if (currentUser.getUser == "admin")
                {
                    Response.Redirect("~/ADMAIN.aspx?");
                }
                else
                    Response.Redirect("~/ADUser.aspx?");
                loginStat.Text = "login successful";
                break;

            }
        }
        
        if (!validated)
        {

            loginStat.Text = "Incorrect username or password,login fail";
            loginStat.Attributes["style"] = "color:red; font-weight:bold;";

        }
        

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtUsername.Text = "";
        txtPassword.Text = "";

    }
}