using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisunessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T value);
        void TDelete(T value);
        void TUpdate(T value);
        List<T> TGetList();
        T TGetById(int id);
    }
}
