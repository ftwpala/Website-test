using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteTest
{
    public partial class Login : System.Web.UI.Page
    {
        public static bool loggedIn = false;

        protected void Page_Load(object sender, EventArgs e)
        {
                      
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            using (CinemaEntities3 context = new CinemaEntities3())
            {
                UserTable users = context.UserTables.FirstOrDefault(r => r.user_name == Login1.UserName);
                if (users != null)
                {
                    if (users.password == Login1.Password)
                    {
                        e.Authenticated = true;
                        loggedIn = true;
                        

                    }
                }
                
            }
               
        }

    }
}