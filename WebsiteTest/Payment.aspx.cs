using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteTest
{
    public partial class Payment : System.Web.UI.Page
    {
        public static bool isPaid = false;

         bool isCardValid
         {
             get
             {
                 object o = ViewState["isCardValid"];
                 if (o == null) return false;
                 return (bool)o;
             }
             set
             {
                 ViewState["isCardValid"] = value;
             }
         }
         

     
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cardNumber = TextBox1.Text.ToString();
            string expDate = TextBox2.Text.ToString();


            WebServiceCinema.CreditCardValidatorSoapClient client =
                new WebServiceCinema.CreditCardValidatorSoapClient("CreditCardValidatorSoap1");

            int validation = client.ValidCard(cardNumber, expDate);

            if (validation == 0)
            {
                isCardValid = true;
                TextBox1.BackColor = System.Drawing.Color.Green;
                TextBox2.BackColor = System.Drawing.Color.Green;
            }
            else
            {    
                TextBox1.BackColor = System.Drawing.Color.Red;
                TextBox2.BackColor = System.Drawing.Color.Red;
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {       
                if (isCardValid)
                {
                    Label1.Text = "Payment successful!";
                    Label1.ForeColor = System.Drawing.Color.Green;
                    isPaid = true;
                }
                else
                {
                    Label1.Text = "Enter valid card number!";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
            }
                  
    }
}