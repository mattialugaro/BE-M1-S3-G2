using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class LoginEffettuato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["LOGIN_COOKIE"];
            if (cookie != null)
            {
                string name = cookie.Values["username"];
                Response.Write($"Benvenuto {name}!");
            }
            else
            {
                Response.Redirect("Default");
            }
            
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("LOGIN_COOKIE");
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);
            Response.Redirect("Default");
        }
    }
}