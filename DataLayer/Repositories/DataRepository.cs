using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataLayer.Interfaces;
using DataLayer.Contexts;

namespace DataLayer.Repositories
{
    public class DataRepository<T> : IDataRepository<T> where T : BaseDataClass
    {
        protected BattleshipContext _dbContext;

        public DataRepository(BattleshipContext context)
        {
            _dbContext = context;
        }

        public T GetById(int id)
        {
            return _dbContext.Find<T>(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }
    }
}
