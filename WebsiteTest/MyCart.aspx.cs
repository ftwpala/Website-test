using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteTest
{
    public partial class MyCart : System.Web.UI.Page
    {
   
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Text = "";
           
                double finalPrice = 0;

                using (CinemaEntities3 context = new CinemaEntities3())
                {
                if (!Payment.isPaid)
                {
                    foreach (var p in context.CartTables)
                    {
                        ListBox1.Items.Add(p.movie_name);
                        finalPrice = finalPrice + p.ticket_price;
                    }
                    Label2.Text = finalPrice.ToString() + "DKK";
                }
                else
                {
                    foreach (var p in context.CartTables)
                    {
                        context.CartTables.Remove(p);
                        
                       
                    }
                    context.SaveChanges();
                    Payment.isPaid = false;
                }
                    
                }

          
           
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ListBox1.Items.Count > 0)
            {
                Response.Redirect("~/Payment.aspx");
            }
            else
            {
                Label3.Text = "No items in the cart!";
                Label3.ForeColor = System.Drawing.Color.Red;
            }
            
        }

        
    }
}