using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> 
    {
        List<T> List();
        int Insert(T p);
        int update(T p);
        int Delete(T p);
        T GetById(int id);

    }
}
