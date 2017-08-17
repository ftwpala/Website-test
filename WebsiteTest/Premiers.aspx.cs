using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteTest
{
    public partial class Premiers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Visible = false;
            Button2.Visible = false;
            Button3.Visible = false;
            Label1.Visible = false;

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Button1.Visible = true;
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Button2.Visible = true;
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Button3.Visible = true;
        }




        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Login.loggedIn == true)
            {
                using (CinemaEntities3 context = new CinemaEntities3())
                {
                   
                    MovieTable movie = context.MovieTables.FirstOrDefault(r => r.Id == 1);
                    CartTable item = new CartTable
                    {
                        Id = movie.Id,
                        movie_name = movie.movie_name,
                        ticket_price = movie.ticket_price
                    };
                    
                    context.CartTables.Add(item);
                    

                    context.SaveChanges();               

                }

                Response.Redirect("~/MyCart.aspx");
            }
            else
            {
                Label1.Visible = true;
                Button1.BackColor = System.Drawing.Color.Red;
            }
            


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Login.loggedIn == true)
            {
                using (CinemaEntities3 context = new CinemaEntities3())
                {

                    MovieTable movie = context.MovieTables.FirstOrDefault(r => r.Id == 2);
                    CartTable item = new CartTable
                    {
                        Id = movie.Id,
                        movie_name = movie.movie_name,
                        ticket_price = movie.ticket_price
                    };
                    context.CartTables.Add(item);

                    context.SaveChanges();

                }

                Response.Redirect("~/MyCart.aspx");
            }
            else
            {
                Label1.Visible = true;
                Button1.BackColor = System.Drawing.Color.Red;
            }


        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Login.loggedIn == true)
            {
                using (CinemaEntities3 context = new CinemaEntities3())
                {

                    MovieTable movie = context.MovieTables.FirstOrDefault(r => r.Id == 3);
                    CartTable item = new CartTable
                    {
                        Id = movie.Id,
                        movie_name = movie.movie_name,
                        ticket_price = movie.ticket_price
                    };
                    context.CartTables.Add(item);

                    context.SaveChanges();

                }

                Response.Redirect("~/MyCart.aspx");
            }
            else
            {
                Label1.Visible = true;
                Button1.BackColor = System.Drawing.Color.Red;
            }

        }

      
    }
}