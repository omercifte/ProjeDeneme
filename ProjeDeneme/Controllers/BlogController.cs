using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeDeneme.Models;
using PagedList;
using PagedList.Mvc;

namespace ProjeDeneme.Controllers
{
    public class BlogController : Controller
    {
        DBDenemeEntities db=new DBDenemeEntities();
        // GET: Blog
        public ActionResult Index(int page=1)
        {
            var blog = db.Blogs.OrderByDescending(b => b.BlogID).ToPagedList(page,3);

            return View(blog);
        }
        public ActionResult Hakkinda()
        {
            var hakkinda = db.Hakkindas.ToList();
            return View(hakkinda);  
        }
        public ActionResult BlogDetay (int id)
        {
            var blogdetay = db.Blogs.Where(b => b.BlogID == id).SingleOrDefault();
            if(blogdetay==null)
            {
                return HttpNotFound();
            }
            return View(blogdetay);
        }
        public ActionResult OkunmaArttir(int blogid)
        {
            var blog = db.Blogs.Where(b => b.BlogID == blogid).SingleOrDefault();
            blog.BlogOkumaSayisi = blog.BlogOkunmaSayisi + 1;
            db.SaveChanges();
            return View();
        }
    }
}