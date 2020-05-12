using BT_BlogOdev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BT_BlogOdev.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [AllowAnonymous]
        public ActionResult Login()
        {
            if (String.IsNullOrEmpty(HttpContext.User.Identity.Name))
            {
                FormsAuthentication.SignOut();
                return View();
            }
            return Redirect("/");


        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(UserAuthorize model, string returnurl)
        {
            EvrimSevinc_BTEntities entity = new EvrimSevinc_BTEntities();
            if (ModelState.IsValid)
            {

                if (entity.Users.FirstOrDefault(a => a.EMail == model.EMail && a.Password == model.Password) != null)
                {
                    Session["sessionName"] = "admin";
                    return RedirectToAction("Index", "ControlPanel");
                }

                else
                {
                    ModelState.AddModelError("", "EMail veya şifre hatalı!");
                }
            }
            return View(model);
        }
    }
}