using BT_BlogOdev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace BT_BlogOdev.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            EvrimSevinc_BTEntities entity = new EvrimSevinc_BTEntities();
            ViewBag.BlogType = entity.BlogTypes.ToList();
            return View(from blg in entity.Blogs.ToList() select blg);
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        
    }
}