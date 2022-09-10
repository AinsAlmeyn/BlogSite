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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;
        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public void TDelete(Category value)
        {
            _categorydal.Delete(value);
        }

        public Category TGetById(int id)
        {
            return _categorydal.GetById(id);
        }

        public List<Category> TGetList()
        {
            return _categorydal.GetList();
        }

        public void TInsert(Category value)
        {
            _categorydal.Insert(value);
        }

        public void TUpdate(Category value)
        {
            _categorydal.Update(value);
        }
    }
}
