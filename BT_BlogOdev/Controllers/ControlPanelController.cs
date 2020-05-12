using BT_BlogOdev.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BT_BlogOdev.Controllers
{
    [_SessionControl]
    public class ControlPanelController : Controller
    {
        EvrimSevinc_BTEntities entity = new EvrimSevinc_BTEntities();
        public ActionResult Index()
        {
            return View(entity.Blogs.ToList());
        }

        public ActionResult Add(int? ID)
        {
            ViewBag.BlogTypeList = entity.BlogTypes.ToList();
            if (ID != null)
            {
                Blog blog = entity.Blogs.FirstOrDefault(x => x.ID == ID);
                return View(blog);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult Add(Blog blog, int? ID, HttpPostedFileBase ImageURL)
        {
            if (string.IsNullOrWhiteSpace(blog.BlogTitle) | string.IsNullOrWhiteSpace(blog.BlogDescription) | (blog.BlogType == 0 || blog.BlogType == null))
            {
                return View();
            }
            ViewBag.BlogTypeList = entity.BlogTypes.ToList();
            if ( ID != null)
            {
                Blog oldBlog = entity.Blogs.FirstOrDefault(x => x.ID == ID);
                oldBlog.BlogTitle = blog.BlogTitle;
                oldBlog.BlogDescription = blog.BlogDescription;
                if (blog.ImageURL != null)
                {
                    oldBlog.ImageURL = Path.GetFileName(ImageURL.FileName);
                    string path = Path.Combine(Server.MapPath("~/upload"), Path.GetFileName(ImageURL.FileName));
                    ImageURL.SaveAs(path);

           
                }
                oldBlog.BlogType = blog.BlogType;
                oldBlog.BlogWriter = blog.BlogWriter;
                blog.Datetime = DateTime.Now;
            }
            else
            {
                if (blog.ImageURL != null)
                {
                    string path = Path.Combine(Server.MapPath("~/upload"), Path.GetFileName(ImageURL.FileName));
                    ImageURL.SaveAs(path);
                }
                blog.Datetime = DateTime.Now;
                entity.Blogs.Add(blog);
            }
            entity.SaveChanges();
            return Redirect("/ControlPanel/Index");
        }

        public ActionResult Delete(int? ID)
        {
            bool result = false;
            if (ID != null)
            {
                Blog blog = entity.Blogs.FirstOrDefault(x => x.ID == ID);
                entity.Blogs.Remove(blog);
                entity.SaveChanges();
                result = true;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return View();
            }
        }
    }
}