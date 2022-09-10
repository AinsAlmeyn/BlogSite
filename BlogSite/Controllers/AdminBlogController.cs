using BisunessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace BlogSite.Controllers
{
    public class AdminBlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddBlog()
        {
            List<SelectListItem> selects = (from i in cm.TGetList()
                                            select new SelectListItem
                                            {
                                                Text = i.CategoryName,
                                                Value = i.CategoryId.ToString()
                                            }).ToList();
            ViewBag.select = selects;
            return View();
        }

        [HttpPost]
        public IActionResult AddBlog(Blog b)
        {
            bm.TInsert(b);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteBlog(int id)
        {
            var deger = bm.TGetById(id);
            bm.TDelete(deger);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateBlog(int id)
        {
            List<SelectListItem> selects = (from i in cm.TGetList()
                                            select new SelectListItem
                                            {
                                                Text = i.CategoryName,
                                                Value = i.CategoryId.ToString()
                                            }).ToList();
            ViewBag.select = selects;

            var value = bm.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateBlog(Blog b)
        {
            bm.TUpdate(b);
            return RedirectToAction("Index");
        }
    }
}
