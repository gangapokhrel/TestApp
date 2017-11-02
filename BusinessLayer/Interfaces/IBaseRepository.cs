using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IBaseRepository
    {
        object Get(int id);
        IEnumerable<object> Get();
        bool Creaate(object o);
        bool Update(object o);
        bool Delete(int id);
    }
}
