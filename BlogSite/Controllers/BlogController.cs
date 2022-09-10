using BisunessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogSite.Controllers
{
    public class BlogController : Controller
    {
        BlogManager mb = new BlogManager(new EfBlogDal());
        public IActionResult Index()
        {
            var degerler = mb.TGetList();
            return View(degerler);
        }
    }
}
