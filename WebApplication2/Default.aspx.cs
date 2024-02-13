using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["LOGIN_COOKIE"] != null)
            {
                Response.Redirect("LoginEffettuato");
            }
            else
            {
                // Response.Redirect("Default");
            }
            
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("LOGIN_COOKIE"); // creo il cookie
            cookie.Values["username"] = username.Text;          // assegno i valori che mi servono al cookie
            cookie.Expires = DateTime.Now.AddDays(10);          // assegno un tempo di vita al cookie
            Response.Cookies.Add(cookie);                       // invio il cookie al client
            
            Response.Redirect("LoginEffettuato");               // client reinderizzato alla pagina con il cookie
        }
    }
}