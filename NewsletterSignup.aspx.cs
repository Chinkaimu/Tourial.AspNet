using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tourial.AspNet
{
    public partial class NewsletterSignup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ltMessage.Text = "Welcome to the signup page.";
            } else
            {
                ltMessage.Text = "Again, welcome!";
            }
        }

        protected void btnButton_Click(object sender, EventArgs e)
        {
            // string email = txtEmail.Text;
        }
    }
}