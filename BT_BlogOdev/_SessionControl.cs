using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BT_BlogOdev
{
    public class _SessionControl : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (HttpContext.Current.Session["sessionName"] == "admin")
            {
                return true;
            }
            else
            {
                httpContext.Response.Redirect("/");
                return false;
            }

        }
    }

}