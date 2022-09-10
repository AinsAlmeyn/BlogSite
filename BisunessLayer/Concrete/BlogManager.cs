using BisunessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisunessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogdal;
        public BlogManager(IBlogDal blogdal)
        {
            _blogdal = blogdal;
        }
        public List<Blog> GetBlogListWithCategory()
        {
            return _blogdal.GetListWithCategory();
        }

        public void TDelete(Blog value)
        {
            _blogdal.Delete(value);
        }

        public Blog TGetById(int id)
        {
            return _blogdal.GetById(id);
        }

        public List<Blog> TGetList()
        {
            return _blogdal.GetList();
        }

        public void TInsert(Blog value)
        {
            _blogdal.Insert(value);
        }

        public void TUpdate(Blog value)
        {
            _blogdal.Update(value);
        }
    }
}
