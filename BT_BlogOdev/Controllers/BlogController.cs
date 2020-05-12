using BT_BlogOdev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BT_BlogOdev.Controllers
{
    public class BlogController : Controller
    {
        EvrimSevinc_BTEntities entity = new EvrimSevinc_BTEntities();
        // GET: Blog
        public ActionResult Index()
        {
           
            ViewBag.BlogType = entity.BlogTypes.ToList();
            return View(from blg in entity.Blogs.ToList() select blg);
        }

        public ActionResult Detail(int? ID)
        {
            if (ID != null)
            {
                Blog blog = entity.Blogs.FirstOrDefault(x => x.ID == ID);
                ViewBag.CommentList = entity.Comments.Where(x=>x.BlogID == ID).ToList();
                return View(blog);
            }
            else
            {
                return View();
            }
        }

        public ActionResult CommentAdd(Comment comment, int? ID)
        {
            if (ID != null)
            {
                comment.DateTime = DateTime.Now;
                comment.BlogID = ID;
                entity.Comments.Add(comment);
                entity.SaveChanges();

                return Redirect("/Blog/Detail/" + ID);
            }
            else
            {
                return View();
            }
        }
    }
}