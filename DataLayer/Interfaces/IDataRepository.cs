using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IDataRepository<T> where T : BaseDataClass
    {
        T GetById(int id);

        IEnumerable<T> GetAll();
    }
}
