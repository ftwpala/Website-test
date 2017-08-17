using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteTest
{
  
    public partial class MainPage : System.Web.UI.MasterPage
    {
   
        protected void Page_Load(object sender, EventArgs e)
        {
           if (Menu1.FindItem("Login") == null)
            {
                Menu1.Items.Add(new MenuItem
                {
                    Text = "Login",
                    NavigateUrl = "~/Login.aspx"
                });
            }


           if (Login.loggedIn == true)
            {
                Menu1.Items.Remove(Menu1.FindItem("Login"));

                if (Menu1.FindItem("My account") == null)
                {
                    Menu1.Items.Add(new MenuItem
                    {
                        Text = "My account",
                        NavigateUrl = "~/Account.aspx"
                    });
                    Menu1.FindItem("My account").ChildItems.Add(new MenuItem
                    {
                        Text = "My cart",
                        NavigateUrl = "~/MyCart.aspx"
                    });
                    Menu1.FindItem("My account").ChildItems.Add(new MenuItem
                    {
                        Text = "Log out",
                        NavigateUrl = "~/LogOut.aspx"
                    });

                }
                
               
            }
        }

       
    }
}