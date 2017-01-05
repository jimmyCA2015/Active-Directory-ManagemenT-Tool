using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for currentUser
/// </summary>
public class currentUser
{
	
		private static String userlogin="";
       
    
       public static string getUser
       {
        get { return userlogin; }
        set {  userlogin= value; }
        
      }
	
}
