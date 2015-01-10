using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication6.Classes;

namespace WebApplication6
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (Session["userName"] != null)
            {
                lblUserName.Text = Session["userName"].ToString();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }*/

            
             if (Session["userData"] != null)
             {
                 UygulamaUser user = (UygulamaUser)Session["userData"];
                 lblUserName.Text = user.getUserName();
             }
             else
             {
                 Response.Redirect("Login.aspx");
             }
             
             
        }

        protected void lnkEndSession_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}