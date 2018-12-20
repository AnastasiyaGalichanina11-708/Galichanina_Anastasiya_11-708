using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film3.Service
{
    interface IDataService<T>
    {
        void Save(T entity);
        IEnumerable<T> GetAll();
    }
}
