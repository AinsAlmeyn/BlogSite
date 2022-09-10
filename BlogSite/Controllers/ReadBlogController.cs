using BisunessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogSite.Controllers
{
    public class ReadBlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogDal());
        public IActionResult Index(int id)
        {
            var value = bm.TGetById(id);
            return View(value);
        }
    }
}
