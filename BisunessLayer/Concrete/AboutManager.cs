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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutdal;
        public AboutManager(IAboutDal about)
        {
            _aboutdal = about;
        }
        public void TDelete(About value)
        {
            _aboutdal.Delete(value);
        }

        public About TGetById(int id)
        {
            return _aboutdal.GetById(id);
        }

        public List<About> TGetList()
        {
            return _aboutdal.GetList();
        }

        public void TInsert(About value)
        {
            _aboutdal.Insert(value);
        }

        public void TUpdate(About value)
        {
            _aboutdal.Update(value);
        }
    }
}
